import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamBenh_VaoVien } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_VaoVien.model';
import { KhamBenh_VaoVienService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_VaoVien.service';

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

import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.service';

@Component({
  selector: 'app-kham-benh-vao-vien',
  templateUrl: './kham-benh-vao-vien.component.html',
  styleUrls: ['./kham-benh-vao-vien.component.css']
})
export class KhamBenhVaoVienComponent implements OnInit {

  @ViewChild('KhamBenh_VaoVienSort') KhamBenh_VaoVienSort: MatSort;
  @ViewChild('KhamBenh_VaoVienPaginator') KhamBenh_VaoVienPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenh_VaoVienService: KhamBenh_VaoVienService,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
    public DM_DichVuService: DM_DichVuService,
    public NS_NHANVIENService: NS_NHANVIENService,
  ) { }

  ngOnInit(): void {
    this.KhamBenh_VaoVienService.BaseParameter.NgayKham = new Date();
    this.Sys_UsersSearch();
    this.Lst_DictionarySearch();
    this.DM_DoiTuongSearch();
    this.DM_ICDSearch();
    this.DM_PhongBanSearch();
    this.DM_DichVuSearch();
    this.NS_NHANVIENSearch();

  }
  DateNgayKham(value) {
    this.KhamBenh_VaoVienService.BaseParameter.NgayKham = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDGiaiQuyetKhamBenh;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListGiaiQuyetKhamBenh = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLyDoNhapVien;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListLyDoNhapVien = (res as Lst_Dictionary[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.ComponentGetAllToListAsync(this.DM_BenhNhanService);
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
  DM_DichVuSearch() {
    this.DM_DichVuService.ComponentGetAllToListAsync(this.DM_DichVuService);
  }
  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
  }
  KhamBenh_VaoVienSearch() {
    if (this.KhamBenh_VaoVienService.BaseParameter.IsSearchAPI == true) {
      this.KhamBenh_VaoVienService.IsShowLoading = true;
      this.KhamBenh_VaoVienService.GetByNgayKham_SearchStringToListAsync().subscribe(
        res => {
          this.KhamBenh_VaoVienService.List = (res as KhamBenh_VaoVien[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          var ListKhoaVao = [...new Map(this.KhamBenh_VaoVienService.List.map(item => [item.NhapKhoa_Id, item])).values()];
          var ListKhoaVaoID = ListKhoaVao.map(function (a) { return a.NhapKhoa_Id; });
          this.KhamBenh_VaoVienService.BaseParameter.Note = environment.InitializationString;
          for (let i = 0; i < ListKhoaVaoID.length; i++) {
            let KhoaVaoSub = this.KhamBenh_VaoVienService.List.filter(item => item.NhapKhoa_Id == ListKhoaVaoID[i]);
            if (KhoaVaoSub) {
              let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListKhoaVaoID[i]);
              if (DM_PhongBan) {
                if (DM_PhongBan.length) {
                  this.KhamBenh_VaoVienService.BaseParameter.Note = this.KhamBenh_VaoVienService.BaseParameter.Note + ", " + DM_PhongBan[0].TenPhongBan + " (" + KhoaVaoSub.length + ")";
                }
              }
            }
          }

          var ListBenhNhan = [...new Map(this.KhamBenh_VaoVienService.List.map(item => [item.BenhNhan_Id, item])).values()];
          var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });
          if (ListBenhNhanID) {
            this.KhamBenh_VaoVienService.IsShowLoading = true;
            this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
            this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
              res => {
                this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
                this.KhamBenh_VaoVienService.IsShowLoading = true;
                for (let i = 0; i < this.KhamBenh_VaoVienService.List.length; i++) {
                  let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.KhamBenh_VaoVienService.List[i].NguoiTao_Id);
                  if (Sys_Users) {
                    if (Sys_Users.length) {
                      this.KhamBenh_VaoVienService.List[i].NguoiTaoName = Sys_Users[0].User_Name
                    }
                  }
                  Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.KhamBenh_VaoVienService.List[i].NguoiCapNhat_Id);
                  if (Sys_Users) {
                    if (Sys_Users.length) {
                      this.KhamBenh_VaoVienService.List[i].NguoiCapNhatName = Sys_Users[0].User_Name
                    }
                  }
                  let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.KhamBenh_VaoVienService.List[i].BacSi_Id);
                  if (NS_NHANVIEN) {
                    if (NS_NHANVIEN.length) {
                      this.KhamBenh_VaoVienService.List[i].BacSiName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
                    }
                  }
                  let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.KhamBenh_VaoVienService.List[i].BenhNhan_Id);
                  if (DM_BenhNhan) {
                    if (DM_BenhNhan.length) {
                      this.KhamBenh_VaoVienService.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
                    }
                  }

                  let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.KhamBenh_VaoVienService.List[i].ICDKhamXet_Id);
                  if (DM_ICD) {
                    if (DM_ICD.length) {
                      this.KhamBenh_VaoVienService.List[i].ICDKhamXetName = DM_ICD[0].MaICD;
                    }
                  }


                  let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.KhamBenh_VaoVienService.List[i].NhapKhoa_Id);
                  if (DM_PhongBan) {
                    if (DM_PhongBan.length) {
                      this.KhamBenh_VaoVienService.List[i].NhapKhoaName = DM_PhongBan[0].TenPhongBan;
                    }
                  }

                }
                this.KhamBenh_VaoVienService.DataSource = new MatTableDataSource(this.KhamBenh_VaoVienService.List);
                this.KhamBenh_VaoVienService.DataSource.sort = this.KhamBenh_VaoVienSort;
                this.KhamBenh_VaoVienService.DataSource.paginator = this.KhamBenh_VaoVienPaginator;
                this.KhamBenh_VaoVienService.IsShowLoading = false;
              },
              err => {
              },
              () => {
              }
            );
          }
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.KhamBenh_VaoVienService.BaseParameter.SearchString = this.KhamBenh_VaoVienService.BaseParameter.SearchString.trim();
      if (this.KhamBenh_VaoVienService.DataSource) {
        this.KhamBenh_VaoVienService.DataSource.filter = this.KhamBenh_VaoVienService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  KhamBenh_VaoVienSave(element: KhamBenh_VaoVien) {
    this.KhamBenh_VaoVienService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_VaoVienService.ComponentSaveAll(this.KhamBenh_VaoVienSort, this.KhamBenh_VaoVienPaginator));
  }
  KhamBenh_VaoVienDelete(element: KhamBenh_VaoVien) {
    this.KhamBenh_VaoVienService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_VaoVienService.ComponentDeleteAll(this.KhamBenh_VaoVienSort, this.KhamBenh_VaoVienPaginator));
  }
}
