import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML3_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML3_CV130.model';
import { XML3_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML3_CV130.service';

@Component({
  selector: 'app-xml3-cv130',
  templateUrl: './xml3-cv130.component.html',
  styleUrls: ['./xml3-cv130.component.css']
})
export class XML3CV130Component implements OnInit {

  @ViewChild('XML3_CV130Sort') XML3_CV130Sort: MatSort;
  @ViewChild('XML3_CV130Paginator') XML3_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML3_CV130Service: XML3_CV130Service,
  ) { }

  ngOnInit(): void {
    this.KhoiTao();
    this.XML3_CV130Search();
  }
  KhoiTao() {
    this.XML3_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
    this.XML3_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
  }
  XML3_CV130Search() {
    this.XML3_CV130Service.IsShowLoading = true;
    this.XML3_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
      res => {
        this.XML3_CV130Service.List = (res as XML3_CV130[]).sort((a, b) => (a.NGAY_YL > b.NGAY_YL ? 1 : -1));
        this.XML3_CV130Service.DataSource = new MatTableDataSource(this.XML3_CV130Service.List);
        this.XML3_CV130Service.DataSource.sort = this.XML3_CV130Sort;
        this.XML3_CV130Service.DataSource.paginator = this.XML3_CV130Paginator;
        this.XML3_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML3_CV130Save(element: XML3_CV130) {
    this.XML3_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML3_CV130Service.ComponentSaveAll(this.XML3_CV130Sort, this.XML3_CV130Paginator));
  }
  XML3_CV130Delete(element: XML3_CV130) {
    this.XML3_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML3_CV130Service.ComponentDeleteAll(this.XML3_CV130Sort, this.XML3_CV130Paginator));
  }
}
