import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { TiepNhanComponent } from './tiep-nhan/tiep-nhan.component';



const routes: Routes = [
  { path: '', redirectTo: '/Homepage/2/1', pathMatch: 'full' },  
  {
    path: 'Homepage/:DanhMucDichVuID/:DanhMucQuayDichVuID', component: HomepageComponent,
  }, 
  {
    path: 'TiepNhan/:DanhMucDichVuID/:DanhMucQuayDichVuID', component: TiepNhanComponent,
  }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































