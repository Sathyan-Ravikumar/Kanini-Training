import { Component } from '@angular/core';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-starter',
  templateUrl: './starter.component.html',
  styleUrls: ['./starter.component.css']
})
export class StarterComponent {
  public menu:any;
  ngOnInit(): void {
    this.getmenu();
  }
  
  constructor(private api:HoteldetailsService){}

  private getmenu():void{
    this.api.getmenustarter().subscribe(result=>{
      this.menu=result
    })
  }
}
