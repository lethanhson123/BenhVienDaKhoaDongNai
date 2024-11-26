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
import { DanhMucBenhVienComponent } from './danh-muc-benh-vien/danh-muc-benh-vien.component';
import { DanhMucPhongBanComponent } from './danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucChucDanhComponent } from './danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucTinhTrangComponent } from './danh-muc-tinh-trang/danh-muc-tinh-trang.component';
import { DanhMucKhoaChuyenMonComponent } from './danh-muc-khoa-chuyen-mon/danh-muc-khoa-chuyen-mon.component';
import { DanhMucDichVuComponent } from './danh-muc-dich-vu/danh-muc-dich-vu.component';
import { DanhMucKhuVucComponent } from './danh-muc-khu-vuc/danh-muc-khu-vuc.component';
import { DanhMucPhongKhamComponent } from './danh-muc-phong-kham/danh-muc-phong-kham.component';
import { DanhMucQuayDichVuComponent } from './danh-muc-quay-dich-vu/danh-muc-quay-dich-vu.component';
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
    path: 'DanhMucTinhTrang', component: DanhMucTinhTrangComponent,
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
    path: 'DanhMucBieuMau', component: DanhMucBieuMauComponent,
  }, 
  {
    path: 'DanhMucBieuMauInfo/:ID', component: DanhMucBieuMauInfoComponent,
  }, 
  {
    path: 'DanhMucHinhThucThanhToan', component: DanhMucHinhThucThanhToanComponent,
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









































































