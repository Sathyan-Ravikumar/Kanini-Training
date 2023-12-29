import { Component } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { number } from '../number.validator';
@Component({
  selector: 'app-temperaturechange',
  templateUrl: './temperaturechange.component.html',
  styleUrls: ['./temperaturechange.component.css']
})
export class TemperaturechangeComponent {
  convertedValue: number = 0;
  convertedUnit: string = '';

  myForm = new FormGroup({
    number: new FormControl('', [number]),

    unit: new FormControl(['celsius'])

  })
  get number()
  {
    return this.myForm?.get('number')
  }
  
  constructor(private formBuilder: FormBuilder) { }

  // ngOnInit() {
  //   this.myForm =  this.formBuilder.group({
  //     number : ['', [Validators.required, number]], // Example validation rule: required
  //     unit: ['celsius']

  //   });
  // }



  convertTemperature()
  {
    const numb:any = this.myForm.value.number;
    const units:any = this.myForm.value.unit;

    if (units == 'celsius') {
      this.convertedValue = (numb * 9/5) + 32 // Celsius to Fahrenheit conversion
      this.convertedValue = Math.round(this.convertedValue*100)/100
      this.convertedUnit = 'F';
    } else {
      this.convertedValue = (numb - 32) * 5/9; // Fahrenheit to Celsius conversion
      this.convertedValue = Math.round(this.convertedValue*100)/100
      this.convertedUnit = 'C';
    }
  }

}
