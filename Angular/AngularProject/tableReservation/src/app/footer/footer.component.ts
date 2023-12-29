import { Component, OnInit } from '@angular/core';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  public hotel:any;
  ngOnInit(): void {
    this.gethoteldetail();
  }
  
  constructor(private api:HoteldetailsService){}

  private gethoteldetail():void{
    this.api.gethoteldetails().subscribe(result=>{
      this.hotel=result
    })
  }
 
}
