import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';
import { GioiThieuComponent } from './gioi-thieu/gioi-thieu.component';
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
import { GoiSoThamSoComponent } from './goi-so-tham-so/goi-so-tham-so.component';
import { TaiLieuComponent } from './tai-lieu/tai-lieu.component';
import { Dashboard001Component } from './dashboard001/dashboard001.component';
import { UploadComponent } from './upload/upload.component';
import { KhachHangComponent } from './khach-hang/khach-hang.component';
import { KhachHangInfoComponent } from './khach-hang-info/khach-hang-info.component';
import { ZaloTokenComponent } from './zalo-token/zalo-token.component';
import { ZaloZNSComponent } from './zalo-zns/zalo-zns.component';
import { KhamSucKhoeComponent } from './kham-suc-khoe/kham-suc-khoe.component';
import { KhamSucKhoeInfoComponent } from './kham-suc-khoe-info/kham-suc-khoe-info.component';
import { TrucBanNhatKyComponent } from './truc-ban-nhat-ky/truc-ban-nhat-ky.component';
import { LstDictionaryTypeComponent } from './eHospital_DongNai_A_Dictionary/lst-dictionary-type/lst-dictionary-type.component';
import { LstDictionaryComponent } from './eHospital_DongNai_A_Dictionary/lst-dictionary/lst-dictionary.component';
import { DMBenhVienComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-vien/dm-benh-vien.component';
import { DMDonViHanhChinhComponent } from './eHospital_DongNai_A_Dictionary/dm-don-vi-hanh-chinh/dm-don-vi-hanh-chinh.component';
import { DMDonViHanhChinhTinhThanhComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-tinh-thanh/dmdon-vi-hanh-chinh-tinh-thanh.component';
import { DMDonViHanhChinhQuanHuyenComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-quan-huyen/dmdon-vi-hanh-chinh-quan-huyen.component';
import { DMDonViHanhChinhXaPhuongComponent } from './eHospital_DongNai_A_Dictionary/dmdon-vi-hanh-chinh-xa-phuong/dmdon-vi-hanh-chinh-xa-phuong.component';
import { DMBenhNhanComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-nhan/dm-benh-nhan.component';
import { DMBenhNhanInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-benh-nhan-info/dm-benh-nhan-info.component';
import { SysUsersComponent } from './eHospital_DongNai_A_System/sys-users/sys-users.component';
import { SysUsersInfoComponent } from './eHospital_DongNai_A_System/sys-users-info/sys-users-info.component';
import { SysGroupMenusComponent } from './eHospital_DongNai_A_System/sys-group-menus/sys-group-menus.component';
import { SysGroupsComponent } from './eHospital_DongNai_A_System/sys-groups/sys-groups.component';
import { SysMenusComponent } from './eHospital_DongNai_A_System/sys-menus/sys-menus.component';
import { SysParametersComponent } from './eHospital_DongNai_A_System/sys-parameters/sys-parameters.component';
import { SysReportsComponent } from './eHospital_DongNai_A_System/sys-reports/sys-reports.component';
import { SysReportsInfoComponent } from './eHospital_DongNai_A_System/sys-reports-info/sys-reports-info.component';
import { DanhMucMauSacComponent } from './danh-muc-mau-sac/danh-muc-mau-sac.component';
import { SysFunctionsComponent } from './eHospital_DongNai_A_System/sys-functions/sys-functions.component';
import { SysModulesComponent } from './eHospital_DongNai_A_System/sys-modules/sys-modules.component';
import { SysCommandsComponent } from './eHospital_DongNai_A_System/sys-commands/sys-commands.component';
import { SysGroupCommandsComponent } from './eHospital_DongNai_A_System/sys-group-commands/sys-group-commands.component';
import { DMDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-dich-vu/dm-dich-vu.component';
import { DMDonViTinhComponent } from './eHospital_DongNai_A_Dictionary/dm-don-vi-tinh/dm-don-vi-tinh.component';
import { DMICDComponent } from './eHospital_DongNai_A_Dictionary/dm-icd/dm-icd.component';
import { DMICDChuongComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-chuong/dm-icd-chuong.component';
import { DMICDCommonComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-common/dm-icd-common.component';
import { DMICDNhomComponent } from './eHospital_DongNai_A_Dictionary/dm-icd-nhom/dm-icd-nhom.component';
import { DMKhoDuocComponent } from './eHospital_DongNai_A_Dictionary/dm-kho-duoc/dm-kho-duoc.component';
import { DMNhomDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-nhom-dich-vu/dm-nhom-dich-vu.component';
import { DMPhongBanComponent } from './eHospital_DongNai_A_Dictionary/dm-phong-ban/dm-phong-ban.component';
import { DMLoaiDichVuComponent } from './eHospital_DongNai_A_Dictionary/dm-loai-dich-vu/dm-loai-dich-vu.component';
import { DMLoaiGiaComponent } from './eHospital_DongNai_A_Dictionary/dm-loai-gia/dm-loai-gia.component';
import { DMBangGiaComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia/dm-bang-gia.component';
import { DMBangGiaInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-info/dm-bang-gia-info.component';
import { DMDichVuInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-dich-vu-info/dm-dich-vu-info.component';
import { DMBangGiaCPHComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-cph/dm-bang-gia-cph.component';
import { DMBangGiaCPHInfoComponent } from './eHospital_DongNai_A_Dictionary/dm-bang-gia-cphinfo/dm-bang-gia-cphinfo.component';
import { BenhAnComponent } from './eHospital_DongNai_A/benh-an/benh-an.component';
import { BenhAnInfoComponent } from './eHospital_DongNai_A/benh-an-info/benh-an-info.component';
import { TiepNhanComponent } from './eHospital_DongNai_A/tiep-nhan/tiep-nhan.component';
import { TiepNhanInfoComponent } from './eHospital_DongNai_A/tiep-nhan-info/tiep-nhan-info.component';
import { NSNHANVIENComponent } from './eHospital_DongNai_A_NSTL/ns-nhanvien/ns-nhanvien.component';
import { NSNHANVIENInfoComponent } from './eHospital_DongNai_A_NSTL/ns-nhanvieninfo/ns-nhanvieninfo.component';
import { KhamBenhVaoVienInfoComponent } from './eHospital_DongNai_A/kham-benh-vao-vien-info/kham-benh-vao-vien-info.component';
import { KhamBenhVaoVienComponent } from './eHospital_DongNai_A/kham-benh-vao-vien/kham-benh-vao-vien.component';
import { KhamBenhInfoComponent } from './eHospital_DongNai_A/kham-benh-info/kham-benh-info.component';
import { KhamBenhComponent } from './eHospital_DongNai_A/kham-benh/kham-benh.component';
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
import { XML15CV130Component } from './eHospital_DongNai_A/xml15-cv130/xml15-cv130.component';
import { XML14CV130Component } from './eHospital_DongNai_A/xml14-cv130/xml14-cv130.component';
import { XML13CV130Component } from './eHospital_DongNai_A/xml13-cv130/xml13-cv130.component';
import { XML12CV130Component } from './eHospital_DongNai_A/xml12-cv130/xml12-cv130.component';
import { XML11CV130Component } from './eHospital_DongNai_A/xml11-cv130/xml11-cv130.component';
import { XML10CV130Component } from './eHospital_DongNai_A/xml10-cv130/xml10-cv130.component';
import { XML8CV130Component } from './eHospital_DongNai_A/xml8-cv130/xml8-cv130.component';
import { XML7CV130Component } from './eHospital_DongNai_A/xml7-cv130/xml7-cv130.component';
import { XML6CV130Component } from './eHospital_DongNai_A/xml6-cv130/xml6-cv130.component';
import { XML5CV130Component } from './eHospital_DongNai_A/xml5-cv130/xml5-cv130.component';
import { XML4CV130Component } from './eHospital_DongNai_A/xml4-cv130/xml4-cv130.component';
import { XML3CV130Component } from './eHospital_DongNai_A/xml3-cv130/xml3-cv130.component';
import { XML2CV130Component } from './eHospital_DongNai_A/xml2-cv130/xml2-cv130.component';
import { XML1CV130Component } from './eHospital_DongNai_A/xml1-cv130/xml1-cv130.component';
import { XMLCV130Component } from './eHospital_DongNai_A/xml-cv130/xml-cv130.component';
import { SysAppSettingsCheckBHXHComponent } from './eHospital_DongNai_A_Config/sys-app-settings-check-bhxh/sys-app-settings-check-bhxh.component';
import { TiepNhan2025Component } from './eHospital_BenhAnDienTu/tiep-nhan2025/tiep-nhan2025.component';
import { KhamBenhNgoaiTru2025Component } from './eHospital_BenhAnDienTu/kham-benh-ngoai-tru2025/kham-benh-ngoai-tru2025.component';
import { XMLCV130TagComponent } from './eHospital_DongNai_A/xmlcv130-tag/xmlcv130-tag.component';
import { DMDanTocComponent } from './eHospital_DongNai_A_Dictionary/dmdan-toc/dmdan-toc.component';
import { DMQuocGiaComponent } from './eHospital_DongNai_A_Dictionary/dmquoc-gia/dmquoc-gia.component';
import { ReportDictionary0001Component } from './Report/report-dictionary0001/report-dictionary0001.component';
import { ReportA0001Component } from './Report/report-a0001/report-a0001.component';
import { DanhMucToChucDaoTaoComponent } from './HR/danh-muc-to-chuc-dao-tao/danh-muc-to-chuc-dao-tao.component';
import { DanhMucBacLuongComponent } from './HR/danh-muc-bac-luong/danh-muc-bac-luong.component';
import { DanhMucBangCapComponent } from './HR/danh-muc-bang-cap/danh-muc-bang-cap.component';
import { DanhMucChucDanhComponent } from './HR/danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucChucVuComponent } from './HR/danh-muc-chuc-vu/danh-muc-chuc-vu.component';
import { DanhMucChuyenNganhComponent } from './HR/danh-muc-chuyen-nganh/danh-muc-chuyen-nganh.component';
import { DanhMucPhuCapComponent } from './HR/danh-muc-phu-cap/danh-muc-phu-cap.component';
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
import { HRBangLuongInfoComponent } from './HR/hrbang-luong-info/hrbang-luong-info.component';
import { HRChamCongInfoComponent } from './HR/hrcham-cong-info/hrcham-cong-info.component';
import { HRLichCongTacInfoComponent } from './HR/hrlich-cong-tac-info/hrlich-cong-tac-info.component';
import { HRNhanVienInfoComponent } from './HR/hrnhan-vien-info/hrnhan-vien-info.component';
import { HRNhanVienHopDongInfoComponent } from './HR/hrnhan-vien-hop-dong-info/hrnhan-vien-hop-dong-info.component';
import { DanhMucPhongBanComponent } from './HR/danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucHopDongInfoComponent } from './HR/danh-muc-hop-dong-info/danh-muc-hop-dong-info.component';
import { ReportNSTLA0001Component } from './Report/report-nstla0001/report-nstla0001.component';
import { DanhMucThongKeComponent } from './danh-muc-thong-ke/danh-muc-thong-ke.component';
import { ThongKeComponent } from './thong-ke/thong-ke.component';
import { ThongKeInfoComponent } from './thong-ke-info/thong-ke-info.component';
import { ReportA0002Component } from './Report/report-a0002/report-a0002.component';
import { BenhAnViewComponent } from './eHospital_DongNai_A/benh-an-view/benh-an-view.component';
import { BenhNhan001Component } from './eHospital_DongNai_A/benh-nhan001/benh-nhan001.component';
import { DanhMucQuayDichVuKhoaKhamBenhComponent } from './danh-muc-quay-dich-vu-khoa-kham-benh/danh-muc-quay-dich-vu-khoa-kham-benh.component';
import { SysAppSettingsCheckKeToanComponent } from './eHospital_DongNai_A_Config/sys-app-settings-check-ke-toan/sys-app-settings-check-ke-toan.component';
import { ReportA0005Component } from './Report/report-a0005/report-a0005.component';



const routes: Routes = [
  { path: '', redirectTo: '/Homepage', pathMatch: 'full' },
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
    path: 'DanhMucThanhVien', component: DanhMucThanhVienComponent,
  },
  {
    path: 'DanhMucChucNang', component: DanhMucChucNangComponent,
  },
  {
    path: 'DanhMucUngDung', component: DanhMucUngDungComponent,
  },
  {
    path: 'DanhMucMauSac', component: DanhMucMauSacComponent,
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
    path: 'DanhMucQuayDichVuKhoaKhamBenh', component: DanhMucQuayDichVuKhoaKhamBenhComponent,
  },

  {
    path: 'ThanhVien', component: ThanhVienComponent,
  },
  {
    path: 'ThanhVien001', component: ThanhVien001Component,
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
    path: 'GoiSoThamSo', component: GoiSoThamSoComponent,
  },

  {
    path: 'ManHinhTapTinDinhKem', component: ManHinhTapTinDinhKemComponent,
  },
  {
    path: 'ManHinhThongBao', component: ManHinhThongBaoComponent,
  },
  {
    path: 'TaiLieu', component: TaiLieuComponent,
  },
  {
    path: 'ZaloOA', component: ZaloTokenComponent,
  },
  {
    path: 'ZaloZNS', component: ZaloZNSComponent,
  },

  {
    path: 'Upload', component: UploadComponent,
  },

  {
    path: 'KhachHang', component: KhachHangComponent,
  },
  {
    path: 'KhachHangInfo/:ID', component: KhachHangInfoComponent,
  },

  {
    path: 'KhamSucKhoe', component: KhamSucKhoeComponent,
  },
  {
    path: 'KhamSucKhoeInfo/:ID', component: KhamSucKhoeInfoComponent,
  },

  {
    path: 'TrucBanNhatKy', component: TrucBanNhatKyComponent,
  },
  {
    path: 'QuanLyCongViec', component: QuanLyCongViecComponent,
  },

  {
    path: 'Dashboard001', component: Dashboard001Component,
  },

  {
    path: 'LstDictionaryType', component: LstDictionaryTypeComponent,
  },
  {
    path: 'LstDictionary', component: LstDictionaryComponent,
  },
  {
    path: 'DMBenhVien', component: DMBenhVienComponent,
  },
  {
    path: 'DMDonViHanhChinh', component: DMDonViHanhChinhComponent,
  },
  {
    path: 'DMDonViHanhChinhTinhThanh', component: DMDonViHanhChinhTinhThanhComponent,
  },
  {
    path: 'DMDonViHanhChinhQuanHuyen', component: DMDonViHanhChinhQuanHuyenComponent,
  },
  {
    path: 'DMDonViHanhChinhXaPhuong', component: DMDonViHanhChinhXaPhuongComponent,
  },
  {
    path: 'DMDanToc', component: DMDanTocComponent,
  },
  {
    path: 'DMQuocGia', component: DMQuocGiaComponent,
  },
  {
    path: 'DMDichVu', component: DMDichVuComponent,
  },
  {
    path: 'DMDichVuInfo/:ID', component: DMDichVuInfoComponent,
  },
  {
    path: 'DMDonViTinh', component: DMDonViTinhComponent,
  },
  {
    path: 'DMICD', component: DMICDComponent,
  },
  {
    path: 'DMICDChuong', component: DMICDChuongComponent,
  },
  {
    path: 'DMICDCommon', component: DMICDCommonComponent,
  },
  {
    path: 'DMICDNhom', component: DMICDNhomComponent,
  },
  {
    path: 'DMKhoDuoc', component: DMKhoDuocComponent,
  },
  {
    path: 'DMNhomDichVu', component: DMNhomDichVuComponent,
  },
  {
    path: 'DMLoaiDichVu', component: DMLoaiDichVuComponent,
  },
  {
    path: 'DMPhongBan', component: DMPhongBanComponent,
  },
  {
    path: 'DMLoaiGia', component: DMLoaiGiaComponent,
  },
  {
    path: 'DMBangGia', component: DMBangGiaComponent,
  },
  {
    path: 'DMBangGiaInfo/:ID', component: DMBangGiaInfoComponent,
  },
  {
    path: 'DMBangGiaCPH', component: DMBangGiaCPHComponent,
  },
  {
    path: 'DMBangGiaCPHInfo/:ID', component: DMBangGiaCPHInfoComponent,
  },

  {
    path: 'DMBenhNhan', component: DMBenhNhanComponent,
  },
  {
    path: 'DMBenhNhanInfo/:ID', component: DMBenhNhanInfoComponent,
  },

  {
    path: 'SysGroupCommands', component: SysGroupCommandsComponent,
  },
  {
    path: 'SysGroupMenus', component: SysGroupMenusComponent,
  },
  {
    path: 'SysGroups', component: SysGroupsComponent,
  },
  {
    path: 'SysMenus', component: SysMenusComponent,
  },
  {
    path: 'SysParameters', component: SysParametersComponent,
  },
  {
    path: 'SysModules', component: SysModulesComponent,
  },
  {
    path: 'SysFunctions', component: SysFunctionsComponent,
  },
  {
    path: 'SysCommands', component: SysCommandsComponent,
  },
  
  {
    path: 'SysAppSettings', component: SysAppSettingsComponent,
  },
  {
    path: 'SysAppSettingsCheckBHXH', component: SysAppSettingsCheckBHXHComponent,
  },
  {
    path: 'SysAppSettingsCheckKeToan', component: SysAppSettingsCheckKeToanComponent,
  },
  {
    path: 'SysAppPrivateSettings', component: SysAppPrivateSettingsComponent,
  },

  {
    path: 'SysReports', component: SysReportsComponent,
  },
  {
    path: 'SysReportsInfo/:ID', component: SysReportsInfoComponent,
  },

  {
    path: 'SysUsers', component: SysUsersComponent,
  },
  {
    path: 'SysUsersInfo/:ID', component: SysUsersInfoComponent,
  },
  {
    path: 'SysUsersInfo001/:ID', component: SysUsersInfo001Component,
  },
  {
    path: 'NSNHANVIEN', component: NSNHANVIENComponent,
  },
  {
    path: 'NSNHANVIENInfo/:ID', component: NSNHANVIENInfoComponent,
  },

  {
    path: 'BenhNhan001', component: BenhNhan001Component,
  },
  {
    path: 'BenhAn', component: BenhAnComponent,
  },
  {
    path: 'BenhAnInfo/:ID', component: BenhAnInfoComponent,
  },
  {
    path: 'BenhAnView/:ID', component: BenhAnViewComponent,
  },
  {
    path: 'TiepNhan', component: TiepNhanComponent,
  },
  {
    path: 'TiepNhanInfo/:ID', component: TiepNhanInfoComponent,
  },
  {
    path: 'KhamBenh', component: KhamBenhComponent,
  },
  {
    path: 'KhamBenhInfo/:ID', component: KhamBenhInfoComponent,
  },
  {
    path: 'KhamBenhVaoVien', component: KhamBenhVaoVienComponent,
  },
  {
    path: 'KhamBenhVaoVienInfo/:ID', component: KhamBenhVaoVienInfoComponent,
  },
  {
    path: 'KhamBenhToaThuoc', component: KhamBenhToaThuocComponent,
  },
  {
    path: 'KhamBenhToaThuocInfo/:ID', component: KhamBenhToaThuocInfoComponent,
  },
  {
    path: 'ChungTu', component: ChungTuComponent,
  },
  {
    path: 'ChungTuInfo/:ID', component: ChungTuInfoComponent,
  },

  {
    path: 'XML1CV130', component: XML1CV130Component,
  },
  {
    path: 'XML2CV130', component: XML2CV130Component,
  },
  {
    path: 'XML3CV130', component: XML3CV130Component,
  },
  {
    path: 'XML4CV130', component: XML4CV130Component,
  },
  {
    path: 'XML5CV130', component: XML5CV130Component,
  },
  {
    path: 'XML6CV130', component: XML6CV130Component,
  },
  {
    path: 'XML7CV130', component: XML7CV130Component,
  },
  {
    path: 'XML8CV130', component: XML8CV130Component,
  },
  {
    path: 'XML9CV130', component: XML9CV130Component,
  },
  {
    path: 'XML10CV130', component: XML10CV130Component,
  },
  {
    path: 'XML11CV130', component: XML11CV130Component,
  },
  {
    path: 'XML12CV130', component: XML12CV130Component,
  },
  {
    path: 'XML13CV130', component: XML13CV130Component,
  },
  {
    path: 'XML14CV130', component: XML14CV130Component,
  },
  {
    path: 'XML15CV130', component: XML15CV130Component,
  },
  {
    path: 'XMLCV130', component: XMLCV130Component,
  },
  {
    path: 'XMLCV130Tag', component: XMLCV130TagComponent,
  },

  {
    path: 'TiepNhan2025', component: TiepNhan2025Component,
  },
  {
    path: 'KhamBenhNgoaiTru2025', component: KhamBenhNgoaiTru2025Component,
  },


  {
    path: 'ReportDictionary0001', component: ReportDictionary0001Component,
  },
  {
    path: 'ReportA0001', component: ReportA0001Component,
  },
  {
    path: 'ReportNSTLA0001', component: ReportNSTLA0001Component,
  },
  {
    path: 'ReportA0002', component: ReportA0002Component,
  },
  {
    path: 'ReportA0005', component: ReportA0005Component,
  },

  {
    path: 'DanhMucToChucDaoTao', component: DanhMucToChucDaoTaoComponent,
  },
  {
    path: 'DanhMucPhuCap', component: DanhMucPhuCapComponent,
  },
  {
    path: 'DanhMucChuyenNganh', component: DanhMucChuyenNganhComponent,
  },
  {
    path: 'DanhMucChucVu', component: DanhMucChucVuComponent,
  },
  {
    path: 'DanhMucChucDanh', component: DanhMucChucDanhComponent,
  },
  {
    path: 'DanhMucBangCap', component: DanhMucBangCapComponent,
  },
  {
    path: 'DanhMucBacLuong', component: DanhMucBacLuongComponent,
  },
  {
    path: 'DanhMucChamCong', component: DanhMucChamCongComponent,
  },
  {
    path: 'DanhMucGiamTru', component: DanhMucGiamTruComponent,
  },
  {
    path: 'DanhMucHopDong', component: DanhMucHopDongComponent,
  },
  {
    path: 'DanhMucHopDongInfo/:ID', component: DanhMucHopDongInfoComponent,
  },
  {
    path: 'DanhMucLuongCoBan', component: DanhMucLuongCoBanComponent,
  },
  {
    path: 'DanhMucNganHang', component: DanhMucNganHangComponent,
  },
  {
    path: 'DanhMucThue', component: DanhMucThueComponent,
  },
  {
    path: 'DanhMucDonViTinh', component: DanhMucDonViTinhComponent,
  },
  {
    path: 'DanhMucMayChamCong', component: DanhMucMayChamCongComponent,
  },
  {
    path: 'DanhMucPhongBan', component: DanhMucPhongBanComponent,
  },
  {
    path: 'HRBangLuong', component: HRBangLuongComponent,
  },
  {
    path: 'HRBangLuongInfo/:ID', component: HRBangLuongInfoComponent,
  },
  {
    path: 'HRChamCong', component: HRChamCongComponent,
  },
  {
    path: 'HRChamCongInfo/:ID', component: HRChamCongInfoComponent,
  },
  {
    path: 'HRLichCongTac', component: HRLichCongTacComponent,
  },
  {
    path: 'HRLichCongTacInfo/:ID', component: HRLichCongTacInfoComponent,
  },
  {
    path: 'HRNhanVien', component: HRNhanVienComponent,
  },
  {
    path: 'HRNhanVienInfo/:ID', component: HRNhanVienInfoComponent,
  },
  {
    path: 'HRNhanVienHopDong', component: HRNhanVienHopDongComponent,
  },
  {
    path: 'HRNhanVienHopDongInfo/:ID', component: HRNhanVienHopDongInfoComponent,
  },

  {
    path: 'DanhMucThongKe', component: DanhMucThongKeComponent,
  },
  {
    path: 'ThongKe', component: ThongKeComponent,
  },
  {
    path: 'ThongKeInfo/:ID', component: ThongKeInfoComponent,
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































