import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML12_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML12_CV130.model';
import { XML12_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML12_CV130.service';

@Component({
  selector: 'app-xml12-cv130',
  templateUrl: './xml12-cv130.component.html',
  styleUrls: ['./xml12-cv130.component.css']
})
export class XML12CV130Component implements OnInit {

  @ViewChild('XML12_CV130Sort') XML12_CV130Sort: MatSort;
  @ViewChild('XML12_CV130Paginator') XML12_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML12_CV130Service: XML12_CV130Service,
  ) { }

  ngOnInit(): void {
      this.KhoiTao();
      this.XML12_CV130Search();
    }
    KhoiTao() {
      this.XML12_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
      this.XML12_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
    }
    XML12_CV130Search() {
      this.XML12_CV130Service.IsShowLoading = true;
      this.XML12_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
        res => {
          this.XML12_CV130Service.List = (res as XML12_CV130[]).sort((a, b) => (a.NGAY_CHUNG_TU > b.NGAY_CHUNG_TU ? 1 : -1));
          this.XML12_CV130Service.DataSource = new MatTableDataSource(this.XML12_CV130Service.List);
          this.XML12_CV130Service.DataSource.sort = this.XML12_CV130Sort;
          this.XML12_CV130Service.DataSource.paginator = this.XML12_CV130Paginator;
          this.XML12_CV130Service.IsShowLoading = false;
        },
        err => {
        },
        () => {
        }
      );
    }
  XML12_CV130Save(element: XML12_CV130) {
    this.XML12_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML12_CV130Service.ComponentSaveAll(this.XML12_CV130Sort, this.XML12_CV130Paginator));
  }
  XML12_CV130Delete(element: XML12_CV130) {
    this.XML12_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML12_CV130Service.ComponentDeleteAll(this.XML12_CV130Sort, this.XML12_CV130Paginator));
  }
}
