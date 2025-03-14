import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML4_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML4_CV130.model';
import { XML4_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML4_CV130.service';

@Component({
  selector: 'app-xml4-cv130',
  templateUrl: './xml4-cv130.component.html',
  styleUrls: ['./xml4-cv130.component.css']
})
export class XML4CV130Component implements OnInit {

  @ViewChild('XML4_CV130Sort') XML4_CV130Sort: MatSort;
  @ViewChild('XML4_CV130Paginator') XML4_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML4_CV130Service: XML4_CV130Service,
  ) { }

  ngOnInit(): void {
    this.KhoiTao();
    this.XML4_CV130Search();
  }
  KhoiTao() {
    this.XML4_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
    this.XML4_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
  }
  XML4_CV130Search() {
    this.XML4_CV130Service.IsShowLoading = true;
    this.XML4_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
      res => {
        this.XML4_CV130Service.List = (res as XML4_CV130[]).sort((a, b) => (a.NGAY_KQ > b.NGAY_KQ ? 1 : -1));
        this.XML4_CV130Service.DataSource = new MatTableDataSource(this.XML4_CV130Service.List);
        this.XML4_CV130Service.DataSource.sort = this.XML4_CV130Sort;
        this.XML4_CV130Service.DataSource.paginator = this.XML4_CV130Paginator;
        this.XML4_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML4_CV130Save(element: XML4_CV130) {
    this.XML4_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML4_CV130Service.ComponentSaveAll(this.XML4_CV130Sort, this.XML4_CV130Paginator));
  }
  XML4_CV130Delete(element: XML4_CV130) {
    this.XML4_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML4_CV130Service.ComponentDeleteAll(this.XML4_CV130Sort, this.XML4_CV130Paginator));
  }
}
