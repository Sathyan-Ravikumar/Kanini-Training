import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-url',
  templateUrl: './url.component.html',
  styleUrls: ['./url.component.css']
})
export class UrlComponent {
  myForm = new FormGroup({
    url : new FormControl()
  })
final!:any

  shortenUrl()
  {
    const shortenUrl=this.myForm.value.url
    this.final=shortenUrl.split('/', 3).slice(-1)
  }

  copy()
  {
    navigator.clipboard.writeText(this.final);
    alert('Text copied to clipboard')
  }
}
