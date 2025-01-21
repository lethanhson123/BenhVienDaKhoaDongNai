import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CKEditorModule } from 'ngx-ckeditor';
import { ChartsModule } from 'ng2-charts';
import { CookieService } from 'ngx-cookie-service';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MaterialModule } from './material/material.module';
import { GoogleMapsModule } from '@angular/google-maps';
import { NotificationService } from './shared/Notification.service';
import { AppComponent } from './app.component';
import { LoadingComponent } from './loading/loading.component';
import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';
import { DanhMucThanhVienComponent } from './danh-muc-thanh-vien/danh-muc-thanh-vien.component';
import { DanhMucUngDungComponent } from './danh-muc-ung-dung/danh-muc-ung-dung.component';
import { DanhMucChucNangComponent } from './danh-muc-chuc-nang/danh-muc-chuc-nang.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';
import { ThanhVienThongTinComponent } from './thanh-vien-thong-tin/thanh-vien-thong-tin.component';
import { ThanhVienInfoComponent } from './thanh-vien-info/thanh-vien-info.component';

import { DanhMucTinhThanhComponent } from './danh-muc-tinh-thanh/danh-muc-tinh-thanh.component';
import { DanhMucQuanHuyenComponent } from './danh-muc-quan-huyen/danh-muc-quan-huyen.component';
import { DanhMucXaPhuongComponent } from './danh-muc-xa-phuong/danh-muc-xa-phuong.component';
import { DanhMucTinhThanhToaDoComponent } from './danh-muc-tinh-thanh-toa-do/danh-muc-tinh-thanh-toa-do.component';
import { DanhMucKhoaChuyenMonComponent } from './danh-muc-khoa-chuyen-mon/danh-muc-khoa-chuyen-mon.component';
import { DanhMucDichVuComponent } from './danh-muc-dich-vu/danh-muc-dich-vu.component';
import { DanhMucKhuVucComponent } from './danh-muc-khu-vuc/danh-muc-khu-vuc.component';
import { DanhMucPhongKhamComponent } from './danh-muc-phong-kham/danh-muc-phong-kham.component';
import { DanhMucQuayDichVuComponent } from './danh-muc-quay-dich-vu/danh-muc-quay-dich-vu.component';

