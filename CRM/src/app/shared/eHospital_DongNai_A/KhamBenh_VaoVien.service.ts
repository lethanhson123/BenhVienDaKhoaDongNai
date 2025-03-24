import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_VaoVien } from './KhamBenh_VaoVien.model';
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
export class KhamBenh_VaoVienService extends BaseService {
  DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenhVaoVien_Id', 'SoPhieu', 'TiepNhan_Id', 'KhamBenh_Id', 'BenhNhan_Id', 'NguoiLienHe', 'DienThoaiLienHe', 'NoiLamViec', 'ChanDoanNoiGioiThieu', 'NgayKham', 'ThoiGianKham', 'LyDoVaoVien', 'QuaTrinhBenhLy', 'TienSuBanThan', 'TienSuGiaDinh', 'KhamXetToanThan', 'KhamXetCacBoPhan', 'KhamXetKQLS', 'ChanDoanVao', 'ICDKhamXet_Id', 'DaXuLy', 'NgayRa', 'ThoiGianRa', 'NhapKhoa_Id', 'ChuyenVien_Id', 'ChuY', 'Mach', 'NhietDo', 'HuyetApCao', 'HuyetApThap', 'NhipTho', 'CanNang', 'ChieuCao', 'BacSi_Id', 'XuTruKhamBenh_Id', 'CapCuu', 'NgayTaiNan', 'ThoiGianTaiNan', 'NoiTaiNan_TinhThanh_Id', 'NoiTaiNan_QuanHuyen_Id', 'NoiTaiNan_PhuongXa_Id', 'NoiTaiNan_DiaChi', 'DiaDiemTaiNan_Id', 'BoPhanBiThuong_Id', 'MucDo_Id', 'DienBienSauTN_Id', 'XuTriSauTN_Id', 'NguyenNhan_Id', 'NguyenNhanChiTiet_Id', 'ICD_NguyenNhan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoBenhAn', 'DiaDiemTaiNan', 'SoCapCuu_Co', 'SoCapCuu_Khong', 'PhuongTienDuaDen', 'PhuongTienSuDung', 'OTo', 'TauHoa', 'XeGanMay', 'XeTuChe', 'TuGayTaiNan', 'Khac', 'DoiMuBH_Co', 'DoiMuBH_Khong', 'DoiMuBH_KhongRo', 'GaiQuaiMuBH_Co', 'GaiQuaiMuBH_Khong', 'GaiQuaiMuBH_KhongRo', 'MuBHVo_Co', 'MuBHVo_Khong', 'MuBHVo_KhongRo', 'MuBH_TenHang', 'MuBH_TenHang_KhongRo', 'Ruou_Co', 'Ruou_Khong', 'Ruou_KhongRo', 'CamQuan_Co', 'CamQuan_Khong', 'NongDoCon_Mau', 'NongDoCon_Mau_KhongDo', 'NongDoCon_HoiTho', 'NongDoCon_HoiTho_KhongDo', 'ChanThuongNao_Co', 'ChanThuongNao_Khong', 'Glassgow', 'ChanThuongCotSongCo_Co', 'ChanThuongCotSongCo_Khong', 'ChanThuongHamMat', 'ChanThuongChi', 'ChanThuongNguc', 'DaChanThuong', 'NhapVien_Co', 'NhapVien_Khong', 'MoCapCuu_Co', 'MoCapCuu_Khong', 'TuVong_TruocBV', 'TuVong_TrongBV', 'XinVe', 'NoiChuyenTuyen', 'KhongChuyen', 'BenhAnNoiTru_ID', 'NoiChuyen_ID', 'LoaiTaiNan_ID'];
  DisplayColumns002: string[] = ['STT', 'KhamBenhVaoVien_Id', 'BenhAnNoiTru_ID', 'KhamBenh_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'NguoiLienHe', 'DienThoaiLienHe', 'CapCuu', 'ThoiGianKham', 'BacSi_Id', 'ICDKhamXet_Id', 'NhapKhoa_Id', 'ChanDoanNoiGioiThieu', 'LyDoVaoVien', 'QuaTrinhBenhLy', 'TienSuBanThan', 'TienSuGiaDinh', 'KhamXetToanThan', 'KhamXetCacBoPhan', 'KhamXetKQLS', 'ChanDoanVao', 'DaXuLy', 'ChuY', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];
  List: KhamBenh_VaoVien[] | undefined;
  ListFilter: KhamBenh_VaoVien[] | undefined;
  FormData!: KhamBenh_VaoVien;
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
    this.Controller = "KhamBenh_VaoVien";

    this.Sys_UsersSearch();
    this.DM_DoiTuongSearch();
    this.DM_ICDSearch();
    this.DM_PhongBanSearch();
    this.NS_NHANVIENSearch();
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
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

    var List = [...new Map(this.List.map(item => [item.NhapKhoa_Id, item])).values()];
    var ListID = List.map(function (a) { return a.NhapKhoa_Id; });
    this.BaseParameter.Note = environment.InitializationString;
    for (let i = 0; i < ListID.length; i++) {
      let ListSub = this.List.filter(item => item.NhapKhoa_Id == ListID[i]);
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

            let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.List[i].BacSi_Id);
            if (NS_NHANVIEN) {
              if (NS_NHANVIEN.length) {
                this.List[i].BacSiName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
              }
            }

            let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.List[i].BenhNhan_Id);
            if (DM_BenhNhan) {
              if (DM_BenhNhan.length) {
                this.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
              }
            }

            let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.List[i].ICDKhamXet_Id);
            if (DM_ICD) {
              if (DM_ICD.length) {
                this.List[i].ICDKhamXetName = DM_ICD[0].MaICD;
              }
            }

            let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.List[i].NhapKhoa_Id);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {
                this.List[i].NhapKhoaName = DM_PhongBan[0].TenPhongBan;
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
  GetByKhamBenhVaoVien_IdAsync() {
    let url = this.APIURL + this.Controller + '/GetByKhamBenhVaoVien_IdAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByNgayKham_SearchStringToListAsync() {
    let url = this.APIURL + this.Controller + '/GetByNgayKham_SearchStringToListAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByYear_Month_Day_SearchStringToListAsync() {
    this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
    this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
    this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
    let url = this.APIURL + this.Controller + '/GetByYear_Month_Day_SearchStringToListAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
  }
  GetByListIDToListAsync() {       
    let url = this.APIURL + this.Controller + '/GetByListIDToListAsync';
    const formUpload: FormData = new FormData();
    formUpload.append('data', JSON.stringify(this.BaseParameter));
    return this.httpClient.post(url, formUpload, { headers: this.Headers });
}
}

