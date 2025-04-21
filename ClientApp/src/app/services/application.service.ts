import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

interface Application {
  id: number;
  companyName: string;
  position: string;
  status: string;
  applicationDate: string;
}

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {
  private apiUrl = 'http://localhost:5000/api/jobapplication';  // Change this to your API endpoint

  constructor(private http: HttpClient) {}

  getJobApplications(): Observable<Application[]> {
    return this.http.get<Application[]>(this.apiUrl);
  }

  addJobApplication(jobApplication: Application): Observable<Application> {
    return this.http.post<Application>(this.apiUrl, jobApplication);
  }
}
