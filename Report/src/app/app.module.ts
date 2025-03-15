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
import { TiepNhanComponent } from './eHospital_DongNai_A/tiep-nhan/tiep-nhan.component';
import { TiepNhanInfoComponent } from './eHospital_DongNai_A/tiep-nhan-info/tiep-nhan-info.component';
import { NSNHANVIENComponent } from './eHospital_DongNai_A_NSTL/ns-nhanvien/ns-nhanvien.component';
import { NSNHANVIENInfoComponent } from './eHospital_DongNai_A_NSTL/ns-nhanvieninfo/ns-nhanvieninfo.component';
import { KhamBenhInfoComponent } from './eHospital_DongNai_A/kham-benh-info/kham-benh-info.component';
import { KhamBenhComponent } from './eHospital_DongNai_A/kham-benh/kham-benh.component';
import { KhamBenhVaoVienComponent } from './eHospital_DongNai_A/kham-benh-vao-vien/kham-benh-vao-vien.component';
import { KhamBenhVaoVienInfoComponent } from './eHospital_DongNai_A/kham-benh-vao-vien-info/kham-benh-vao-vien-info.component';
import { ThanhVien001Component } from './thanh-vien001/thanh-vien001.component';
import { SysUsersInfo001Component } from './eHospital_DongNai_A_System/sys-users-info001/sys-users-info001.component';
import { SysAppSettingsComponent } from './eHospital_DongNai_A_Config/sys-app-settings/sys-app-settings.component';
import { SysAppPrivateSettingsComponent } from './eHospital_DongNai_A_Config/sys-app-private-settings/sys-app-private-settings.component';
import { QuanLyCongViecComponent } from './quan-ly-cong-viec/quan-ly-cong-viec.component';
import { KhamBenhToaThuocComponent } from './eHospital_DongNai_A/kham-benh-toa-thuoc/kham-benh-toa-thuoc.component';
import { KhamBenhToaThuocInfoComponent } from './eHospital_DongNai_A/kham-benh-toa-thuoc-info/kham-benh-toa-thuoc-info.component';
import { ChungTuComponent } from './eHospital_DongNai_A/chung-tu/chung-tu.component';
import { ChungTuInfoComponent } from './eHospital_DongNai_A/chung-tu-info/chung-tu-info.component';
import { XML9CV130Component } from './eHospital_DongNai_A/xml9-cv130/xml9-cv130.component';
import { XML10CV130Component } from './eHospital_DongNai_A/xml10-cv130/xml10-cv130.component';
import { XML11CV130Component } from './eHospital_DongNai_A/xml11-cv130/xml11-cv130.component';
import { XML12CV130Component } from './eHospital_DongNai_A/xml12-cv130/xml12-cv130.component';
import { XML13CV130Component } from './eHospital_DongNai_A/xml13-cv130/xml13-cv130.component';
import { XML14CV130Component } from './eHospital_DongNai_A/xml14-cv130/xml14-cv130.component';
import { XML15CV130Component } from './eHospital_DongNai_A/xml15-cv130/xml15-cv130.component';
import { XML1CV130Component } from './eHospital_DongNai_A/xml1-cv130/xml1-cv130.component';
import { XML2CV130Component } from './eHospital_DongNai_A/xml2-cv130/xml2-cv130.component';
import { XML3CV130Component } from './eHospital_DongNai_A/xml3-cv130/xml3-cv130.component';
import { XML4CV130Component } from './eHospital_DongNai_A/xml4-cv130/xml4-cv130.component';
import { XML5CV130Component } from './eHospital_DongNai_A/xml5-cv130/xml5-cv130.component';
import { XML6CV130Component } from './eHospital_DongNai_A/xml6-cv130/xml6-cv130.component';
import { XML7CV130Component } from './eHospital_DongNai_A/xml7-cv130/xml7-cv130.component';
import { XML8CV130Component } from './eHospital_DongNai_A/xml8-cv130/xml8-cv130.component';
import { XMLCV130Component } from './eHospital_DongNai_A/xml-cv130/xml-cv130.component';
import { SysAppSettingsCheckBHXHComponent } from './eHospital_DongNai_A_Config/sys-app-settings-check-bhxh/sys-app-settings-check-bhxh.component';
import { TiepNhan2025Component } from './eHospital_BenhAnDienTu/tiep-nhan2025/tiep-nhan2025.component';
import { KhamBenhNgoaiTru2025Component } from './eHospital_BenhAnDienTu/kham-benh-ngoai-tru2025/kham-benh-ngoai-tru2025.component';
import { XML1CV130DetailComponent } from './eHospital_DongNai_A/xml1-cv130-detail/xml1-cv130-detail.component';
import { XML10CV130DetailComponent } from './eHospital_DongNai_A/xml10-cv130-detail/xml10-cv130-detail.component';
import { XML11CV130DetailComponent } from './eHospital_DongNai_A/xml11-cv130-detail/xml11-cv130-detail.component';
import { XML12CV130DetailComponent } from './eHospital_DongNai_A/xml12-cv130-detail/xml12-cv130-detail.component';
import { XML13CV130DetailComponent } from './eHospital_DongNai_A/xml13-cv130-detail/xml13-cv130-detail.component';
import { XML14CV130DetailComponent } from './eHospital_DongNai_A/xml14-cv130-detail/xml14-cv130-detail.component';
import { XML15CV130DetailComponent } from './eHospital_DongNai_A/xml15-cv130-detail/xml15-cv130-detail.component';
import { XML2CV130DetailComponent } from './eHospital_DongNai_A/xml2-cv130-detail/xml2-cv130-detail.component';
import { XML3CV130DetailComponent } from './eHospital_DongNai_A/xml3-cv130-detail/xml3-cv130-detail.component';
import { XML4CV130DetailComponent } from './eHospital_DongNai_A/xml4-cv130-detail/xml4-cv130-detail.component';
import { XML5CV130DetailComponent } from './eHospital_DongNai_A/xml5-cv130-detail/xml5-cv130-detail.component';
import { XML6CV130DetailComponent } from './eHospital_DongNai_A/xml6-cv130-detail/xml6-cv130-detail.component';
import { XML7CV130DetailComponent } from './eHospital_DongNai_A/xml7-cv130-detail/xml7-cv130-detail.component';
import { XML8CV130DetailComponent } from './eHospital_DongNai_A/xml8-cv130-detail/xml8-cv130-detail.component';
import { XML9CV130DetailComponent } from './eHospital_DongNai_A/xml9-cv130-detail/xml9-cv130-detail.component';
import { XMLCV130TagComponent } from './eHospital_DongNai_A/xmlcv130-tag/xmlcv130-tag.component';
import { DMDanTocComponent } from './eHospital_DongNai_A_Dictionary/dmdan-toc/dmdan-toc.component';
import { DMQuocGiaComponent } from './eHospital_DongNai_A_Dictionary/dmquoc-gia/dmquoc-gia.component';
import { ReportDictionary0001Component } from './Report/report-dictionary0001/report-dictionary0001.component';
import { ReportA0001Component } from './Report/report-a0001/report-a0001.component';
import { DanhMucBacLuongComponent } from './HR/danh-muc-bac-luong/danh-muc-bac-luong.component';
import { DanhMucBangCapComponent } from './HR/danh-muc-bang-cap/danh-muc-bang-cap.component';
import { DanhMucChucDanhComponent } from './HR/danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucChucVuComponent } from './HR/danh-muc-chuc-vu/danh-muc-chuc-vu.component';
import { DanhMucChuyenNganhComponent } from './HR/danh-muc-chuyen-nganh/danh-muc-chuyen-nganh.component';
import { DanhMucPhuCapComponent } from './HR/danh-muc-phu-cap/danh-muc-phu-cap.component';
import { DanhMucToChucDaoTaoComponent } from './HR/danh-muc-to-chuc-dao-tao/danh-muc-to-chuc-dao-tao.component';
import { DanhMucChamCongComponent } from './HR/danh-muc-cham-cong/danh-muc-cham-cong.component';
import { DanhMucGiamTruComponent } from './HR/danh-muc-giam-tru/danh-muc-giam-tru.component';
import { DanhMucHopDongComponent } from './HR/danh-muc-hop-dong/danh-muc-hop-dong.component';
import { DanhMucLuongCoBanComponent } from './HR/danh-muc-luong-co-ban/danh-muc-luong-co-ban.component';
import { DanhMucNganHangComponent } from './HR/danh-muc-ngan-hang/danh-muc-ngan-hang.component';
import { DanhMucThueComponent } from './HR/danh-muc-thue/danh-muc-thue.component';
import { HRBangLuongComponent } from './HR/hrbang-luong/hrbang-luong.component';
import { HRChamCongComponent } from './HR/hrcham-cong/hrcham-cong.component';
import { HRLichCongTacComponent } from './HR/hrlich-cong-tac/hrlich-cong-tac.component';
import { HRNhanVienComponent } from './HR/hrnhan-vien/hrnhan-vien.component';
import { DanhMucDonViTinhComponent } from './HR/danh-muc-don-vi-tinh/danh-muc-don-vi-tinh.component';
import { DanhMucMayChamCongComponent } from './HR/danh-muc-may-cham-cong/danh-muc-may-cham-cong.component';
import { HRNhanVienHopDongComponent } from './HR/hrnhan-vien-hop-dong/hrnhan-vien-hop-dong.component';
import { HRNhanVienInfoComponent } from './HR/hrnhan-vien-info/hrnhan-vien-info.component';
import { HRBangLuongInfoComponent } from './HR/hrbang-luong-info/hrbang-luong-info.component';
import { HRLichCongTacInfoComponent } from './HR/hrlich-cong-tac-info/hrlich-cong-tac-info.component';
import { HRChamCongInfoComponent } from './HR/hrcham-cong-info/hrcham-cong-info.component';
import { HRNhanVienHopDongInfoComponent } from './HR/hrnhan-vien-hop-dong-info/hrnhan-vien-hop-dong-info.component';
import { DanhMucPhongBanComponent } from './HR/danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucHopDongInfoComponent } from './HR/danh-muc-hop-dong-info/danh-muc-hop-dong-info.component';
import { ReportNSTLA0001Component } from './Report/report-nstla0001/report-nstla0001.component';
import { DanhMucThongKeComponent } from './danh-muc-thong-ke/danh-muc-thong-ke.component';
import { ThongKeComponent } from './thong-ke/thong-ke.component';
import { ThongKeInfoComponent } from './thong-ke-info/thong-ke-info.component';
import { ReportA0002Component } from './Report/report-a0002/report-a0002.component';
import { ReportA0002DetailComponent } from './Report/report-a0002-detail/report-a0002-detail.component';
import { ReportA0002InfoComponent } from './Report/report-a0002-info/report-a0002-info.component';




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
    TiepNhanComponent,
    TiepNhanInfoComponent,
    NSNHANVIENComponent,
    NSNHANVIENInfoComponent,
    KhamBenhInfoComponent,
    KhamBenhComponent,
    KhamBenhVaoVienComponent,
    KhamBenhVaoVienInfoComponent,
    ThanhVien001Component,
    SysUsersInfo001Component,
    SysAppSettingsComponent,
    SysAppPrivateSettingsComponent,
    QuanLyCongViecComponent,
    KhamBenhToaThuocComponent,
    KhamBenhToaThuocInfoComponent,
    ChungTuComponent,
    ChungTuInfoComponent,
    XML9CV130Component,
    XML10CV130Component,
    XML11CV130Component,
    XML12CV130Component,
    XML13CV130Component,
    XML14CV130Component,
    XML15CV130Component,
    XML1CV130Component,
    XML2CV130Component,
    XML3CV130Component,
    XML4CV130Component,
    XML5CV130Component,
    XML6CV130Component,
    XML7CV130Component,
    XML8CV130Component,
    XMLCV130Component,
    SysAppSettingsCheckBHXHComponent,
    TiepNhan2025Component,
    KhamBenhNgoaiTru2025Component,
    XML1CV130DetailComponent,
    XML10CV130DetailComponent,
    XML11CV130DetailComponent,
    XML12CV130DetailComponent,
    XML13CV130DetailComponent,
    XML14CV130DetailComponent,
    XML15CV130DetailComponent,
    XML2CV130DetailComponent,
    XML3CV130DetailComponent,
    XML4CV130DetailComponent,
    XML5CV130DetailComponent,
    XML6CV130DetailComponent,
    XML7CV130DetailComponent,
    XML8CV130DetailComponent,
    XML9CV130DetailComponent,
    XMLCV130TagComponent,
    DMDanTocComponent,
    DMQuocGiaComponent,
    ReportDictionary0001Component,
    ReportA0001Component,
    DanhMucBacLuongComponent,
    DanhMucBangCapComponent,
    DanhMucChucDanhComponent,
    DanhMucChucVuComponent,
    DanhMucChuyenNganhComponent,
    DanhMucPhuCapComponent,
    DanhMucToChucDaoTaoComponent,
    DanhMucChamCongComponent,
    DanhMucGiamTruComponent,
    DanhMucHopDongComponent,
    DanhMucLuongCoBanComponent,
    DanhMucNganHangComponent,
    DanhMucThueComponent,
    HRBangLuongComponent,    
    HRChamCongComponent,    
    HRLichCongTacComponent,    
    HRNhanVienComponent, DanhMucDonViTinhComponent, DanhMucMayChamCongComponent, HRNhanVienHopDongComponent, HRNhanVienInfoComponent, HRBangLuongInfoComponent, HRLichCongTacInfoComponent, HRChamCongInfoComponent, HRNhanVienHopDongInfoComponent, DanhMucPhongBanComponent, DanhMucHopDongInfoComponent, ReportNSTLA0001Component, DanhMucThongKeComponent, ThongKeComponent, ThongKeInfoComponent, ReportA0002Component, ReportA0002DetailComponent, ReportA0002InfoComponent,    
    
    

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
