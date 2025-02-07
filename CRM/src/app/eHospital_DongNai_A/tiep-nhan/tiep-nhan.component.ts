import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TiepNhan } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.model';
import { TiepNhanService } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.service';

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

@Component({
  selector: 'app-tiep-nhan',
  templateUrl: './tiep-nhan.component.html',
  styleUrls: ['./tiep-nhan.component.css']
})
export class TiepNhanComponent implements OnInit {

  @ViewChild('TiepNhanSort') TiepNhanSort: MatSort;
  @ViewChild('TiepNhanPaginator') TiepNhanPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TiepNhanService: TiepNhanService,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
    public NS_NHANVIENService: NS_NHANVIENService,
    public DM_BenhVienService: DM_BenhVienService,
  ) { }

  ngOnInit(): void {
    this.TiepNhanService.BaseParameter.NgayTiepNhan = new Date();
    this.Sys_UsersSearch();
    this.DM_DoiTuongSearch();
    this.DM_PhongBanSearch();
    this.NS_NHANVIENSearch();
    this.DM_BenhVienSearch();
    this.Lst_DictionarySearch();
  }
  DateNgayTiepNhan(value) {
    this.TiepNhanService.BaseParameter.NgayTiepNhan = new Date(value);
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
  TiepNhanSearch() {
    this.TiepNhanService.IsShowLoading = true;
    this.TiepNhanService.GetByNgayTiepNhan_SearchStringToListAsync().subscribe(
      res => {
        this.TiepNhanService.List = (res as TiepNhan[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

        var ListNoiTiepNhan = [...new Map(this.TiepNhanService.List.map(item => [item.NoiTiepNhan_Id, item])).values()];
        var ListNoiTiepNhanID = ListNoiTiepNhan.map(function (a) { return a.NoiTiepNhan_Id; });
        this.TiepNhanService.BaseParameter.Note = environment.InitializationString;
        for (let i = 0; i < ListNoiTiepNhanID.length; i++) {
          let NoiTiepNhanSub = this.TiepNhanService.List.filter(item => item.NoiTiepNhan_Id == ListNoiTiepNhanID[i]);
          if (NoiTiepNhanSub) {
            let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == ListNoiTiepNhanID[i]);           
            if (DM_PhongBan) {
              if (DM_PhongBan.length) {                
                this.TiepNhanService.BaseParameter.Note = this.TiepNhanService.BaseParameter.Note + ", " + DM_PhongBan[0].TenPhongBan + " (" + NoiTiepNhanSub.length + ")";
              }       
              else{
                this.TiepNhanService.BaseParameter.Note = this.TiepNhanService.BaseParameter.Note + ", Kios (" + NoiTiepNhanSub.length + ")";
              }      
            }                         
          }
        }

        var ListBenhNhan = [...new Map(this.TiepNhanService.List.map(item => [item.BenhNhan_Id, item])).values()];
        var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });
        if (ListBenhNhanID) {
          this.TiepNhanService.IsShowLoading = true;
          this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
          this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
            res => {
              this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
              this.TiepNhanService.IsShowLoading = true;
              for (let i = 0; i < this.TiepNhanService.List.length; i++) {
                let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.TiepNhanService.List[i].NguoiTao_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.TiepNhanService.List[i].NguoiTaoName = Sys_Users[0].User_Name;
                  }
                }
                Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.TiepNhanService.List[i].NguoiCapNhat_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.TiepNhanService.List[i].NguoiCapNhatName = Sys_Users[0].User_Name;
                  }
                }
                let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.TiepNhanService.List[i].BenhNhan_Id);
                if (DM_BenhNhan) {
                  if (DM_BenhNhan.length) {
                    this.TiepNhanService.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].CMND;
                  }
                }
                let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.TiepNhanService.List[i].DoiTuong_Id);
                if (DM_DoiTuong) {
                  if (DM_DoiTuong.length) {
                    this.TiepNhanService.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
                  }
                }
                let DM_BenhVien = this.DM_BenhVienService.List.filter(item => item.BenhVien_Id == this.TiepNhanService.List[i].BenhVien_KCB_Id);
                if (DM_BenhVien) {
                  if (DM_BenhVien.length) {
                    this.TiepNhanService.List[i].DM_BenhVien = DM_BenhVien[0].TenBenhVien;
                  }
                }
                let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.TiepNhanService.List[i].NoiTiepNhan_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.TiepNhanService.List[i].NoiTiepNhan = DM_PhongBan[0].TenPhongBan;
                  }
                }
                let Lst_Dictionary = this.Lst_DictionaryService.ListHinhThucDenKhamBenh.filter(item => item.Dictionary_Id == this.TiepNhanService.List[i].HinhThucDenKham_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.TiepNhanService.List[i].HinhThucDenKhamBenh = Lst_Dictionary[0].Dictionary_Name;
                  }
                }
                Lst_Dictionary = this.Lst_DictionaryService.ListLyDoTiepNhan.filter(item => item.Dictionary_Id == this.TiepNhanService.List[i].LyDoTiepNhan_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.TiepNhanService.List[i].LyDoTiepNhan = Lst_Dictionary[0].Dictionary_Name;
                  }
                }
                Lst_Dictionary = this.Lst_DictionaryService.ListTuyenKhamChuaBenh.filter(item => item.Dictionary_Id == this.TiepNhanService.List[i].TuyenKhamBenh_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.TiepNhanService.List[i].TuyenKhamChuaBenh = Lst_Dictionary[0].Dictionary_Name;
                  }
                }
                Lst_Dictionary = this.Lst_DictionaryService.ListHinhThucChuyenVien.filter(item => item.Dictionary_Id == this.TiepNhanService.List[i].HinhThucChuyenVien_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.TiepNhanService.List[i].HinhThucChuyenVien = Lst_Dictionary[0].Dictionary_Name;
                  }
                }
                Lst_Dictionary = this.Lst_DictionaryService.ListLyDoChuyenVien.filter(item => item.Dictionary_Id == this.TiepNhanService.List[i].LyDoChuyenVien_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.TiepNhanService.List[i].LyDoChuyenVien = Lst_Dictionary[0].Dictionary_Name;
                  }
                }


              }
              this.TiepNhanService.DataSource = new MatTableDataSource(this.TiepNhanService.List);
              this.TiepNhanService.DataSource.sort = this.TiepNhanSort;
              this.TiepNhanService.DataSource.paginator = this.TiepNhanPaginator;
              this.TiepNhanService.IsShowLoading = false;
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
  TiepNhanSave(element: TiepNhan) {
    this.TiepNhanService.FormData = element;
    this.NotificationService.warn(this.TiepNhanService.ComponentSaveAll(this.TiepNhanSort, this.TiepNhanPaginator));
  }
  TiepNhanDelete(element: TiepNhan) {
    this.TiepNhanService.FormData = element;
    this.NotificationService.warn(this.TiepNhanService.ComponentDeleteAll(this.TiepNhanSort, this.TiepNhanPaginator));
  }
}
