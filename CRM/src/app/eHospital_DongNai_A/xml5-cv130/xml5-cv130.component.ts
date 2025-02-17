import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML5_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML5_CV130.model';
import { XML5_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML5_CV130.service';

@Component({
  selector: 'app-xml5-cv130',
  templateUrl: './xml5-cv130.component.html',
  styleUrls: ['./xml5-cv130.component.css']
})
export class XML5CV130Component implements OnInit {

  @ViewChild('XML5_CV130Sort') XML5_CV130Sort: MatSort;
  @ViewChild('XML5_CV130Paginator') XML5_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML5_CV130Service: XML5_CV130Service,
  ) { }

  ngOnInit(): void {
    this.KhoiTao();
    this.XML5_CV130Search();
  }
  KhoiTao() {
    this.XML5_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
    this.XML5_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
  }
  XML5_CV130Search() {
    this.XML5_CV130Service.IsShowLoading = true;
    this.XML5_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
      res => {
        this.XML5_CV130Service.List = (res as XML5_CV130[]).sort((a, b) => (a.THOI_DIEM_DBLS > b.THOI_DIEM_DBLS ? 1 : -1));
        this.XML5_CV130Service.DataSource = new MatTableDataSource(this.XML5_CV130Service.List);
        this.XML5_CV130Service.DataSource.sort = this.XML5_CV130Sort;
        this.XML5_CV130Service.DataSource.paginator = this.XML5_CV130Paginator;
        this.XML5_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML5_CV130Save(element: XML5_CV130) {
    this.XML5_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML5_CV130Service.ComponentSaveAll(this.XML5_CV130Sort, this.XML5_CV130Paginator));
  }
  XML5_CV130Delete(element: XML5_CV130) {
    this.XML5_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML5_CV130Service.ComponentDeleteAll(this.XML5_CV130Sort, this.XML5_CV130Paginator));
  }
}