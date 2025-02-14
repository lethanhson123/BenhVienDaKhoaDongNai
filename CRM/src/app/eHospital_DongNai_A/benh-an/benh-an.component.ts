import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { BenhAn } from 'src/app/shared/eHospital_DongNai_A/BenhAn.model';
import { BenhAnService } from 'src/app/shared/eHospital_DongNai_A/BenhAn.service';


@Component({
  selector: 'app-benh-an',
  templateUrl: './benh-an.component.html',
  styleUrls: ['./benh-an.component.css']
})
export class BenhAnComponent implements OnInit {

  @ViewChild('BenhAnSort') BenhAnSort: MatSort;
  @ViewChild('BenhAnPaginator') BenhAnPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public BenhAnService: BenhAnService,   
  ) { }

  ngOnInit(): void {
    this.BenhAnService.BaseParameter.BatDau = new Date();
    
  }
  DateBatDau(value) {
    this.BenhAnService.BaseParameter.BatDau = new Date(value);
  }
  
  BenhAnSearch() {
    if (this.BenhAnService.BaseParameter.IsSearchAPI == true) {
      this.BenhAnService.IsShowLoading = true;
      this.BenhAnService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.BenhAnService.List = (res as BenhAn[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.BenhAnService.RenderToListTransfer(this.BenhAnSort, this.BenhAnPaginator);        
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.BenhAnService.BaseParameter.SearchString = this.BenhAnService.BaseParameter.SearchString.trim();
      if (this.BenhAnService.DataSource) {
        this.BenhAnService.DataSource.filter = this.BenhAnService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  BenhAnSave(element: BenhAn) {
  }
  BenhAnDelete(element: BenhAn) {
  }
}