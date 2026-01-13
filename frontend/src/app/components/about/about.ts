import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Api } from '../../services/api';
import { AboutUs } from '../../models/models';

@Component({
  selector: 'app-about',
  imports: [CommonModule],
  templateUrl: './about.html',
  styleUrl: './about.css',
})
export class About implements OnInit {
  aboutUs?: AboutUs;

  constructor(private api: Api) {}

  ngOnInit() {
    this.api.getAboutUs().subscribe({
      next: (data) => this.aboutUs = data,
      error: (err) => console.error('Error loading about us:', err)
    });
  }
}
