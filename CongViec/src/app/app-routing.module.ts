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



const routes: Routes = [
  { path: '', redirectTo: '/Login', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },
  {
    path: 'Login', component: LoginComponent,
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
    path: 'ThanhVien', component: ThanhVienComponent,
  },   

  {
    path: 'CongViec', component: CongViecComponent,
  },   

];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































