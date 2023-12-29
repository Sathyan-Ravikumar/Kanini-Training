import { Component } from '@angular/core';
import { FormGroup, FormControl, NgForm } from '@angular/forms';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent {
  loans: loans = new loans;

  loan_result: string = "";

  repayment_result: string = "";

  onInit(){
    this.loans = {
      price: 0,
      downpayment: 0,
      repaymenttime: 0,
      interestrate: 0
    }
  }

  onSubmit(loans:NgForm){
    
    
    this.loan_result = `Total Loan amount: ${this.loans.price - this.loans.downpayment}`;
    
    
    this.repayment_result = `Each month : ${(this.loans.price + this.loans.interestrate / this.loans.repaymenttime)}`;

  }
  
}

export class loans {
  price = 0;
  downpayment = 0;
  repaymenttime = 0;
  interestrate = 0;
}