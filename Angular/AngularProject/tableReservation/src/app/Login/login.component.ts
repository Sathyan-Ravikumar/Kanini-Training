import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Status } from '../models/status';
import { AuthService } from '../services/auth.services';
import { SignupService } from '../services/signup-service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  frm!:FormGroup;
  status!:Status;
  
    get f(){
    return this.frm.controls;  // needed for validation in html file 
  }



  constructor(private signupService:SignupService, private fb:FormBuilder,
    private authService:AuthService, private router:Router
    ) { }

   onPost(){
    this.status = {statusCode:0,message:"wait...."};

    
    this.signupService.login(this.frm.value).subscribe({
      next: (res)=>{
        // save username, accesstoken and refresh token into localStorage
        this.authService.addAccessToken(res.token);
        this.authService.addRefreshToken(res.refreshToken);
        this.authService.addUsername(res.username);
        this.status.statusCode=res.statusCode;
        this.status.message=res.message;
        if(res.statusCode==1){
        this.router.navigate(['/menu']);
        }

      },
      error: (err)=>{
        console.log(err);
        this.status.statusCode=0;
        this.status.message="some error on server side";
      }
    })
     
 
  }

  ngOnInit(): void {
    this.frm= this.fb.group({
      'username':['',Validators.required],
      'password':['',Validators.required]
    })
    if(this.authService.isLoggedIn()){
      this.router.navigate(['/menu']);
    }
  }
}
