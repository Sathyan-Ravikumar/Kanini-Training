import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-adminui',
  templateUrl: './adminui.component.html',
  styleUrls: ['./adminui.component.css']
})
export class AdminuiComponent {
  public products: any
  public AddForm!: FormGroup;
  

  constructor(private formBuilder: FormBuilder,private api: HoteldetailsService) { }
  ngOnInit(): void {

    this.getall()
    this.init();
  }




  private init(): void {
    this.AddForm = this.formBuilder.group({
      hotelName: [],
      address: [],
      hotelnumber: [],
      instalink: [],
      facebook:[],
      youtube:[]
    });
  }

  hotelid!:any

  LocationList: any = {
    hotelid:0,
    hotelName: '',
    address: '',
    hotelnumber: '',
    instalink: '',
    facebook:'',
    youtube:''
  };

  public UpdateProductById() {
    console.log(this.LocationList);
    return this.api.updatedetails(this.LocationList.hotelid, this.LocationList)
      .subscribe((result) => {
        alert(' Data Updated ');
      });
  }

 public deleteProduct(): void {
    console.log('hi');
    this.api.deleteById(this.hotelid).subscribe((res) => {
      alert('Deleted');
    });
  }
  public AddNews(): void {
    console.log("Added")
    console.log(this.AddForm)
    this.api.AddNew(this.AddForm.value).subscribe((result) => {
      alert(' Data Added ');
    });
  }
  private getall(): void {
    this.api.getall().subscribe(result => {
      this.products = result
      
    });
   
  }
  openPopup() {
    let popup = document.getElementById('popup');
    popup?.classList.add('open');
  }
  closePopup() {
    let popup = document.getElementById('popup');
    popup?.classList.remove('open');
  }

  openPopup1() {
    let popup = document.getElementById('popup1');
    popup?.classList.add('open');
  }
  closePopup1() {
    let popup = document.getElementById('popup1');
    popup?.classList.remove('open');
  }
  openPopup2() {
    let popup = document.getElementById('popup2');
    popup?.classList.add('open');
  }
  closePopup2() {
    let popup = document.getElementById('popup2');
    popup?.classList.remove('open');
  }
}
