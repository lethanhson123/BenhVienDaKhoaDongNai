import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML13_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML13_CV130.model';
import { XML13_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML13_CV130.service';

@Component({
  selector: 'app-xml13-cv130',
  templateUrl: './xml13-cv130.component.html',
  styleUrls: ['./xml13-cv130.component.css']
})
export class XML13CV130Component implements OnInit {

  @ViewChild('XML13_CV130Sort') XML13_CV130Sort: MatSort;
  @ViewChild('XML13_CV130Paginator') XML13_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML13_CV130Service: XML13_CV130Service,
  ) { }

  ngOnInit(): void {
      this.KhoiTao();
      this.XML13_CV130Search();
    }
    KhoiTao() {
      this.XML13_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
      this.XML13_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
    }
    XML13_CV130Search() {
      this.XML13_CV130Service.IsShowLoading = true;
      this.XML13_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
        res => {
          this.XML13_CV130Service.List = (res as XML13_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
          this.XML13_CV130Service.DataSource = new MatTableDataSource(this.XML13_CV130Service.List);
          this.XML13_CV130Service.DataSource.sort = this.XML13_CV130Sort;
          this.XML13_CV130Service.DataSource.paginator = this.XML13_CV130Paginator;
          this.XML13_CV130Service.IsShowLoading = false;
        },
        err => {
        },
        () => {
        }
      );
    }
  XML13_CV130Save(element: XML13_CV130) {
    this.XML13_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML13_CV130Service.ComponentSaveAll(this.XML13_CV130Sort, this.XML13_CV130Paginator));
  }
  XML13_CV130Delete(element: XML13_CV130) {
    this.XML13_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML13_CV130Service.ComponentDeleteAll(this.XML13_CV130Sort, this.XML13_CV130Paginator));
  }
}
