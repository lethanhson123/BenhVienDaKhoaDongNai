import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { BenhAn } from 'src/app/shared/eHospital_DongNai_A//BenhAn.model';
import { BenhAnService } from 'src/app/shared/eHospital_DongNai_A//BenhAn.service';

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

@Component({
  selector: 'app-benh-an-info',
  templateUrl: './benh-an-info.component.html',
  styleUrls: ['./benh-an-info.component.css']
})
export class BenhAnInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public BenhAnService: BenhAnService,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
    public NS_NHANVIENService: NS_NHANVIENService,

  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.BenhAnService.BaseParameter.BenhAn_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.BenhAnSearch();
  }
  DateNgayVaoVien(value) {
    this.BenhAnService.FormData.NgayVaoVien = new Date(value);
  }
  DateThoiGianVaoVien(value) {
    this.BenhAnService.FormData.ThoiGianVaoVien = new Date(value);
  }
  DateNgayRaVien(value) {
    this.BenhAnService.FormData.NgayRaVien = new Date(value);
  }
  DateThoiGianVaoKhoa(value) {
    this.BenhAnService.FormData.ThoiGianVaoKhoa = new Date(value);
  }
  DateNgayVaoKhoa(value) {
    this.BenhAnService.FormData.NgayVaoKhoa = new Date(value);
  }
  DateThoiGianLap(value) {
    this.BenhAnService.FormData.ThoiGianLap = new Date(value);
  }
  DateNgayLap(value) {
    this.BenhAnService.FormData.NgayLap = new Date(value);
  }
  DateThoiGianRaVien(value) {
    this.BenhAnService.FormData.ThoiGianRaVien = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.BaseParameter.BenhNhan_Id = this.BenhAnService.FormData.BenhNhan_Id;
    this.DM_BenhNhanService.GetByBenhNhan_IdAsync().subscribe(
      res => {
        this.DM_BenhNhanService.FormData = (res as DM_BenhNhan);
        this.BenhAnService.FormData.BenhNhanName = this.DM_BenhNhanService.FormData.TenBenhNhan;
      },
      err => {
      },
      () => {
      }
    );
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLoaiBenhAn;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.List = (res as Lst_Dictionary[]);
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
  DM_ICDFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_ICDService.ListFilter = this.DM_ICDService.List.filter(item => item.TenICD.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaICD.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_ICDService.ListFilter = this.DM_ICDService.List;
    }
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  DM_PhongBanFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List.filter(item => item.TenPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List;
    }
  }

  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
  }
  NS_NHANVIENFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.NS_NHANVIENService.ListFilter = this.NS_NHANVIENService.List.filter(item => item.MaNhanVien.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Ho.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Ten.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.NS_NHANVIENService.ListFilter = this.NS_NHANVIENService.List;
    }
  }
  BenhAnSearch() {
    this.BenhAnService.IsShowLoading = true;
    this.BenhAnService.GetByBenhAn_IdAsync().subscribe(
      res => {
        this.BenhAnService.FormData = res as BenhAn;
        if (this.BenhAnService.FormData.BenhAn_Id == environment.InitializationNumber) {
          this.BenhAnService.IsShowLoading = true;
          this.BenhAnService.BaseParameter.SearchString = this.ActiveRouter.snapshot.params.ID;
          this.BenhAnService.GetBySearchStringAsync().subscribe(
            res => {
              this.BenhAnService.FormData = res as BenhAn;
              this.Sys_UsersSearch();
              this.Lst_DictionarySearch();
              this.DM_DoiTuongSearch();
              this.DM_ICDSearch();
              this.DM_PhongBanSearch();
              this.NS_NHANVIENSearch();
              this.DM_BenhNhanSearch();
            },
            err => {
            },
            () => {
              this.BenhAnService.IsShowLoading = false;
            }
          );
        }
        else {
          this.BenhAnService.IsShowLoading = false;
        }
        this.Sys_UsersSearch();
        this.Lst_DictionarySearch();
        this.DM_DoiTuongSearch();
        this.DM_ICDSearch();
        this.DM_PhongBanSearch();
        this.NS_NHANVIENSearch();
        this.DM_BenhNhanSearch();
      },
      err => {
      },
      () => {
        this.BenhAnService.IsShowLoading = false;
      }
    );
  }
  BenhAnSave() {
    this.BenhAnService.IsShowLoading = true;
    this.BenhAnService.SaveAsync().subscribe(
      res => {
        this.BenhAnService.FormData = res as BenhAn;
        this.Router.navigateByUrl(environment.BenhAnInfo + this.BenhAnService.FormData.BenhAn_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.BenhAnService.IsShowLoading = false;
      }
    );
  }


}