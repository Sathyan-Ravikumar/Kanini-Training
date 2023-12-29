import { Component } from '@angular/core';
import { gte } from './gte.validator';
import { FormControl, FormGroup } from '@angular/forms';
import { nmchk } from './nmchk.validator';

@Component({
  selector: 'app-custvalid',
  templateUrl: './custvalid.component.html',
  styleUrls: ['./custvalid.component.css']
})
export class CustvalidComponent {
  myForm = new FormGroup({
    numVal : new FormControl('', [gte]),
    nameVal : new FormControl('', [nmchk]),
  })
 
  get numVal() {
    return this.myForm?.get('numVal');
  }
  get nameVal() {
    return this.myForm?.get('nameVal');
  }
 
  onSubmit() {
    console.log(this.myForm.value);
  }
}