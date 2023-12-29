import { Component, OnInit } from '@angular/core';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{
  public hotel:any;
 constructor(private api:HoteldetailsService){}
  ngOnInit(): void {
    this.gethotel();

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

  
}
