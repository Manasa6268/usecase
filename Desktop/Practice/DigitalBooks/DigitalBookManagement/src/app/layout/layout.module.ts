import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { LayoutRoutingModule } from './layout-routing.module';
import { MainpageComponent } from './mainpage/mainpage.component';
import { AboutusComponent } from './aboutus/aboutus.component';



@NgModule({
  declarations: [
    FooterComponent,
    HeaderComponent,
    MainpageComponent,
    AboutusComponent
  ],
  imports: [
    CommonModule,
    LayoutRoutingModule
  ]
})
export class LayoutModule { }
