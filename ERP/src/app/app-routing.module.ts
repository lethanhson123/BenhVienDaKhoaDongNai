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
import { DanhMucTinhThanhToaDoComponent } from './danh-muc-tinh-thanh-toa-do/danh-muc-tinh-thanh-toa-do.component';
import { DanhMucXaPhuongComponent } from './danh-muc-xa-phuong/danh-muc-xa-phuong.component';
import { DanhMucQuanHuyenComponent } from './danh-muc-quan-huyen/danh-muc-quan-huyen.component';
import { DanhMucTinhThanhComponent } from './danh-muc-tinh-thanh/danh-muc-tinh-thanh.component';

import { DanhMucKhoaChuyenMonComponent } from './danh-muc-khoa-chuyen-mon/danh-muc-khoa-chuyen-mon.component';
import { DanhMucDichVuComponent } from './danh-muc-dich-vu/danh-muc-dich-vu.component';
import { DanhMucKhuVucComponent } from './danh-muc-khu-vuc/danh-muc-khu-vuc.component';
import { DanhMucPhongKhamComponent } from './danh-muc-phong-kham/danh-muc-phong-kham.component';
import { DanhMucQuayDichVuComponent } from './danh-muc-quay-dich-vu/danh-muc-quay-dich-vu.component';
import { GoiSoComponent } from './goi-so/goi-so.component';
import { GoiSoInfoComponent } from './goi-so-info/goi-so-info.component';
import { ManHinhThongBaoComponent } from './man-hinh-thong-bao/man-hinh-thong-bao.component';
import { ManHinhTapTinDinhKemComponent } from './man-hinh-tap-tin-dinh-kem/man-hinh-tap-tin-dinh-kem.component';



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
    path: 'DanhMucTinhThanh', component: DanhMucTinhThanhComponent,
  }, 
  {
    path: 'DanhMucQuanHuyen', component: DanhMucQuanHuyenComponent,
  }, 
  {
    path: 'DanhMucXaPhuong', component: DanhMucXaPhuongComponent,
  },
  {
    path: 'DanhMucTinhThanhToaDo', component: DanhMucTinhThanhToaDoComponent,
  }, 
  

  {
    path: 'DanhMucKhoaChuyenMon', component: DanhMucKhoaChuyenMonComponent,
  }, 
  {
    path: 'DanhMucDichVu', component: DanhMucDichVuComponent,
  }, 
  {
    path: 'DanhMucKhuVuc', component: DanhMucKhuVucComponent,
  }, 
  {
    path: 'DanhMucPhongKham', component: DanhMucPhongKhamComponent,
  }, 
  {
    path: 'DanhMucQuayDichVu', component: DanhMucQuayDichVuComponent,
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
    path: 'GoiSo', component: GoiSoComponent,
  },
  {
    path: 'GoiSoInfo/:ID', component: GoiSoInfoComponent,
  }, 

  {
    path: 'ManHinhTapTinDinhKem', component: ManHinhTapTinDinhKemComponent,
  },
  {
    path: 'ManHinhThongBao', component: ManHinhThongBaoComponent,
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































