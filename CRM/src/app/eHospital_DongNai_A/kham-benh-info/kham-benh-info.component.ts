import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { KhamBenh } from 'src/app/shared/eHospital_DongNai_A//KhamBenh.model';
import { KhamBenhService } from 'src/app/shared/eHospital_DongNai_A//KhamBenh.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

@Component({
  selector: 'app-kham-benh-info',
  templateUrl: './kham-benh-info.component.html',
  styleUrls: ['./kham-benh-info.component.css']
})
export class KhamBenhInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenhService: KhamBenhService,

    public Sys_UsersService: Sys_UsersService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_PhongBanService: DM_PhongBanService,
    public DM_DichVuService: DM_DichVuService,


  ) { }

  ngOnInit(): void {
    this.KhamBenhService.BaseParameter.KhamBenh_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.KhamBenhSearch();
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.BaseParameter.BenhNhan_Id = this.KhamBenhService.FormData.BenhNhan_Id;
    this.DM_BenhNhanService.GetByBenhNhan_IdAsync().subscribe(
      res => {
        this.DM_BenhNhanService.FormData = (res as DM_BenhNhan);
        this.KhamBenhService.FormData.BenhNhanName = this.DM_BenhNhanService.FormData.TenBenhNhan;
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.BaseParameter.PhongBan_Id = this.KhamBenhService.FormData.PhongBan_Id;
    this.DM_PhongBanService.GetByPhongBan_IdAsync().subscribe(
      res => {
        this.DM_PhongBanService.FormData = (res as DM_PhongBan);
        this.KhamBenhService.FormData.PhongBanName = this.DM_PhongBanService.FormData.TenPhongBan;
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DichVuSearch() {
    this.DM_DichVuService.BaseParameter.DichVu_Id = this.KhamBenhService.FormData.DichVu_Id;
    this.DM_DichVuService.GetByDichVu_IdAsync().subscribe(
      res => {
        this.DM_DichVuService.FormData = (res as DM_DichVu);
        this.KhamBenhService.FormData.DichVuName = this.DM_DichVuService.FormData.TenDichVu;
      },
      err => {
      },
      () => {
      }
    );
  }
  KhamBenhSearch() {
    this.KhamBenhService.IsShowLoading = true;
    this.KhamBenhService.GetByKhamBenh_IdAsync().subscribe(
      res => {
        this.KhamBenhService.FormData = res as KhamBenh;
        this.Sys_UsersSearch();
        this.DM_BenhNhanSearch();
        this.DM_PhongBanSearch();
        this.DM_DichVuSearch();
      },
      err => {
      },
      () => {
        this.KhamBenhService.IsShowLoading = false;
      }
    );
  }
  KhamBenhSave() {
    this.KhamBenhService.IsShowLoading = true;
    this.KhamBenhService.SaveAsync().subscribe(
      res => {
        this.KhamBenhService.FormData = res as KhamBenh;
        this.Router.navigateByUrl(environment.KhamBenhInfo + this.KhamBenhService.FormData.KhamBenh_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.KhamBenhService.IsShowLoading = false;
      }
    );
  }


}