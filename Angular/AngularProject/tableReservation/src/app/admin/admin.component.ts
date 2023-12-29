import { Component } from '@angular/core';
import { Status } from '../models/status';
import { ProtectedService } from '../services/protected.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent {
  status!:Status;
  constructor(private protectedService:ProtectedService) { }

  ngOnInit(): void {
    this.protectedService.getAdminData().subscribe({
      next: (res)=>{
       this.status=res;
      },
      error: (err)=>{
        console.log(err);      }
    })
  }
}
