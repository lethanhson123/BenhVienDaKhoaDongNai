import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { GComponent } from './g/g.component';
import { CComponent } from './c/c.component';
import { TiepNhanSComponent } from './tiep-nhan-s/tiep-nhan-s.component';
import { TiepNhanFullComponent } from './tiep-nhan-full/tiep-nhan-full.component';
import { TiepNhanComponent } from './tiep-nhan/tiep-nhan.component';


const routes: Routes = [
  { path: '', redirectTo: '/Homepage', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },
  {
    path: 'G', component: GComponent,
  },
  {
    path: 'C', component: CComponent,
  },

  {
    path: 'TiepNhan/:DanhMucDichVuID/:DanhMucQuayDichVuID', component: TiepNhanComponent,
  },
  {
    path: 'TiepNhanS', component: TiepNhanSComponent,
  },
  {
    path: 'TiepNhanFull', component: TiepNhanFullComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































