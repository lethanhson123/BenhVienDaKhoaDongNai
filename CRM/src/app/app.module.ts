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
import { SysModulesComponent } from './eHospital_DongNai_A_System/sys-modules/sys-modules.component';
import { SysFunctionsComponent } from './eHospital_DongNai_A_System/sys-functions/sys-functions.component';
import { SysCommandsComponent } from './eHospital_DongNai_A_System/sys-commands/sys-commands.component';
import { SysGroupCommandsComponent } from './eHospital_DongNai_A_System/sys-group-commands/sys-group-commands.component';
import { SysUserCommandsComponent } from './eHospital_DongNai_A_System/sys-user-commands/sys-user-commands.component';
import { DMDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-dich-vu/dm-dich-vu.component';
import { DMICDComponent } from './eHospital_DongNai_A_Dictionary/dm-icd/dm-icd.component';
import { DMKhoDuocComponent } from './eHospital_DongNai_A_Dictionary/dm-kho-duoc/dm-kho-duoc.component';
import { DMPhongBanComponent } from './eHospital_DongNai_A_Dictionary/dm-phong-ban/dm-phong-ban.component';
import { DMNhomDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-nhom-dich-vu/dm-nhom-dich-vu.component';
import { DMDonViTinhComponent } from './eHospital_DongNai_A_Dictionary/dm-don-vi-tinh/dm-don-vi-tinh.component';
import { DMICDChuongComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-chuong/dm-icd-chuong.component';
import { DMICDCommonComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-common/dm-icd-common.component';
import { DMICDNhomComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-nhom/dm-icd-nhom.component';
import { DMLoaiDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-loai-dich-vu/dm-loai-dich-vu.component';
import { DMLoaiGiaComponent } from './eHospital_DongNai_A_Dictionary/dm-loai-gia/dm-loai-gia.component';
import { DMBangGiaComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia/dm-bang-gia.component';
import { DMBangGiaInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-info/dm-bang-gia-info.component';
import { DMDichVuInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-dich-vu-info/dm-dich-vu-info.component';
import { DMBangGiaCPHComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-cph/dm-bang-gia-cph.component';
import { DMBangGiaCPHInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-cphinfo/dm-bang-gia-cphinfo.component';
import { BenhAnComponent } from './eHospital_DongNai_A/benh-an/benh-an.component';
import { BenhAnInfoComponent } from './eHospital_DongNai_A/benh-an-info/benh-an-info.component';
import { DMLoaiBenhAnComponent } from './eHospital_DongNai_A_Dictionary/dm-loai-benh-an/dm-loai-benh-an.component';




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
    SysModulesComponent,
    SysFunctionsComponent,
    SysCommandsComponent,
    SysGroupCommandsComponent,
    SysUserCommandsComponent,
    DMDichVuComponent,
    DMICDComponent,
    DMKhoDuocComponent,
    DMPhongBanComponent,
    DMNhomDichVuComponent,
    DMDonViTinhComponent,
    DMICDChuongComponent,
    DMICDCommonComponent,
    DMICDNhomComponent,
    DMLoaiDichVuComponent,
    DMLoaiGiaComponent,
    DMBangGiaComponent,
    DMBangGiaInfoComponent,
    DMDichVuInfoComponent,
    DMBangGiaCPHComponent,
    DMBangGiaCPHInfoComponent,
    BenhAnComponent,
    BenhAnInfoComponent,
    DMLoaiBenhAnComponent,
    
    
    

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
