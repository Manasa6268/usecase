import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SearchbooksComponent } from './searchbooks.component';


const routes: Routes = [
  {path:'./search',component:SearchbooksComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }