import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML11_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML11_CV130.model';
import { XML11_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML11_CV130.service';

@Component({
  selector: 'app-xml11-cv130',
  templateUrl: './xml11-cv130.component.html',
  styleUrls: ['./xml11-cv130.component.css']
})
export class XML11CV130Component implements OnInit {

  @ViewChild('XML11_CV130Sort') XML11_CV130Sort: MatSort;
  @ViewChild('XML11_CV130Paginator') XML11_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML11_CV130Service: XML11_CV130Service,
  ) { }

 ngOnInit(): void {
     this.KhoiTao();
     this.XML11_CV130Search();
   }
   KhoiTao() {
     this.XML11_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
     this.XML11_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
   }
   XML11_CV130Search() {
     this.XML11_CV130Service.IsShowLoading = true;
     this.XML11_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
       res => {
         this.XML11_CV130Service.List = (res as XML11_CV130[]).sort((a, b) => (a.NGAY_CT > b.NGAY_CT ? 1 : -1));
         this.XML11_CV130Service.DataSource = new MatTableDataSource(this.XML11_CV130Service.List);
         this.XML11_CV130Service.DataSource.sort = this.XML11_CV130Sort;
         this.XML11_CV130Service.DataSource.paginator = this.XML11_CV130Paginator;
         this.XML11_CV130Service.IsShowLoading = false;
       },
       err => {
       },
       () => {
       }
     );
   }
  XML11_CV130Save(element: XML11_CV130) {
    this.XML11_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML11_CV130Service.ComponentSaveAll(this.XML11_CV130Sort, this.XML11_CV130Paginator));
  }
  XML11_CV130Delete(element: XML11_CV130) {
    this.XML11_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML11_CV130Service.ComponentDeleteAll(this.XML11_CV130Sort, this.XML11_CV130Paginator));
  }
}