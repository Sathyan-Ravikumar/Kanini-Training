import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { BookatableComponent } from './bookatable/bookatable.component';

import { LoginComponent } from './Login/login.component';
import { MenuComponent } from './menu/menu.component';
import { StarterComponent } from './starter/starter.component';
import { LunchComponent } from './lunch/lunch.component';
import { DinnerComponent } from './dinner/dinner.component';
import { SignupComponent } from './signup/signup.component';
import { AdminComponent } from './admin/admin.component';
import { AdminuiComponent } from './adminui/adminui.component';
import { AdminmenuComponent } from './adminmenu/adminmenu.component';

const routes: Routes = [
  // {path:'header',component:HeaderComponent},
  // {path:'footer',component:FooterComponent},
  {path:'bookatable',component:BookatableComponent},
  // {path:'login',component:LoginComponent},
  {path:'menu',component:MenuComponent},
  {path:'lunch',component:LunchComponent},
  {path:'dinner',component:DinnerComponent},
  {path:'menu/starter',component:StarterComponent},
  {path:'menu/lunch',component:LunchComponent},
  {path:'menu/dinner',component:DinnerComponent},
  {path:'',component:SignupComponent},
  {path:'login',component:LoginComponent},
  {path:'admin',component:AdminuiComponent},
  {path:'adminmenu',component:AdminmenuComponent},
  {path:'admin/adminmenu',component:AdminmenuComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
