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
    if (this.TiepNhanService.BaseParameter.IsSearchAPI == true) {
      this.TiepNhanService.IsShowLoading = true;
      this.TiepNhanService.GetByNgayTiepNhan_SearchStringToListAsync().subscribe(
        res => {
          this.TiepNhanService.List = (res as TiepNhan[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.TiepNhanService.RenderToListTransfer(this.TiepNhanSort, this.TiepNhanPaginator);

        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.TiepNhanService.BaseParameter.SearchString = this.TiepNhanService.BaseParameter.SearchString.trim();
      if (this.TiepNhanService.DataSource) {
        this.TiepNhanService.DataSource.filter = this.TiepNhanService.BaseParameter.SearchString.toLowerCase();
      }
    }
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
