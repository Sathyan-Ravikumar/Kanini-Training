import { Routes } from "@angular/router";
import { PaymentComponent } from "./payment/payment.component";
import { TemperaturechangeComponent } from "./temperaturechange/temperaturechange.component";
import { UrlComponent } from "./url/url.component";

export const appRoutes: Routes = [
    { path: 'question1', component: TemperaturechangeComponent },
    { path: 'question2', component: UrlComponent },
    { path: 'question3', component: PaymentComponent },
    { path: '', redirectTo: 'home', pathMatch: 'full' },  //default route 
  ];