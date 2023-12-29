import { Component } from '@angular/core';
import { HoteldetailsService } from './services/hoteldetails.service';
import { AuthService } from './services/auth.services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'tableReservation';
  public hotel:any;
  constructor(private api:HoteldetailsService,private authService:AuthService){}
   ngOnInit(): void {
     this.gethotel();
     this.gethoteldetail();
 
     const menu: HTMLElement | null = document.querySelector('#menu-icon');
     const navbar: HTMLElement | null = document.querySelector('.navbar');
 
     if (menu && navbar) {
       menu.onclick = () => {
         menu.classList.toggle('bx-x');
         navbar.classList.toggle('open');
       };
     }
    
   }
   private gethotel():void{
     this.api.gethoteldetails().subscribe(result=>{
       this.hotel=result
     })
   }
  
   private gethoteldetail():void{
     this.api.gethoteldetails().subscribe(result=>{
       this.hotel=result
     })
   }
   roles="";
   isLoggedIn!:boolean;
 
   checkLoggedInUser(){
     this.isLoggedIn= this.authService.isLoggedIn();
     this.roles=this.authService.getUserRole();
   }
   logout(){
     this.authService.logout();
   }
   
 
}
