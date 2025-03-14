import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { KhamBenh_ToaThuoc } from 'src/app/shared/eHospital_DongNai_A//KhamBenh_ToaThuoc.model';
import { KhamBenh_ToaThuocService } from 'src/app/shared/eHospital_DongNai_A//KhamBenh_ToaThuoc.service';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

import { DM_KhoDuoc } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.model';
import { DM_KhoDuocService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.service';



@Component({
  selector: 'app-kham-benh-toa-thuoc-info',
  templateUrl: './kham-benh-toa-thuoc-info.component.html',
  styleUrls: ['./kham-benh-toa-thuoc-info.component.css']
})
export class KhamBenhToaThuocInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenh_ToaThuocService: KhamBenh_ToaThuocService,

    public DM_KhoDuocService: DM_KhoDuocService,
    public Sys_UsersService: Sys_UsersService,   

  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.KhamBenh_ToaThuocService.BaseParameter.KhamBenh_ToaThuoc_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.KhamBenh_ToaThuocSearch();
  }
  DateNgayToaThuoc(value) {
    this.KhamBenh_ToaThuocService.FormData.NgayToaThuoc = new Date(value);
  }
  DateThoiGianToaThuoc(value) {
    this.KhamBenh_ToaThuocService.FormData.ThoiGianToaThuoc = new Date(value);
  }
  DateThoiGianTao(value) {
    this.KhamBenh_ToaThuocService.FormData.ThoiGianTao = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  DM_KhoDuocSearch() {
    this.DM_KhoDuocService.ComponentGetAllToListAsync(this.DM_KhoDuocService);
  }
  KhamBenh_ToaThuocSearch() {
    this.KhamBenh_ToaThuocService.IsShowLoading = true;
    this.KhamBenh_ToaThuocService.GetByKhamBenh_ToaThuoc_IdAsync().subscribe(
      res => {
        this.KhamBenh_ToaThuocService.FormData = res as KhamBenh_ToaThuoc;
        this.Sys_UsersSearch();
        this.DM_KhoDuocSearch();
      },
      err => {
      },
      () => {
        this.KhamBenh_ToaThuocService.IsShowLoading = false;
      }
    );
  }
  KhamBenh_ToaThuocSave() {
    this.KhamBenh_ToaThuocService.IsShowLoading = true;
    this.KhamBenh_ToaThuocService.SaveAsync().subscribe(
      res => {
        this.KhamBenh_ToaThuocService.FormData = res as KhamBenh_ToaThuoc;
        this.Router.navigateByUrl(environment.KhamBenhToaThuocInfo + this.KhamBenh_ToaThuocService.FormData.KhamBenh_ToaThuoc_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.KhamBenh_ToaThuocService.IsShowLoading = false;
      }
    );
  }


}