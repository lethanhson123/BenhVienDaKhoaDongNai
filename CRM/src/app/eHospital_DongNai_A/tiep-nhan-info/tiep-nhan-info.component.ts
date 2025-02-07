import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { TiepNhan } from 'src/app/shared/eHospital_DongNai_A//TiepNhan.model';
import { TiepNhanService } from 'src/app/shared/eHospital_DongNai_A//TiepNhan.service';

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
  selector: 'app-tiep-nhan-info',
  templateUrl: './tiep-nhan-info.component.html',
  styleUrls: ['./tiep-nhan-info.component.css']
})
export class TiepNhanInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
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

  ) { }

  ngOnInit(): void {
    this.TiepNhanService.BaseParameter.TiepNhan_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.TiepNhanSearch();
  }
  DateNgayTiepNhan(value) {
    this.TiepNhanService.FormData.NgayTiepNhan = new Date(value);
  }
  DateThoiGianTiepNhan(value) {
    this.TiepNhanService.FormData.ThoiGianTiepNhan = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.BaseParameter.BenhNhan_Id = this.TiepNhanService.FormData.BenhNhan_Id;
    this.DM_BenhNhanService.GetByBenhNhan_IdAsync().subscribe(
      res => {
        this.DM_BenhNhanService.FormData = (res as DM_BenhNhan);
        this.TiepNhanService.FormData.BenhNhanName = this.DM_BenhNhanService.FormData.TenBenhNhan;
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
  TiepNhanSearch() {
    this.TiepNhanService.IsShowLoading = true;
    this.TiepNhanService.GetByTiepNhan_IdAsync().subscribe(
      res => {
        this.TiepNhanService.FormData = res as TiepNhan;
        this.Sys_UsersSearch();
        this.DM_DoiTuongSearch();
        this.DM_BenhNhanSearch();
      },
      err => {
      },
      () => {
        this.TiepNhanService.IsShowLoading = false;
      }
    );
  }
  TiepNhanSave() {
    this.TiepNhanService.IsShowLoading = true;
    this.TiepNhanService.SaveAsync().subscribe(
      res => {
        this.TiepNhanService.FormData = res as TiepNhan;
        this.Router.navigateByUrl(environment.TiepNhanInfo + this.TiepNhanService.FormData.TiepNhan_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.TiepNhanService.IsShowLoading = false;
      }
    );
  }


}