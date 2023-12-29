import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ValidateUrl } from './url.validator';

@Component({
  selector: 'app-reactiveforms',
  templateUrl: './reactiveforms.component.html',
  styleUrls: ['./reactiveforms.component.css']
})
export class ReactiveformsComponent implements OnInit 
{
 
  contactForm = new FormGroup
  ({
    firstname: new FormControl('',[Validators.required,Validators.minLength(5),Validators.pattern("^[a-zA-Z]+$")]),
    // firstname: new FormControl("Rahul"),
    // firstname: new FormControl({ value: "Rahul", disabled: true} ),
    lastname: new FormControl('',[Validators.required,Validators.minLength(5),Validators.pattern("^[a-zA-Z]+$")]),
    email: new FormControl('',[Validators.email,Validators.required]),
    gender: new FormControl(),
    isMarried: new FormControl(),
    country: new FormControl()
  })
 get firstname(){
  return this.contactForm.get('firstname');
 }
 
  onSubmit() {
    console.log(this.contactForm.value);
  }
validateForm!:FormGroup;
constructor(private fb:FormBuilder){}
ngOnInit() {
  this.validateForm=this.fb.group({
    Pagename :['',Validators.required],
    myURL : ['',[Validators.required, ValidateUrl]]
  });
}
saveForm(form:FormGroup){
  console.log('valid',form.valid),
  console.log('Pagename',form.value.Pagename),
  console.log('URL',form.value.myURL);

}
}
