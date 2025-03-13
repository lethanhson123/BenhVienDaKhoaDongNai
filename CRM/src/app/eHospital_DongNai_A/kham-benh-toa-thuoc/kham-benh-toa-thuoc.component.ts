import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamBenh_ToaThuoc } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_ToaThuoc.model';
import { KhamBenh_ToaThuocService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_ToaThuoc.service';

import { DM_KhoDuoc } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.model';
import { DM_KhoDuocService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.service';

@Component({
  selector: 'app-kham-benh-toa-thuoc',
  templateUrl: './kham-benh-toa-thuoc.component.html',
  styleUrls: ['./kham-benh-toa-thuoc.component.css']
})
export class KhamBenhToaThuocComponent implements OnInit {

  @ViewChild('KhamBenh_ToaThuocSort') KhamBenh_ToaThuocSort: MatSort;
  @ViewChild('KhamBenh_ToaThuocPaginator') KhamBenh_ToaThuocPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenh_ToaThuocService: KhamBenh_ToaThuocService,

    public DM_KhoDuocService: DM_KhoDuocService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.KhamBenh_ToaThuocService.BaseParameter.BatDau = new Date();
    this.DM_KhoDuocSearch();
  }
  DateBatDau(value) {
    this.KhamBenh_ToaThuocService.BaseParameter.BatDau = new Date(value);
  }
  DM_KhoDuocSearch() {
    this.DM_KhoDuocService.ComponentGetAllToListAsync(this.DM_KhoDuocService);
  }
  KhamBenh_ToaThuocSearch() {
    if (this.KhamBenh_ToaThuocService.BaseParameter.IsSearchAPI == true) {
      this.KhamBenh_ToaThuocService.IsShowLoading = true;
      this.KhamBenh_ToaThuocService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.KhamBenh_ToaThuocService.List = (res as KhamBenh_ToaThuoc[]).sort((a, b) => (a.ThoiGianToaThuoc < b.ThoiGianToaThuoc ? 1 : -1));

          this.KhamBenh_ToaThuocService.RenderToListTransfer(this.KhamBenh_ToaThuocSort, this.KhamBenh_ToaThuocPaginator);
          
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.KhamBenh_ToaThuocService.BaseParameter.SearchString = this.KhamBenh_ToaThuocService.BaseParameter.SearchString.trim();
      if (this.KhamBenh_ToaThuocService.DataSource) {
        this.KhamBenh_ToaThuocService.DataSource.filter = this.KhamBenh_ToaThuocService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  KhamBenh_ToaThuocSave(element: KhamBenh_ToaThuoc) {
    this.KhamBenh_ToaThuocService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_ToaThuocService.ComponentSaveAll(this.KhamBenh_ToaThuocSort, this.KhamBenh_ToaThuocPaginator));
  }
  KhamBenh_ToaThuocDelete(element: KhamBenh_ToaThuoc) {
    this.KhamBenh_ToaThuocService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_ToaThuocService.ComponentDeleteAll(this.KhamBenh_ToaThuocSort, this.KhamBenh_ToaThuocPaginator));
  }
}