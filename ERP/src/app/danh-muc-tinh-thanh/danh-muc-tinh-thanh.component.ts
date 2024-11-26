import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';

@Component({
  selector: 'app-danh-muc-tinh-thanh',
  templateUrl: './danh-muc-tinh-thanh.component.html',
  styleUrls: ['./danh-muc-tinh-thanh.component.css']
})
export class DanhMucTinhThanhComponent implements OnInit {

  @ViewChild('DanhMucTinhThanhSort') DanhMucTinhThanhSort: MatSort;
  @ViewChild('DanhMucTinhThanhPaginator') DanhMucTinhThanhPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucTinhThanhSearch();
  }

  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.SearchAll(this.DanhMucTinhThanhSort, this.DanhMucTinhThanhPaginator);
  }
  DanhMucTinhThanhSave(element: DanhMucTinhThanh) {
    this.DanhMucTinhThanhService.FormData = element;
    this.NotificationService.warn(this.DanhMucTinhThanhService.ComponentSaveAll(this.DanhMucTinhThanhSort, this.DanhMucTinhThanhPaginator));
  }
  DanhMucTinhThanhDelete(element: DanhMucTinhThanh) {
    this.DanhMucTinhThanhService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucTinhThanhService.ComponentDeleteAll(this.DanhMucTinhThanhSort, this.DanhMucTinhThanhPaginator));
  }  
}