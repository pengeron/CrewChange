import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { HeaderComponent, SidebarComponent } from '../shared/shared-module';

@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.html',
  styleUrls: ['./admin-layout.scss'],
  standalone: true,
  imports: [
    RouterOutlet,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatSidenavModule,
    HeaderComponent,
    SidebarComponent
  ]
})
export class AdminLayoutComponent {
  sidenavOpened = true;

  toggleSidenav() {
    this.sidenavOpened = !this.sidenavOpened;
  }
}
