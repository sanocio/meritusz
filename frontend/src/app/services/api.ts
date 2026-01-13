import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Service, InsuranceProduct, ContactInfo, AboutUs } from '../models/models';

@Injectable({
  providedIn: 'root',
})
export class Api {
  private apiUrl = 'http://localhost:5029/api';

  constructor(private http: HttpClient) {}

  // Services
  getServices(): Observable<Service[]> {
    return this.http.get<Service[]>(`${this.apiUrl}/services`);
  }

  getService(id: number): Observable<Service> {
    return this.http.get<Service>(`${this.apiUrl}/services/${id}`);
  }

  // Insurance Products
  getInsuranceProducts(): Observable<InsuranceProduct[]> {
    return this.http.get<InsuranceProduct[]>(`${this.apiUrl}/insuranceproducts`);
  }

  getInsuranceProduct(id: number): Observable<InsuranceProduct> {
    return this.http.get<InsuranceProduct>(`${this.apiUrl}/insuranceproducts/${id}`);
  }

  getInsuranceProductsByCategory(category: string): Observable<InsuranceProduct[]> {
    return this.http.get<InsuranceProduct[]>(`${this.apiUrl}/insuranceproducts/category/${category}`);
  }

  // Contact Info
  getContactInfo(): Observable<ContactInfo> {
    return this.http.get<ContactInfo>(`${this.apiUrl}/contact`);
  }

  // About Us
  getAboutUs(): Observable<AboutUs> {
    return this.http.get<AboutUs>(`${this.apiUrl}/aboutus`);
  }
}

