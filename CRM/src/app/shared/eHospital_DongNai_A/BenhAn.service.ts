import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn } from './BenhAn.model';
import { BaseService } from './Base.service';

import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { DM_DoiTuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.model';
import { DM_DoiTuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.service';

import { DM_ICD } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.model';
import { DM_ICDService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.service';
@Injectable({
  providedIn: 'root'
})
export class BenhAnService extends BaseService {
  DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_Id', 'SoBenhAn', 'SoLuuTru', 'LoaiBenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'NgayLap', 'ThoiGianLap', 'NoiLap_Id', 'NguoiLap_Id', 'BacSiDieuTriChinh_Id', 'BacSiDieuTri_Id', 'KhoaChuyenDen_Id', 'KhoaVao_Id', 'NgayVaoKhoa', 'ThoiGianVaoKhoa', 'KhoaRa_Id', 'NgayVaoVien', 'ThoiGianVaoVien', 'NgayRaVien', 'ThoiGianRaVien', 'SoNgayDieuTri', 'LyDoNhapVien_Id', 'LyDoXuatVien_Id', 'ChuyenDenBenhVien_Id', 'ChanDoanTuyenDuoi', 'ICD_TuyenDuoi', 'ChanDoanKhamBenh', 'ICD_KhamBenh', 'ChanDoanVaoKhoa', 'ICD_VaoKhoa', 'ChanDoanRaVien', 'ICD_BenhChinh', 'ICD_BenhPhu', 'KetQuaDieuTri_Id', 'MoTaTinhTrangRaVien', 'TienSuBanThan', 'TienSuGiaDinh', 'QuaTrinhBenhLy', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'KhamToanThan', 'TienLuong', 'KeHoachDieuTri', 'CanLamSang', 'LamSang', 'TaiBienDieuTri', 'NguyenNhanTaiBien_Id', 'GiaiPhauBenh', 'TinhTrangGiaiPhauBenh_Id', 'TrangThai', 'KhoaBenhAn', 'NgayKhoaBenhAn', 'ThoiGianKhoaBenhAn', 'NguoiKhoaBenhAn_Id', 'DaThanhToan', 'NgayThanhToan', 'ThoiGianThanhToan', 'NguoiThanhToan_Id', 'DaXacNhanDoanhThu', 'NgayXacNhanDoanhThu', 'ThoiGianXacNhanDoanhThu', 'NguoiXacNhanDoanhThu_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TuVong', 'NgayTuVong', 'ThoiGianTuVong', 'ThoiGianKhamNghiem', 'ThoiGianNhanTuThi', 'KetQuaKhamNghiem', 'GhiChu', 'ICD_TuVong_Id', 'BacSiGhiNhanTuVong_Id', 'BacSiKhamNghiem_Id', 'SoDienThoai', 'LanVaoVien', 'ChuyenVien_Id', 'ThuThuat', 'PhauThuat', 'BienChung', 'NguyenNhanTuVong_Id', 'ICD_GiaiPhauTuThi_Id', 'SoCapCuu', 'DoiTuong_Id', 'XacNhanChiPhi_Id', 'ICD_NguyenNhanXuatVien', 'SiteCode', 'Mapping_Public_Id', 'OtherSite_TongChiPhi', 'OtherSite_CoPhatSinhCLS', 'OtherSite_CoPhatSinhThuoc', 'OtherSite_TongTienHoTro', 'IsBenhAn2Khu', 'SiteCode_RaVien', 'OtherSite_XacNhanChiPhi_ID', 'IsDaChuyenKhu', 'TruongKhoa_Id', 'ThuTruong_Id', 'Export'];
  DisplayColumns002: string[] = ['STT', 'TiepNhan_Id', 'BenhAn_Id', 'SoBenhAn', 'SoLuuTru', 'LoaiBenhAn_Id', 'TrangThai', 'BenhNhan_Id', 'DoiTuong_Id', 'ThoiGianVaoVien', 'ThoiGianRaVien', 'NoiLap_Id', 'NguoiLap_Id', 'KhoaVao_Id', 'KhoaRa_Id', 'ICD_VaoKhoa', 'ChanDoanVaoKhoa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id',];
  List: BenhAn[] | undefined;
  ListFilter: BenhAn[] | undefined;
  FormData!: BenhAn;
  constructor(
    public httpClient: HttpClient,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
    public NS_NHANVIENService: NS_NHANVIENService,
  ) {
    super(httpClient);
    this.Controller = "BenhAn";

    this.Sys_UsersSearch();
    this.Lst_DictionarySearch();
    this.DM_DoiTuongSearch();
    this.DM_ICDSearch();
    this.DM_PhongBanSearch();
    this.NS_NHANVIENSearch();
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLoaiBenhAn;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListLoaiBenhAn = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DoiTuongSearch() {
    this.DM_DoiTuongService.ComponentGetAllToListAsync(this.DM_DoiTuongService);
  }
  DM_ICDSearch() {
    this.DM_ICDService.ComponentGetAllToListAsync(this.DM_ICDService);
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
  }
  RenderToListTransfer(Sort: MatSort, Paginator: MatPaginator) {

    var List = [...new Map(this.List.map(item => [item.KhoaVao_Id, item])).values()];
    var ListID = List.map(function (a) { return a.KhoaVao_Id; });
    this.BaseParameter.Note = environment.InitializationString;
    for (let i = 0; i < ListID.length; i++) {
      let ListSub = this.List.filter(item => item.KhoaVao_Id == ListID[i]);
      if (ListSub) {
        let Model = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListID[i]);
        if (Model) {
          if (Model.length) {
            this.BaseParameter.Note = this.BaseParameter.Note + ", " + Model[0].TenPhongBan + " (" + ListSub.length + ")";
          }
        }
      }
    }

    var ListBenhNhan = [...new Map(this.List.map(item => [item.BenhNhan_Id, item])).values()];
    var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });
    ListBenhNhanID = ListBenhNhanID.filter(item => item > 0);
    if (ListBenhNhanID) {
      this.IsShowLoading = true;
      this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
      this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
        res => {
          this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
          this.IsShowLoading = true;
          for (let i = 0; i < this.List.length; i++) {
            let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiTao_Id);
            if (Sys_Users) {
              if (Sys_Users.length) {
                this.List[i].NguoiTaoName = Sys_Users[0].User_Name
              }
            }
            Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiCapNhat_Id);
            if (Sys_Users) {
              if (Sys_Users.length) {
                this.List[i].NguoiCapNhatName = Sys_Users[0].User_Name
              }
            }
            let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.List[i].NguoiLap_Id);
            this.List[i].NguoiLapName = "" + this.List[i].NguoiLap_Id;
            if (NS_NHANVIEN) {
              if (NS_NHANVIEN.length) {
                this.List[i].NguoiLapName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
              }
            }
            let Lst_Dictionary = this.Lst_DictionaryService.ListLoaiBenhAn.filter(item => item.Dictionary_Id == this.List[i].LoaiBenhAn_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].LoaiBenhAnName = Lst_Dictionary[0].Dictionary_Name;
              }
            }
            let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.List[i].BenhNhan_Id);
            if (DM_BenhNhan) {
              if (DM_BenhNhan.length) {
                this.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
              }
            }
            let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.List[i].DoiTuong_Id);
            if (DM_DoiTuong) {
              if (DM_DoiTuong.length) {
                this.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
              }
            }
            let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.List[i].ICD_VaoKhoa);
            if (DM_ICD) {
              if (DM_ICD.length) {
                this.List[i].ICDVaoKhoaName = DM_ICD[0].MaICD;
              }
            }
            let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].NoiLap_Id);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {
                this.List[i].NoiLapName = DM_PhongBan[0].TenPhongBan;
              }
            }
            DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].KhoaVao_Id);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {
                this.List[i].KhoaVaoName = DM_PhongBan[0].TenPhongBan;
              }
            }
            DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].KhoaRa_Id);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {
                this.List[i].KhoaRaName = DM_PhongBan[0].TenPhongBan;
              }
            }
          }
          this.DataSource = new MatTableDataSource(this.List);
          this.DataSource.sort = Sort;
          this.DataSource.paginator = Paginator;
          this.IsShowLoading = false;
        },
        err => {
        },
        () => {
        }
      );
    }

  }
  GetByBenhAn_IdAsync() {
    let url = this.APIURL + this.Controller + '/GetByBenhAn_IdAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetBySearchStringAsync() {
    let url = this.APIURL + this.Controller + '/GetBySearchStringAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByNgayVaoVien_SearchStringToListAsync() {
    let url = this.APIURL + this.Controller + '/GetByNgayVaoVien_SearchStringToListAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByYear_Month_Day_SearchStringToListAsync() {
    if (this.BaseParameter.BatDau == null) {
      this.BaseParameter.BatDau = new Date();
    }
    this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
    this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
    this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
    let url = this.APIURL + this.Controller + '/GetByYear_Month_Day_SearchStringToListAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
}

