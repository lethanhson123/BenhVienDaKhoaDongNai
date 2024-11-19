import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';

import { DanhMucBenhVienComponent } from './danh-muc-benh-vien/danh-muc-benh-vien.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';
import { DanhMucChucNangComponent } from './danh-muc-chuc-nang/danh-muc-chuc-nang.component';
import { DanhMucChucDanhComponent } from './danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucPhongBanComponent } from './danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucThanhVienComponent } from './danh-muc-thanh-vien/danh-muc-thanh-vien.component';
import { CongViecComponent } from './cong-viec/cong-viec.component';
import { DanhMucTinhTrangComponent } from './danh-muc-tinh-trang/danh-muc-tinh-trang.component';
import { GioiThieuComponent } from './gioi-thieu/gioi-thieu.component';
import { CongViec001Component } from './cong-viec001/cong-viec001.component';
import { CongViec002Component } from './cong-viec002/cong-viec002.component';
import { CongViec003Component } from './cong-viec003/cong-viec003.component';
import { DanhMucBieuMauComponent } from './danh-muc-bieu-mau/danh-muc-bieu-mau.component';
import { DanhMucHinhThucThanhToanComponent } from './danh-muc-hinh-thuc-thanh-toan/danh-muc-hinh-thuc-thanh-toan.component';
import { ToChucComponent } from './to-chuc/to-chuc.component';
import { DuAnComponent } from './du-an/du-an.component';
import { DuAn001Component } from './du-an001/du-an001.component';
import { DuAnInfoComponent } from './du-an-info/du-an-info.component';
import { DuAnThuChiInfoComponent } from './du-an-thu-chi-info/du-an-thu-chi-info.component';
import { DuAnQuyetDinhInfoComponent } from './du-an-quyet-dinh-info/du-an-quyet-dinh-info.component';
import { Dashboard001Component } from './dashboard001/dashboard001.component';
import { ThanhVienThongTinComponent } from './thanh-vien-thong-tin/thanh-vien-thong-tin.component';
import { DanhMucUngDungComponent } from './danh-muc-ung-dung/danh-muc-ung-dung.component';



const routes: Routes = [
  { path: '', redirectTo: '/Login', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },
  {
    path: 'Login', component: LoginComponent,
  },  
  {
    path: 'GioiThieu', component: GioiThieuComponent,
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
    path: 'DanhMucChucNang', component: DanhMucChucNangComponent,
  },  
  {
    path: 'DanhMucThanhVien', component: DanhMucThanhVienComponent,
  }, 
  {
    path: 'DanhMucTinhTrang', component: DanhMucTinhTrangComponent,
  }, 
  {
    path: 'DanhMucBieuMau', component: DanhMucBieuMauComponent,
  }, 
  {
    path: 'DanhMucHinhThucThanhToan', component: DanhMucHinhThucThanhToanComponent,
  }, 
  {
    path: 'DanhMucUngDung', component: DanhMucUngDungComponent,
  }, 

  
  {
    path: 'ThanhVien', component: ThanhVienComponent,
  },   
  {
    path: 'ThanhVienThongTin', component: ThanhVienThongTinComponent,
  },

  {
    path: 'CongViec', component: CongViecComponent,
  },  
  {
    path: 'CongViec001', component: CongViec001Component,
  },  
  {
    path: 'CongViec002', component: CongViec002Component,
  },
  {
    path: 'CongViec003', component: CongViec003Component,
  },

  {
    path: 'ToChuc', component: ToChucComponent,
  },  

  {
    path: 'DuAn', component: DuAnComponent,
  },  
  {
    path: 'DuAn001', component: DuAn001Component,
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









































































