import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamBenh } from 'src/app/shared/eHospital_DongNai_A/KhamBenh.model';
import { KhamBenhService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh.service';

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
  selector: 'app-kham-benh',
  templateUrl: './kham-benh.component.html',
  styleUrls: ['./kham-benh.component.css']
})
export class KhamBenhComponent implements OnInit {

  @ViewChild('KhamBenhSort') KhamBenhSort: MatSort;
  @ViewChild('KhamBenhPaginator') KhamBenhPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenhService: KhamBenhService,

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
    this.KhamBenhService.BaseParameter.NgayKham = new Date();
    this.Sys_UsersSearch();
    this.Lst_DictionarySearch();
    this.DM_DoiTuongSearch();
    this.DM_ICDSearch();
    this.DM_PhongBanSearch();
    this.DM_DichVuSearch();
    this.NS_NHANVIENSearch();
  }
  DateNgayKham(value) {
    this.KhamBenhService.BaseParameter.NgayKham = new Date(value);
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
  KhamBenhSearch() {
    this.KhamBenhService.IsShowLoading = true;
    this.KhamBenhService.GetByNgayKham_SearchStringToListAsync().subscribe(
      res => {
        this.KhamBenhService.List = (res as KhamBenh[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

        var ListKhoaVao = [...new Map(this.KhamBenhService.List.map(item => [item.PhongBan_Id, item])).values()];
        var ListKhoaVaoID = ListKhoaVao.map(function (a) { return a.PhongBan_Id; });
        this.KhamBenhService.BaseParameter.Note = environment.InitializationString;
        for (let i = 0; i < ListKhoaVaoID.length; i++) {
          let KhoaVaoSub = this.KhamBenhService.List.filter(item => item.PhongBan_Id == ListKhoaVaoID[i]);
          if (KhoaVaoSub) {
            let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListKhoaVaoID[i]);
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {                
                this.KhamBenhService.BaseParameter.Note = this.KhamBenhService.BaseParameter.Note + ", " + DM_PhongBan[0].TenPhongBan + " (" + KhoaVaoSub.length + ")";
              }
            }            
          }
        }
        
        var ListBenhNhan = [...new Map(this.KhamBenhService.List.map(item => [item.BenhNhan_Id, item])).values()];
        var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });
        if (ListBenhNhanID) {
          this.KhamBenhService.IsShowLoading = true;
          this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
          this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
            res => {
              this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
              this.KhamBenhService.IsShowLoading = true;
              for (let i = 0; i < this.KhamBenhService.List.length; i++) {
                let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.KhamBenhService.List[i].NguoiTao_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.KhamBenhService.List[i].NguoiTaoName = Sys_Users[0].User_Name
                  }
                }
                Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.KhamBenhService.List[i].NguoiCapNhat_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.KhamBenhService.List[i].NguoiCapNhatName = Sys_Users[0].User_Name
                  }
                }               
                let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.KhamBenhService.List[i].BacSiKham_Id);                
                if (NS_NHANVIEN) {
                  if (NS_NHANVIEN.length) {
                    this.KhamBenhService.List[i].BacSiKhamName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
                  }
                }         
                let Lst_Dictionary = this.Lst_DictionaryService.ListGiaiQuyetKhamBenh.filter(item => item.Dictionary_Id == this.KhamBenhService.List[i].HuongGiaiQuyet_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.KhamBenhService.List[i].HuongGiaiQuyetName = Lst_Dictionary[0].Dictionary_Name;
                  }
                }      
                Lst_Dictionary = this.Lst_DictionaryService.ListLyDoNhapVien.filter(item => item.Dictionary_Id == this.KhamBenhService.List[i].LyDoNhapVien_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.KhamBenhService.List[i].LyDoNhapVienName = Lst_Dictionary[0].Dictionary_Name;
                  }
                }      
                let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.KhamBenhService.List[i].BenhNhan_Id);
                if (DM_BenhNhan) {
                  if (DM_BenhNhan.length) {
                    this.KhamBenhService.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
                  }
                }
                let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.KhamBenhService.List[i].DoiTuong_Id);
                if (DM_DoiTuong) {
                  if (DM_DoiTuong.length) {
                    this.KhamBenhService.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
                  }
                }
                let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.KhamBenhService.List[i].ChanDoanICD_Id);
                if (DM_ICD) {
                  if (DM_ICD.length) {
                    this.KhamBenhService.List[i].ChanDoanICDName = DM_ICD[0].MaICD;
                  }
                }
                DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.KhamBenhService.List[i].ChanDoanPhuICD_Id);
                if (DM_ICD) {
                  if (DM_ICD.length) {
                    this.KhamBenhService.List[i].ChanDoanPhuICDName = DM_ICD[0].MaICD;
                  }
                }
                let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.KhamBenhService.List[i].PhongBan_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.KhamBenhService.List[i].PhongBanName = DM_PhongBan[0].TenPhongBan;
                  }
                }           
                DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.KhamBenhService.List[i].NhapKhoa_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.KhamBenhService.List[i].NhapKhoaName = DM_PhongBan[0].TenPhongBan;
                  }
                }     
                let DM_DichVu = this.DM_DichVuService.List.filter(item => item.DichVu_Id == this.KhamBenhService.List[i].DichVu_Id);
                if (DM_DichVu) {
                  if (DM_DichVu.length) {
                    this.KhamBenhService.List[i].DichVuName = DM_DichVu[0].TenDichVu;
                  }
                }          
              }
              this.KhamBenhService.DataSource = new MatTableDataSource(this.KhamBenhService.List);
              this.KhamBenhService.DataSource.sort = this.KhamBenhSort;
              this.KhamBenhService.DataSource.paginator = this.KhamBenhPaginator;
              this.KhamBenhService.IsShowLoading = false;
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
  KhamBenhSave(element: KhamBenh) {
    this.KhamBenhService.FormData = element;
    this.NotificationService.warn(this.KhamBenhService.ComponentSaveAll(this.KhamBenhSort, this.KhamBenhPaginator));
  }
  KhamBenhDelete(element: KhamBenh) {
    this.KhamBenhService.FormData = element;
    this.NotificationService.warn(this.KhamBenhService.ComponentDeleteAll(this.KhamBenhSort, this.KhamBenhPaginator));
  }
}
