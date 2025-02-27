import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TiepNhan } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.model';
import { TiepNhanService } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.service';
@Component({
  selector: 'app-tiep-nhan',
  templateUrl: './tiep-nhan.component.html',
  styleUrls: ['./tiep-nhan.component.css']
})
export class TiepNhanComponent implements OnInit {

  @ViewChild('TiepNhanSort') TiepNhanSort: MatSort;
  @ViewChild('TiepNhanPaginator') TiepNhanPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TiepNhanService: TiepNhanService,   
  ) { }

  ngOnInit(): void {
    this.TiepNhanService.BaseParameter.BatDau = new Date();   
  }
  DateBatDau(value) {
    this.TiepNhanService.BaseParameter.BatDau = new Date(value);
  } 
  TiepNhanSearch() {
    if (this.TiepNhanService.BaseParameter.IsSearchAPI == true) {
      this.TiepNhanService.IsShowLoading = true;
      this.TiepNhanService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.TiepNhanService.List = (res as TiepNhan[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.TiepNhanService.RenderToListTransfer(this.TiepNhanSort, this.TiepNhanPaginator);

        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.TiepNhanService.BaseParameter.SearchString = this.TiepNhanService.BaseParameter.SearchString.trim();
      if (this.TiepNhanService.DataSource) {
        this.TiepNhanService.DataSource.filter = this.TiepNhanService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  TiepNhanSave(element: TiepNhan) {
    this.TiepNhanService.FormData = element;
    this.NotificationService.warn(this.TiepNhanService.ComponentSaveAll(this.TiepNhanSort, this.TiepNhanPaginator));
  }
  TiepNhanDelete(element: TiepNhan) {
    this.TiepNhanService.FormData = element;
    this.NotificationService.warn(this.TiepNhanService.ComponentDeleteAll(this.TiepNhanSort, this.TiepNhanPaginator));
  }
}
