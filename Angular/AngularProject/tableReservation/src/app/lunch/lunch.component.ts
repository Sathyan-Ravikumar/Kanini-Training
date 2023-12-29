import { Component } from '@angular/core';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-lunch',
  templateUrl: './lunch.component.html',
  styleUrls: ['./lunch.component.css']
})
export class LunchComponent {
  public menulunch:any;
  ngOnInit(): void {
    this.getmenu();
  }
  
  constructor(private api:HoteldetailsService){}

  private getmenu():void{
    this.api.getmenuLunch().subscribe(result=>{
      this.menulunch=result
    })
  }
}
