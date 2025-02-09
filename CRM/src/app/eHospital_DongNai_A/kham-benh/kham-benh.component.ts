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
  ) { }

  ngOnInit(): void {
    this.KhamBenhService.BaseParameter.NgayKham = new Date();
  }
  DateNgayKham(value) {
    this.KhamBenhService.BaseParameter.NgayKham = new Date(value);
  }
  KhamBenhSearch() {
    this.KhamBenhService.IsShowLoading = true;
    this.KhamBenhService.GetByNgayKham_SearchStringToListAsync().subscribe(
      res => {
        this.KhamBenhService.List = (res as KhamBenh[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));
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
  KhamBenhSave(element: KhamBenh) {
    this.KhamBenhService.FormData = element;
    this.NotificationService.warn(this.KhamBenhService.ComponentSaveAll(this.KhamBenhSort, this.KhamBenhPaginator));
  }
  KhamBenhDelete(element: KhamBenh) {
    this.KhamBenhService.FormData = element;
    this.NotificationService.warn(this.KhamBenhService.ComponentDeleteAll(this.KhamBenhSort, this.KhamBenhPaginator));
  }
}