import { GioiThieuComponent } from './gioi-thieu/gioi-thieu.component';
import { GoiSoComponent } from './goi-so/goi-so.component';
import { GoiSoInfoComponent } from './goi-so-info/goi-so-info.component';
import { GoiSoChiTietInfoComponent } from './goi-so-chi-tiet-info/goi-so-chi-tiet-info.component';
import { GoiSoChiTietComponent } from './goi-so-chi-tiet/goi-so-chi-tiet.component';
import { ManHinhThongBaoComponent } from './man-hinh-thong-bao/man-hinh-thong-bao.component';
import { ManHinhTapTinDinhKemComponent } from './man-hinh-tap-tin-dinh-kem/man-hinh-tap-tin-dinh-kem.component';
import { GoiSoThamSoComponent } from './goi-so-tham-so/goi-so-tham-so.component';
import { TaiLieuComponent } from './tai-lieu/tai-lieu.component';
import { Dashboard001Component } from './dashboard001/dashboard001.component';
import { UploadComponent } from './upload/upload.component';
import { DanhMucTinhThanhToaDoDetailComponent } from './danh-muc-tinh-thanh-toa-do-detail/danh-muc-tinh-thanh-toa-do-detail.component';
import { KhachHangComponent } from './khach-hang/khach-hang.component';
import { KhachHangInfoComponent } from './khach-hang-info/khach-hang-info.component';
import { ZaloTokenComponent } from './zalo-token/zalo-token.component';
import { ZaloZNSComponent } from './zalo-zns/zalo-zns.component';
import { KhamSucKhoeComponent } from './kham-suc-khoe/kham-suc-khoe.component';
import { KhamSucKhoeInfoComponent } from './kham-suc-khoe-info/kham-suc-khoe-info.component';
import { TrucBanNhatKyComponent } from './truc-ban-nhat-ky/truc-ban-nhat-ky.component';
import { LstDictionaryTypeComponent } from './eHospital_DongNai_A_Dictionary/lst-dictionary-type/lst-dictionary-type.component';
import { LstDictionaryComponent } from './eHospital_DongNai_A_Dictionary/lst-dictionary/lst-dictionary.component';
import { DMDonViHanhChinhComponent } from './eHospital_DongNai_A_Dictionary/dm-don-vi-hanh-chinh/dm-don-vi-hanh-chinh.component';
import { DMBenhVienComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-vien/dm-benh-vien.component';
import { DMBenhNhanComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-nhan/dm-benh-nhan.component';
import { DMDonViHanhChinhTinhThanhComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-tinh-thanh/dmdon-vi-hanh-chinh-tinh-thanh.component';
import { DMDonViHanhChinhQuanHuyenComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-quan-huyen/dmdon-vi-hanh-chinh-quan-huyen.component';
import { DMDonViHanhChinhXaPhuongComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-xa-phuong/dmdon-vi-hanh-chinh-xa-phuong.component';
import { DMBenhNhanInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-nhan-info/dm-benh-nhan-info.component';
import { SysUsersComponent } from './eHospital_DongNai_A_System/sys-users/sys-users.component';
import { SysUsersInfoComponent } from './eHospital_DongNai_A_System/sys-users-info/sys-users-info.component';
import { SysGroupsComponent } from './eHospital_DongNai_A_System/sys-groups/sys-groups.component';
import { SysGroupMenusComponent } from './eHospital_DongNai_A_System/sys-group-menus/sys-group-menus.component';
import { SysMenusComponent } from './eHospital_DongNai_A_System/sys-menus/sys-menus.component';
import { SysReportsComponent } from './eHospital_DongNai_A_System/sys-reports/sys-reports.component';
import { SysParametersComponent } from './eHospital_DongNai_A_System/sys-parameters/sys-parameters.component';
import { SysReportsInfoComponent } from './eHospital_DongNai_A_System/sys-reports-info/sys-reports-info.component';
import { DanhMucMauSacComponent } from './danh-muc-mau-sac/danh-muc-mau-sac.component';




@NgModule({
  declarations: [
    AppComponent,
    LoadingComponent,
    HomepageComponent,
    LoginComponent,
    DanhMucThanhVienComponent,
    DanhMucUngDungComponent,
    DanhMucChucNangComponent,
    ThanhVienComponent,
    ThanhVienThongTinComponent,    
    ThanhVienInfoComponent,   
   
    DanhMucTinhThanhComponent,
    DanhMucQuanHuyenComponent,
    DanhMucXaPhuongComponent,
    DanhMucTinhThanhToaDoComponent,
    DanhMucKhoaChuyenMonComponent,
    DanhMucDichVuComponent,
    DanhMucKhuVucComponent,
    DanhMucPhongKhamComponent,
    DanhMucQuayDichVuComponent,
    
    GioiThieuComponent,
    GoiSoComponent,
    GoiSoInfoComponent,
    GoiSoChiTietInfoComponent,
    GoiSoChiTietComponent,
    ManHinhThongBaoComponent,
    ManHinhTapTinDinhKemComponent,
    GoiSoThamSoComponent,
    TaiLieuComponent,
    Dashboard001Component,
    UploadComponent,
    DanhMucTinhThanhToaDoDetailComponent,
    KhachHangComponent,
    KhachHangInfoComponent,
    ZaloTokenComponent,
    ZaloZNSComponent,
    KhamSucKhoeComponent,
    KhamSucKhoeInfoComponent,
    TrucBanNhatKyComponent,
    LstDictionaryTypeComponent,
    LstDictionaryComponent,
    DMDonViHanhChinhComponent,
    DMBenhVienComponent,
    DMBenhNhanComponent,
    DMDonViHanhChinhTinhThanhComponent,
    DMDonViHanhChinhQuanHuyenComponent,
    DMDonViHanhChinhXaPhuongComponent,
    DMBenhNhanInfoComponent,
    SysUsersComponent,
    SysUsersInfoComponent,
    SysGroupsComponent,
    SysGroupMenusComponent,
    SysMenusComponent,
    SysReportsComponent,
    SysParametersComponent,
    SysReportsInfoComponent,
    DanhMucMauSacComponent,
    
    
    

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    GoogleMapsModule,
    ChartsModule,
    CKEditorModule,
  ],
  providers: [
    CookieService,
    NotificationService,
    { provide: MAT_DATE_LOCALE, useValue: 'en-GB' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
