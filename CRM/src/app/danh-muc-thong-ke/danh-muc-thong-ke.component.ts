import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucThongKe } from 'src/app/shared/DanhMucThongKe.model';
import { DanhMucThongKeService } from 'src/app/shared/DanhMucThongKe.service';

@Component({
  selector: 'app-danh-muc-thong-ke',
  templateUrl: './danh-muc-thong-ke.component.html',
  styleUrls: ['./danh-muc-thong-ke.component.css']
})
export class DanhMucThongKeComponent implements OnInit {

  @ViewChild('DanhMucThongKeSort') DanhMucThongKeSort: MatSort;
  @ViewChild('DanhMucThongKePaginator') DanhMucThongKePaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucThongKeService: DanhMucThongKeService,
  ) { }

  ngOnInit(): void {
    this.DanhMucThongKeSearch();
  }

  DanhMucThongKeSearch() {
    this.DanhMucThongKeService.SearchAll(this.DanhMucThongKeSort, this.DanhMucThongKePaginator);
  }
  DanhMucThongKeSave(element: DanhMucThongKe) {
    this.DanhMucThongKeService.FormData = element;
    this.NotificationService.warn(this.DanhMucThongKeService.ComponentSaveAll(this.DanhMucThongKeSort, this.DanhMucThongKePaginator));
  }
  DanhMucThongKeDelete(element: DanhMucThongKe) {
    this.DanhMucThongKeService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucThongKeService.ComponentDeleteAll(this.DanhMucThongKeSort, this.DanhMucThongKePaginator));
  }
  
  DanhMucThongKeSaveList() {
    this.DanhMucThongKeService.IsShowLoading = true;
    this.DanhMucThongKeService.ListFilter = this.DanhMucThongKeService.List.filter(item => item.ID > 0);    
    this.DanhMucThongKeService.SaveListAsync(this.DanhMucThongKeService.ListFilter).subscribe(
      res => {
        this.DanhMucThongKeSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucThongKeService.IsShowLoading = false;
      }
    );
  }
}