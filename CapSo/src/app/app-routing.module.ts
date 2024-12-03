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
import { HienThi0201Component } from './hien-thi0201/hien-thi0201.component';
import { PhongKhamComponent } from './phong-kham/phong-kham.component';
import { PhongKhamIDComponent } from './phong-kham-id/phong-kham-id.component';
import { PhongKhamNameComponent } from './phong-kham-name/phong-kham-name.component';
import { PhongKhamHienThiComponent } from './phong-kham-hien-thi/phong-kham-hien-thi.component';
import { PhongKhamHienThi01Component } from './phong-kham-hien-thi01/phong-kham-hien-thi01.component';
import { PhongKhamGoiSo01Component } from './phong-kham-goi-so01/phong-kham-goi-so01.component';
import { PhongKhamGoiSoComponent } from './phong-kham-goi-so/phong-kham-goi-so.component';
import { CapSoComponent } from './cap-so/cap-so.component';
import { ManHinh01Component } from './man-hinh01/man-hinh01.component';
import { ManHinh04Component } from './man-hinh04/man-hinh04.component';
import { ManHinh03Component } from './man-hinh03/man-hinh03.component';
import { ManHinh02Component } from './man-hinh02/man-hinh02.component';
import { ManHinh05Component } from './man-hinh05/man-hinh05.component';
import { ManHinh0201Component } from './man-hinh0201/man-hinh0201.component';


const routes: Routes = [
  { path: '', redirectTo: '/CapSo', pathMatch: 'full' },
  {
    path: 'CapSo', component: CapSoComponent,
  },


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
    path: 'HienThi0201/:SearchString', component: HienThi0201Component,
  },
  {
    path: 'HienThi03', component: HienThi03Component,
  },
  {
    path: 'HienThi04/:DanhMucQuayDichVuID', component: HienThi04Component,
  },

  {
    path: 'ManHinh01', component: ManHinh01Component,
  },
  {
    path: 'ManHinh02/:SearchString', component: ManHinh02Component,
  },
  {
    path: 'ManHinh0201', component: ManHinh0201Component,
  },
  {
    path: 'ManHinh03', component: ManHinh03Component,
  },
  {
    path: 'ManHinh04/:Code/:Number', component: ManHinh04Component,
  },
  {
    path: 'ManHinh05', component: ManHinh05Component,
  },

  {
    path: 'PhongKham/:DanhMucKhuVucID', component: PhongKhamComponent,
  },
  {
    path: 'PhongKhamID/:SearchString', component: PhongKhamIDComponent,
  },
  {
    path: 'PhongKhamName/:SearchString', component: PhongKhamNameComponent,
  },
  {
    path: 'PhongKhamHienThi/:DanhMucPhongKhamID', component: PhongKhamHienThiComponent,
  },
  {
    path: 'PhongKhamHienThi01/:Name', component: PhongKhamHienThi01Component,
  },
  {
    path: 'PhongKhamGoiSo/:DanhMucPhongKhamID', component: PhongKhamGoiSoComponent,
  },
  {
    path: 'PhongKhamGoiSo01/:Name', component: PhongKhamGoiSo01Component,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































