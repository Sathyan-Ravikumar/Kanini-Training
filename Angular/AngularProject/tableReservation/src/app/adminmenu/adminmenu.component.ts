import { Component } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { HoteldetailsService } from '../services/hoteldetails.service';

@Component({
  selector: 'app-adminmenu',
  templateUrl: './adminmenu.component.html',
  styleUrls: ['./adminmenu.component.css']
})
export class AdminmenuComponent {
  public product: any
  public AddForm!: FormGroup;
  

  constructor(private formBuilder: FormBuilder,private api: HoteldetailsService) { }
  ngOnInit(): void {

    this.getallmenu()
    this.init();
  }




  private init(): void {
    this.AddForm = this.formBuilder.group({
      categoryid:[],
      dishname: [],
      cost: [],
      images: [],
     
    });
  }

  productid!:any

  LocationList: any = {
    productid:'',
    categoryid:'',
      dishname: '',
      cost: '',
      images: ''
  };

  public Updatemenu() {
    console.log(this.LocationList);
    return this.api.updatemenus(this.LocationList.productid, this.LocationList)
      .subscribe((result) => {
        alert(' Data Updated ');
      });
  }

 public deletemenu(): void {
    console.log('hi');
    this.api.deletemenubyid(this.productid).subscribe((res) => {
      alert('Deleted');
    });
  }
  public Addmenu(): void {
    console.log("Added")
    console.log(this.AddForm)
    this.api.Addnewmenu(this.AddForm.value).subscribe((result) => {
      alert(' Data Added ');
    });
  }
  private getallmenu(): void {
    this.api.getallproducts().subscribe(result => {
      this.product = result
      
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
