import { Component } from '@angular/core';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-dinner',
  templateUrl: './dinner.component.html',
  styleUrls: ['./dinner.component.css']
})
export class DinnerComponent {
  public menudinner:any;
  ngOnInit(): void {
    this.getmenu();
  }
  
  constructor(private api:HoteldetailsService){}

  private getmenu():void{
    this.api.getmenudinner().subscribe(result=>{
      this.menudinner=result
    })
  }

}
