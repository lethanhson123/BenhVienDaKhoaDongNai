import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML7_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML7_CV130.model';
import { XML7_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML7_CV130.service';

@Component({
  selector: 'app-xml7-cv130',
  templateUrl: './xml7-cv130.component.html',
  styleUrls: ['./xml7-cv130.component.css']
})
export class XML7CV130Component implements OnInit {

  @ViewChild('XML7_CV130Sort') XML7_CV130Sort: MatSort;
  @ViewChild('XML7_CV130Paginator') XML7_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML7_CV130Service: XML7_CV130Service,
  ) { }

  ngOnInit(): void {
      this.KhoiTao();
      this.XML7_CV130Search();
    }
    KhoiTao() {
      this.XML7_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
      this.XML7_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
    }
    XML7_CV130Search() {
      this.XML7_CV130Service.IsShowLoading = true;
      this.XML7_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
        res => {
          this.XML7_CV130Service.List = (res as XML7_CV130[]).sort((a, b) => (a.NGAY_CT > b.NGAY_CT ? 1 : -1));
          this.XML7_CV130Service.DataSource = new MatTableDataSource(this.XML7_CV130Service.List);
          this.XML7_CV130Service.DataSource.sort = this.XML7_CV130Sort;
          this.XML7_CV130Service.DataSource.paginator = this.XML7_CV130Paginator;
          this.XML7_CV130Service.IsShowLoading = false;
        },
        err => {
        },
        () => {
        }
      );
    }
  XML7_CV130Save(element: XML7_CV130) {
    this.XML7_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML7_CV130Service.ComponentSaveAll(this.XML7_CV130Sort, this.XML7_CV130Paginator));
  }
  XML7_CV130Delete(element: XML7_CV130) {
    this.XML7_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML7_CV130Service.ComponentDeleteAll(this.XML7_CV130Sort, this.XML7_CV130Paginator));
  }
}