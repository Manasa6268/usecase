import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchbooksComponent } from './searchbooks/searchbooks.component';
import { DisplaybooksComponent } from './displaybooks/displaybooks.component';



@NgModule({
  declarations: [
    SearchbooksComponent,
    DisplaybooksComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ReaderModule { }
