import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { XML15_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML15_CV130.model';
import { XML15_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML15_CV130.service';

@Component({
  selector: 'app-xml15-cv130',
  templateUrl: './xml15-cv130.component.html',
  styleUrls: ['./xml15-cv130.component.css']
})
export class XML15CV130Component implements OnInit {

  @ViewChild('XML15_CV130Sort') XML15_CV130Sort: MatSort;
  @ViewChild('XML15_CV130Paginator') XML15_CV130Paginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML15_CV130Service: XML15_CV130Service,
  ) { }

 ngOnInit(): void {
     this.KhoiTao();
     this.XML15_CV130Search();
   }
   KhoiTao() {
     this.XML15_CV130Service.BaseParameter.ListYear = this.DownloadService.ListYear();
     this.XML15_CV130Service.BaseParameter.ListMonth = this.DownloadService.ListMonth();
   }
   XML15_CV130Search() {
     this.XML15_CV130Service.IsShowLoading = true;
     this.XML15_CV130Service.GetByYear_Month_SearchStringToListAsync().subscribe(
       res => {
         this.XML15_CV130Service.List = (res as XML15_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
         this.XML15_CV130Service.DataSource = new MatTableDataSource(this.XML15_CV130Service.List);
         this.XML15_CV130Service.DataSource.sort = this.XML15_CV130Sort;
         this.XML15_CV130Service.DataSource.paginator = this.XML15_CV130Paginator;
         this.XML15_CV130Service.IsShowLoading = false;
       },
       err => {
       },
       () => {
       }
     );
   }
  XML15_CV130Save(element: XML15_CV130) {
    this.XML15_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML15_CV130Service.ComponentSaveAll(this.XML15_CV130Sort, this.XML15_CV130Paginator));
  }
  XML15_CV130Delete(element: XML15_CV130) {
    this.XML15_CV130Service.FormData = element;
    this.NotificationService.warn(this.XML15_CV130Service.ComponentDeleteAll(this.XML15_CV130Sort, this.XML15_CV130Paginator));
  }
}
