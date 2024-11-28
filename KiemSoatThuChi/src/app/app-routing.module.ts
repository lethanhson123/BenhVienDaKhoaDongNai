import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';
import { DanhMucThanhVienComponent } from './danh-muc-thanh-vien/danh-muc-thanh-vien.component';
import { DanhMucChucNangComponent } from './danh-muc-chuc-nang/danh-muc-chuc-nang.component';
import { DanhMucUngDungComponent } from './danh-muc-ung-dung/danh-muc-ung-dung.component';
import { ThanhVienThongTinComponent } from './thanh-vien-thong-tin/thanh-vien-thong-tin.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';
import { ThanhVienInfoComponent } from './thanh-vien-info/thanh-vien-info.component';
import { DanhMucBenhVienComponent } from './danh-muc-benh-vien/danh-muc-benh-vien.component';
import { DanhMucPhongBanComponent } from './danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucChucDanhComponent } from './danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucBieuMauComponent } from './danh-muc-bieu-mau/danh-muc-bieu-mau.component';
import { DanhMucHinhThucThanhToanComponent } from './danh-muc-hinh-thuc-thanh-toan/danh-muc-hinh-thuc-thanh-toan.component';
import { Dashboard001Component } from './dashboard001/dashboard001.component';
import { DuAnThuChiInfoComponent } from './du-an-thu-chi-info/du-an-thu-chi-info.component';
import { DuAnQuyetDinhInfoComponent } from './du-an-quyet-dinh-info/du-an-quyet-dinh-info.component';
import { DuAnInfoComponent } from './du-an-info/du-an-info.component';
import { DuAnComponent } from './du-an/du-an.component';
import { DanhMucBieuMauInfoComponent } from './danh-muc-bieu-mau-info/danh-muc-bieu-mau-info.component';


const routes: Routes = [
  { path: '', redirectTo: '/Homepage', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },
  {
    path: 'Login', component: LoginComponent,
  },

  {
    path: 'DanhMucThanhVien', component: DanhMucThanhVienComponent,
  }, 
  {
    path: 'DanhMucChucNang', component: DanhMucChucNangComponent,
  },    
  {
    path: 'DanhMucUngDung', component: DanhMucUngDungComponent,
  }, 
  {
    path: 'DanhMucBenhVien', component: DanhMucBenhVienComponent,
  }, 
  {
    path: 'DanhMucPhongBan', component: DanhMucPhongBanComponent,
  },  
  {
    path: 'DanhMucChucDanh', component: DanhMucChucDanhComponent,
  }, 
   
  {
    path: 'DanhMucBieuMau', component: DanhMucBieuMauComponent,
  }, 
  {
    path: 'DanhMucBieuMauInfo/:ID', component: DanhMucBieuMauInfoComponent,
  }, 
  {
    path: 'DanhMucHinhThucThanhToan', component: DanhMucHinhThucThanhToanComponent,
  }, 

  
  {
    path: 'ThanhVien', component: ThanhVienComponent,
  },   
  {
    path: 'ThanhVienInfo/:ID', component: ThanhVienInfoComponent,
  }, 
  {
    path: 'ThanhVienThongTin', component: ThanhVienThongTinComponent,
  },


  {
    path: 'DuAn', component: DuAnComponent,
  },   
  {
    path: 'DuAnInfo/:ID', component: DuAnInfoComponent,
  }, 
  {
    path: 'DuAnQuyetDinhInfo/:DuAnID/:ID', component: DuAnQuyetDinhInfoComponent,
  }, 
  {
    path: 'DuAnThuChiInfo/:DuAnID/:DuAnQuyetDinhID/:ID', component: DuAnThuChiInfoComponent,
  }, 

  {
    path: 'Dashboard001', component: Dashboard001Component,
  },  

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































