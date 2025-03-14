import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML6_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML6_CV130.model';
import { XML6_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML6_CV130.service';

@Component({
  selector: 'app-xml6-cv130',
  templateUrl: './xml6-cv130.component.html',
  styleUrls: ['./xml6-cv130.component.css']
})
export class XML6CV130Component implements OnInit {

  @ViewChild('XML6_CV130Sort') XML6_CV130Sort: MatSort;
  @ViewChild('XML6_CV130Paginator') XML6_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML6_CV130Service: XML6_CV130Service,
  ) { }

  ngOnInit(): void {
      this.KhoiTao();
      this.XML6_CV130Search();
    }
    KhoiTao() {
      this.XML6_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
      this.XML6_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
    }
    XML6_CV130Search() {
      this.XML6_CV130Service.IsShowLoading = true;
      this.XML6_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
        res => {
          this.XML6_CV130Service.List = (res as XML6_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
          this.XML6_CV130Service.DataSource = new MatTableDataSource(this.XML6_CV130Service.List);
          this.XML6_CV130Service.DataSource.sort = this.XML6_CV130Sort;
          this.XML6_CV130Service.DataSource.paginator = this.XML6_CV130Paginator;
          this.XML6_CV130Service.IsShowLoading = false;
        },
        err => {
        },
        () => {
        }
      );
    }
  XML6_CV130Save(element: XML6_CV130) {
    this.XML6_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML6_CV130Service.ComponentSaveAll(this.XML6_CV130Sort, this.XML6_CV130Paginator));
  }
  XML6_CV130Delete(element: XML6_CV130) {
    this.XML6_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML6_CV130Service.ComponentDeleteAll(this.XML6_CV130Sort, this.XML6_CV130Paginator));
  }
}