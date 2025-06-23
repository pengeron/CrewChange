import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.html',
  styleUrls: ['./sidebar.scss'],
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    MatListModule,
    MatIconModule
  ]
})
export class SidebarComponent {
  menuItems = [
    { label: 'Employees', icon: 'people', route: '/employees' },
    { label: 'Certifications', icon: 'card_membership', route: '/certifications' }
  ];
}
