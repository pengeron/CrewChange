using CrewChange.Application.Interfaces;
using CrewChange.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrewChange.API.Controllers;

[ApiController]
[Route("api/employees/{employeeId}/certifications")]
public class EmployeeCertificationsController : ControllerBase
{
    private readonly IEmployeeCertificationRepository _certificationRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IBlobStorageService _blobStorageService;

    public EmployeeCertificationsController(
        IEmployeeCertificationRepository certificationRepository,
        IEmployeeRepository employeeRepository,
        IBlobStorageService blobStorageService)
    {
        _certificationRepository = certificationRepository;
        _employeeRepository = employeeRepository;
        _blobStorageService = blobStorageService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmployeeCertification>>> GetEmployeeCertifications(int employeeId)
    {
        if (!await _employeeRepository.ExistsAsync(employeeId))
        {
            return NotFound();
        }

        var certifications = await _certificationRepository.GetAllByEmployeeIdAsync(employeeId);
        return Ok(certifications);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EmployeeCertification>> GetEmployeeCertification(int employeeId, int id)
    {
        var certification = await _certificationRepository.GetByIdAsync(id);
        if (certification == null || certification.EmployeeId != employeeId)
        {
            return NotFound();
        }

        return Ok(certification);
    }

    [HttpPost]
    public async Task<ActionResult<EmployeeCertification>> CreateEmployeeCertification(
        int employeeId,
        [FromForm] EmployeeCertification certification,
        IFormFile? imageFile)
    {
        if (!await _employeeRepository.ExistsAsync(employeeId))
        {
            return NotFound();
        }

        certification.EmployeeId = employeeId;

        if (imageFile != null)
        {
            using var stream = imageFile.OpenReadStream();
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(imageFile.FileName)}";
            certification.ImageUrl = await _blobStorageService.UploadFileAsync(fileName, stream);
        }

        var createdCertification = await _certificationRepository.AddAsync(certification);
        return CreatedAtAction(
            nameof(GetEmployeeCertification),
            new { employeeId, id = createdCertification.Id },
            createdCertification);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployeeCertification(
        int employeeId,
        int id,
        [FromForm] EmployeeCertification certification,
        IFormFile? imageFile)
    {
        if (id != certification.Id || employeeId != certification.EmployeeId)
        {
            return BadRequest();
        }

        var existingCertification = await _certificationRepository.GetByIdAsync(id);
        if (existingCertification == null || existingCertification.EmployeeId != employeeId)
        {
            return NotFound();
        }

        if (imageFile != null)
        {            if (!string.IsNullOrEmpty(existingCertification.ImageUrl))
            {
                var oldFileName = Path.GetFileName(new Uri(existingCertification.ImageUrl).LocalPath);
                await _blobStorageService.DeleteFileAsync(oldFileName);
            }

            using var stream = imageFile.OpenReadStream();
            var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(imageFile.FileName)}";
            certification.ImageUrl = await _blobStorageService.UploadFileAsync(newFileName, stream);
        }
        else
        {
            certification.ImageUrl = existingCertification.ImageUrl;
        }

        await _certificationRepository.UpdateAsync(certification);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployeeCertification(int employeeId, int id)
    {
        var certification = await _certificationRepository.GetByIdAsync(id);
        if (certification == null || certification.EmployeeId != employeeId)
        {
            return NotFound();
        }

        if (!string.IsNullOrEmpty(certification.ImageUrl))
        {
            var fileName = Path.GetFileName(new Uri(certification.ImageUrl).LocalPath);
            await _blobStorageService.DeleteFileAsync(fileName);
        }

        await _certificationRepository.DeleteAsync(id);
        return NoContent();
    }
}
