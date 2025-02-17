import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML1_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML1_CV130.model';
import { XML1_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML1_CV130.service';

@Component({
  selector: 'app-xml1-cv130',
  templateUrl: './xml1-cv130.component.html',
  styleUrls: ['./xml1-cv130.component.css']
})
export class XML1CV130Component implements OnInit {

  @ViewChild('XML1_CV130Sort') XML1_CV130Sort: MatSort;
  @ViewChild('XML1_CV130Paginator') XML1_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML1_CV130Service: XML1_CV130Service,
  ) { }

  ngOnInit(): void {
    this.KhoiTao();
    this.XML1_CV130Search();
  }
  KhoiTao() {
    this.XML1_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
    this.XML1_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
  }
  XML1_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML1_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
      res => {
        this.XML1_CV130Service.List = (res as XML1_CV130[]).sort((a, b) => (a.NGAY_TTOAN > b.NGAY_TTOAN ? 1 : -1));
        this.XML1_CV130Service.DataSource = new MatTableDataSource(this.XML1_CV130Service.List);
        this.XML1_CV130Service.DataSource.sort = this.XML1_CV130Sort;
        this.XML1_CV130Service.DataSource.paginator = this.XML1_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML1_CV130Save(element: XML1_CV130) {
    this.XML1_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML1_CV130Service.ComponentSaveAll(this.XML1_CV130Sort, this.XML1_CV130Paginator));
  }
  XML1_CV130Delete(element: XML1_CV130) {
    this.XML1_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML1_CV130Service.ComponentDeleteAll(this.XML1_CV130Sort, this.XML1_CV130Paginator));
  }
}
