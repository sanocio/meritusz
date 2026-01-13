import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { Api } from '../../services/api';
import { Service } from '../../models/models';

@Component({
  selector: 'app-home',
  imports: [CommonModule, RouterLink],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit {
  services: Service[] = [];

  constructor(private api: Api) {}

  ngOnInit() {
    this.api.getServices().subscribe({
      next: (data) => this.services = data,
      error: (err) => console.error('Error loading services:', err)
    });
  }
}
