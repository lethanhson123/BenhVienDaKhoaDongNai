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


];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































