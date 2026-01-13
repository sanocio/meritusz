export interface Service {
  id: number;
  title: string;
  description: string;
  iconClass?: string;
  displayOrder: number;
}

export interface InsuranceProduct {
  id: number;
  name: string;
  description: string;
  category: string;
  features?: string;
}

export interface ContactInfo {
  id: number;
  companyName: string;
  address: string;
  phone: string;
  email: string;
  website?: string;
}

export interface AboutUs {
  id: number;
  title: string;
  content: string;
  mission?: string;
  history?: string;
}
