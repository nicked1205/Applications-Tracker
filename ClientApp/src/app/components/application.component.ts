import { Component, OnInit } from '@angular/core';
import { ApplicationService } from '../services/application.service';

@Component({
  selector: 'app-job-application',
  templateUrl: './job-application.component.html',
  styleUrls: ['./job-application.component.scss']
})
export class JobApplicationComponent implements OnInit {
  jobApplications: any[] = [];

  constructor(private jobService: ApplicationService) {}

  ngOnInit(): void {
    this.jobService.getJobApplications().subscribe((data) => {
      this.jobApplications = data;
    });
  }
}
