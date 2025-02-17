import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML10_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML10_CV130.model';
import { XML10_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML10_CV130.service';

@Component({
  selector: 'app-xml10-cv130',
  templateUrl: './xml10-cv130.component.html',
  styleUrls: ['./xml10-cv130.component.css']
})
export class XML10CV130Component implements OnInit {

  @ViewChild('XML10_CV130Sort') XML10_CV130Sort: MatSort;
  @ViewChild('XML10_CV130Paginator') XML10_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML10_CV130Service: XML10_CV130Service,
  ) { }

  ngOnInit(): void {
    this.KhoiTao();
    this.XML10_CV130Search();
  }
  KhoiTao() {
    this.XML10_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
    this.XML10_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
  }
  XML10_CV130Search() {
    this.XML10_CV130Service.IsShowLoading = true;
    this.XML10_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
      res => {
        this.XML10_CV130Service.List = (res as XML10_CV130[]).sort((a, b) => (a.NGAY_CT > b.NGAY_CT ? 1 : -1));
        this.XML10_CV130Service.DataSource = new MatTableDataSource(this.XML10_CV130Service.List);
        this.XML10_CV130Service.DataSource.sort = this.XML10_CV130Sort;
        this.XML10_CV130Service.DataSource.paginator = this.XML10_CV130Paginator;
        this.XML10_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML10_CV130Save(element: XML10_CV130) {
    this.XML10_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML10_CV130Service.ComponentSaveAll(this.XML10_CV130Sort, this.XML10_CV130Paginator));
  }
  XML10_CV130Delete(element: XML10_CV130) {
    this.XML10_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML10_CV130Service.ComponentDeleteAll(this.XML10_CV130Sort, this.XML10_CV130Paginator));
  }
}