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

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

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

    public ThanhVienService: ThanhVienService,

  ) { }

  ngOnInit(): void {
    this.KhamBenhService.BaseParameter.BatDau = new Date();    
  }
  DateBatDau(value) {
    this.KhamBenhService.BaseParameter.BatDau = new Date(value);
  }

  KhamBenhSearch() {
    if (this.KhamBenhService.BaseParameter.IsSearchAPI == true) {
      this.KhamBenhService.IsShowLoading = true;
      this.KhamBenhService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.KhamBenhService.List = (res as KhamBenh[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.KhamBenhService.RenderToListTransfer(this.KhamBenhSort, this.KhamBenhPaginator);
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.KhamBenhService.BaseParameter.SearchString = this.KhamBenhService.BaseParameter.SearchString.trim();
      if (this.KhamBenhService.DataSource) {
        this.KhamBenhService.DataSource.filter = this.KhamBenhService.BaseParameter.SearchString.toLowerCase();
      }
    }
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
