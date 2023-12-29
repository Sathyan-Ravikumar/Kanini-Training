import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-bookatable',
  templateUrl: './bookatable.component.html',
  styleUrls: ['./bookatable.component.css']
})
export class BookatableComponent {
  bookingForm: FormGroup;


  public addgrp!:FormGroup
  private init():void{
    this.addgrp=this.formBuilder.group({
      customerName:[],
      mobileNumber:[],
      numberOfPeople:[],
      slot:[],
      reservedate:[]
    })
  }


  constructor(private formBuilder: FormBuilder) {
    this.bookingForm = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      people: ['', Validators.required],
      slot: ['', Validators.required],
      date: ['', Validators.required],
      number: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.bookingForm.valid) {
     
    alert("Table Reserved");
  
    } else {
      // Mark all fields as touched to display validation errors
      this.bookingForm.markAllAsTouched();
    }
  }

  
}
