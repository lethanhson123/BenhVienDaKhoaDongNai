import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { GComponent } from './g/g.component';
import { CComponent } from './c/c.component';
import { TiepNhanSComponent } from './tiep-nhan-s/tiep-nhan-s.component';
import { TiepNhanFullComponent } from './tiep-nhan-full/tiep-nhan-full.component';
import { TiepNhanComponent } from './tiep-nhan/tiep-nhan.component';
import { HienThi04Component } from './hien-thi04/hien-thi04.component';
import { HienThi02Component } from './hien-thi02/hien-thi02.component';
import { HienThi01Component } from './hien-thi01/hien-thi01.component';
import { HienThiComponent } from './hien-thi/hien-thi.component';
import { HienThi03Component } from './hien-thi03/hien-thi03.component';


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

  {
    path: 'HienThi', component: HienThiComponent,
  },
  {
    path: 'HienThi01', component: HienThi01Component,
  },
  {
    path: 'HienThi02/:SearchString', component: HienThi02Component,
  },
  {
    path: 'HienThi03', component: HienThi03Component,
  },
  {
    path: 'HienThi04/:DanhMucQuayDichVuID', component: HienThi04Component,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































