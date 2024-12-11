import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';




const routes: Routes = [
  { path: '', redirectTo: '/Homepage/1/1', pathMatch: 'full' },  
  {
    path: 'Homepage/:DanhMucDichVuCode/:DanhMucQuayDichVuCode', component: HomepageComponent,
  }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































