import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SearchbooksComponent } from '../Reader/searchbooks/searchbooks.component';
import { MainpageComponent } from './mainpage/mainpage.component';

const routes: Routes = [
  {
    path: '',
    component: MainpageComponent,
    children: [
      { path: 'search',loadChildren: () => import('../Reader/Reader.module').then(m => m.ReaderModule) },
    ]
  }, 
];

@NgModule({  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
