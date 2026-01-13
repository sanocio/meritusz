import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Api } from '../../services/api';
import { ContactInfo } from '../../models/models';

@Component({
  selector: 'app-contact',
  imports: [CommonModule],
  templateUrl: './contact.html',
  styleUrl: './contact.css',
})
export class Contact implements OnInit {
  contactInfo?: ContactInfo;

  constructor(private api: Api) {}

  ngOnInit() {
    this.api.getContactInfo().subscribe({
      next: (data) => this.contactInfo = data,
      error: (err) => console.error('Error loading contact info:', err)
    });
  }
}
