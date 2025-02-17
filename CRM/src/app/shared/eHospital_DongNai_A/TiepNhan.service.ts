import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhan } from './TiepNhan.model';
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

import { DM_BenhVien } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.model';
import { DM_BenhVienService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.service';

@Injectable({
  providedIn: 'root'
})
export class TiepNhanService extends BaseService {
  DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhan_Id', 'SoTiepNhan', 'SoThuTu', 'UuTien', 'BenhNhan_Id', 'NoiTiepNhan_Id', 'NgayTiepNhan', 'ThoiGianTiepNhan', 'NamTiepNhan', 'ThangTiepNhan', 'DoiTuong_Id', 'NoiLamViec', 'NguoiLienHe_Id', 'NguoiLienHe', 'DiaChiLienHe', 'HinhThucDenKham_Id', 'NoiGioiThieu_Id', 'LyDoTiepNhan_Id', 'SoBHYT', 'BHYTTuNgay', 'BHYTDenNgay', 'ThuTienTruoc', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ChanDoanNGT', 'TaiKham', 'DonViCongTac_Id', 'PhieuDieuTri_Id', 'TuyenKhamBenh_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'LoaiBHYT', 'DoiTuong_ChiTiet_Id', 'BenhVien_KCB_Id', 'NgayBHYT1', 'NgayBHYT2', 'NgayBHYT3', 'XacNhanChiPhi_Id', 'SoChuyenVien', 'HinhThucChuyenVien_Id', 'LyDoChuyenVien_Id', 'HopDong_BenhNhan_Id', 'HinhThucThanhToan_Id', 'TienSuBenh', 'ThoiGianChuyenTuyen', 'TrungSoBHYT', 'Tren6Thang', 'ThuocUngThu', 'CongTyBHTN_ID', 'SoTheBHTN', 'BHTN_TuNgay', 'BHTN_DenNgay', 'BHTN_DiaChi', 'BHTN_DienThoai', 'BHTN_Fax', 'SiteCode', 'Mapping_Public_Id', 'IsDiffSite', 'The_ID', 'LoaiKhachHang_ID', 'KhongCungChiTra', 'NoiSinhSong_ID', 'TongTienHoTro', 'HieuLucTuNgay', 'HieuLucDenNgay', 'NgayHuong5Nam', 'DaXuatHSKSK', 'Export', 'NguoiGioiThieu_Id'];
  DisplayColumns002: string[] = ['STT', 'TiepNhan_Id', 'SoTiepNhan', 'ThoiGianTiepNhan', 'SoThuTu', 'NoiTiepNhan', 'BenhNhan_Id', 'UuTien', 'TaiKham', 'ThuTienTruoc', 'DoiTuong_Id', 'SoBHYT', 'BenhVien_KCB_Id', 'HinhThucDenKham_Id', 'LyDoTiepNhan_Id', 'TuyenKhamBenh_Id', 'HinhThucChuyenVien_Id', 'LyDoChuyenVien_Id', 'ThoiGianChuyenTuyen', 'SoChuyenVien', 'TienSuBenh', 'NguoiLienHe', 'DiaChiLienHe', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];
  List: TiepNhan[] | undefined;
  ListFilter: TiepNhan[] | undefined;
  FormData!: TiepNhan;
  constructor(
    public httpClient: HttpClient,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
    public NS_NHANVIENService: NS_NHANVIENService,
    public DM_BenhVienService: DM_BenhVienService,
  ) {
    super(httpClient);
    this.Controller = "TiepNhan";

    this.Sys_UsersSearch();
    this.DM_DoiTuongSearch();
    this.DM_PhongBanSearch();
    this.NS_NHANVIENSearch();
    this.DM_BenhVienSearch();
    this.Lst_DictionarySearch();
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  DM_DoiTuongSearch() {
    this.DM_DoiTuongService.ComponentGetAllToListAsync(this.DM_DoiTuongService);
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.ComponentGetAllToListAsync(this.DM_BenhNhanService);
  }
  DM_BenhVienSearch() {
    this.DM_BenhVienService.ComponentGetAllToListAsync(this.DM_BenhVienService);
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDHinhThucDenKhamBenh;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListHinhThucDenKhamBenh = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLyDoTiepNhan;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListLyDoTiepNhan = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDTuyenKhamChuaBenh;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListTuyenKhamChuaBenh = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDHinhThucChuyenVien;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListHinhThucChuyenVien = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLyDoChuyenVien;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListLyDoChuyenVien = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  RenderToListTransfer(Sort: MatSort, Paginator: MatPaginator) {

    var List = [...new Map(this.List.map(item => [item.NoiTiepNhan_Id, item])).values()];
    var ListID = List.map(function (a) { return a.NoiTiepNhan_Id; });
    this.BaseParameter.Note = environment.InitializationString;
    for (let i = 0; i < ListID.length; i++) {
      let ListSub = this.List.filter(item => item.NoiTiepNhan_Id == ListID[i]);
      if (ListSub) {
        let Model = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListID[i]);
        if (Model) {
          if (Model.length) {
            this.BaseParameter.Note = this.BaseParameter.Note + ", " + Model[0].TenPhongBan + " (" + ListSub.length + ")";
          }
          else {
            this.BaseParameter.Note = this.BaseParameter.Note + ", Kios (" + ListSub.length + ")";
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
                this.List[i].NguoiTaoName = Sys_Users[0].User_Name;
              }
            }
            Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiCapNhat_Id);
            if (Sys_Users) {
              if (Sys_Users.length) {
                this.List[i].NguoiCapNhatName = Sys_Users[0].User_Name;
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
            let DM_BenhVien = this.DM_BenhVienService.List.filter(item => item.BenhVien_Id == this.List[i].BenhVien_KCB_Id);
            if (DM_BenhVien) {
              if (DM_BenhVien.length) {
                this.List[i].DM_BenhVien = DM_BenhVien[0].TenBenhVien;
              }
            }
            let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].NoiTiepNhan_Id);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {
                this.List[i].NoiTiepNhan = DM_PhongBan[0].TenPhongBan;
              }
            }
            let Lst_Dictionary = this.Lst_DictionaryService.ListHinhThucDenKhamBenh.filter(item => item.Dictionary_Id == this.List[i].HinhThucDenKham_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].HinhThucDenKhamBenh = Lst_Dictionary[0].Dictionary_Name;
              }
            }
            Lst_Dictionary = this.Lst_DictionaryService.ListLyDoTiepNhan.filter(item => item.Dictionary_Id == this.List[i].LyDoTiepNhan_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].LyDoTiepNhan = Lst_Dictionary[0].Dictionary_Name;
              }
            }
            Lst_Dictionary = this.Lst_DictionaryService.ListTuyenKhamChuaBenh.filter(item => item.Dictionary_Id == this.List[i].TuyenKhamBenh_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].TuyenKhamChuaBenh = Lst_Dictionary[0].Dictionary_Name;
              }
            }
            Lst_Dictionary = this.Lst_DictionaryService.ListHinhThucChuyenVien.filter(item => item.Dictionary_Id == this.List[i].HinhThucChuyenVien_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].HinhThucChuyenVien = Lst_Dictionary[0].Dictionary_Name;
              }
            }
            Lst_Dictionary = this.Lst_DictionaryService.ListLyDoChuyenVien.filter(item => item.Dictionary_Id == this.List[i].LyDoChuyenVien_Id);
            if (Lst_Dictionary) {
              if (Lst_Dictionary.length) {
                this.List[i].LyDoChuyenVien = Lst_Dictionary[0].Dictionary_Name;
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
  GetByTiepNhan_IdAsync() {
    let url = this.APIURL + this.Controller + '/GetByTiepNhan_IdAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByNgayTiepNhan_SearchStringToListAsync() {
    let url = this.APIURL + this.Controller + '/GetByNgayTiepNhan_SearchStringToListAsync';
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

