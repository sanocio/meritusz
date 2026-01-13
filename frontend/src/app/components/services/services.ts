import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Api } from '../../services/api';
import { Service } from '../../models/models';

@Component({
  selector: 'app-services',
  imports: [CommonModule],
  templateUrl: './services.html',
  styleUrl: './services.css',
})
export class Services implements OnInit {
  services: Service[] = [];

  constructor(private api: Api) {}

  ngOnInit() {
    this.api.getServices().subscribe({
      next: (data) => this.services = data,
      error: (err) => console.error('Error loading services:', err)
    });
  }
}
