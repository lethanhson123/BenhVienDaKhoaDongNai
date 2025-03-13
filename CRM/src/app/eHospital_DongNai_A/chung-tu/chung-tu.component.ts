import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ChungTu } from 'src/app/shared/eHospital_DongNai_A/ChungTu.model';
import { ChungTuService } from 'src/app/shared/eHospital_DongNai_A/ChungTu.service';
@Component({
  selector: 'app-chung-tu',
  templateUrl: './chung-tu.component.html',
  styleUrls: ['./chung-tu.component.css']
})
export class ChungTuComponent implements OnInit {

  @ViewChild('ChungTuSort') ChungTuSort: MatSort;
  @ViewChild('ChungTuPaginator') ChungTuPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ChungTuService: ChungTuService,
  ) { }

  ngOnInit(): void {
    this.ChungTuService.BaseParameter.BatDau = new Date();
  }
  ngAfterViewInit() {
    this.ChungTuService.BaseParameter.BatDau = new Date();
  }
  DateBatDau(value) {
    this.ChungTuService.BaseParameter.BatDau = new Date(value);
  }
  ChungTuSearch() {
    if (this.ChungTuService.BaseParameter.IsSearchAPI == true) {
      this.ChungTuService.IsShowLoading = true;
      this.ChungTuService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.ChungTuService.List = (res as ChungTu[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.ChungTuService.RenderToListTransfer(this.ChungTuSort, this.ChungTuPaginator);
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.ChungTuService.BaseParameter.SearchString = this.ChungTuService.BaseParameter.SearchString.trim();
      if (this.ChungTuService.DataSource) {
        this.ChungTuService.DataSource.filter = this.ChungTuService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  ChungTuSave(element: ChungTu) {
    this.ChungTuService.FormData = element;
    this.NotificationService.warn(this.ChungTuService.ComponentSaveAll(this.ChungTuSort, this.ChungTuPaginator));
  }
  ChungTuDelete(element: ChungTu) {
    this.ChungTuService.FormData = element;
    this.NotificationService.warn(this.ChungTuService.ComponentDeleteAll(this.ChungTuSort, this.ChungTuPaginator));
  }
}
