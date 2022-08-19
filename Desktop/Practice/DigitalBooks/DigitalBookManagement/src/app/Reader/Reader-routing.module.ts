import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DisplaybooksComponent } from './displaybooks/displaybooks.component';
import { SearchbooksComponent } from './searchbooks/searchbooks.component';

const routes: Routes = [
  { path: 'search', component: SearchbooksComponent },
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReaderRoutingModule { }
