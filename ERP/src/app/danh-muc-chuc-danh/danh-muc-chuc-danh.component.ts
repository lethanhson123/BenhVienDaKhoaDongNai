import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucChucDanh } from 'src/app/shared/DanhMucChucDanh.model';
import { DanhMucChucDanhService } from 'src/app/shared/DanhMucChucDanh.service';


@Component({
  selector: 'app-danh-muc-chuc-danh',
  templateUrl: './danh-muc-chuc-danh.component.html',
  styleUrls: ['./danh-muc-chuc-danh.component.css']
})
export class DanhMucChucDanhComponent implements OnInit {

  @ViewChild('DanhMucChucDanhSort') DanhMucChucDanhSort: MatSort;
  @ViewChild('DanhMucChucDanhPaginator') DanhMucChucDanhPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucChucDanhService: DanhMucChucDanhService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucChucDanhSearch();
  }

  DanhMucChucDanhSearch() {
    this.DanhMucChucDanhService.SearchAll(this.DanhMucChucDanhSort, this.DanhMucChucDanhPaginator);
  }
  DanhMucChucDanhSave(element: DanhMucChucDanh) {
    this.DanhMucChucDanhService.FormData = element;
    this.NotificationService.warn(this.DanhMucChucDanhService.ComponentSaveAll(this.DanhMucChucDanhSort, this.DanhMucChucDanhPaginator));
  }
  DanhMucChucDanhDelete(element: DanhMucChucDanh) {
    this.DanhMucChucDanhService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucChucDanhService.ComponentDeleteAll(this.DanhMucChucDanhSort, this.DanhMucChucDanhPaginator));
  }  
}