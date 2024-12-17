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
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';

@Component({
  selector: 'app-danh-muc-xa-phuong',
  templateUrl: './danh-muc-xa-phuong.component.html',
  styleUrls: ['./danh-muc-xa-phuong.component.css']
})
export class DanhMucXaPhuongComponent implements OnInit {

  @ViewChild('DanhMucXaPhuongSort') DanhMucXaPhuongSort: MatSort;
  @ViewChild('DanhMucXaPhuongPaginator') DanhMucXaPhuongPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucTinhThanhSearch();
    this.DanhMucQuanHuyenSearch();
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.ComponentGetAllToListAsync(this.DanhMucQuanHuyenService);
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.ComponentGetByParentIDToListAsync(this.DanhMucQuanHuyenService);
  }
  DanhMucXaPhuongSearch() {
    this.DanhMucXaPhuongService.SearchByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService);   
  }
  DanhMucXaPhuongSave(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.FormData = element;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentSaveByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService));
  }
  DanhMucXaPhuongDelete(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentDeleteByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService));
  }  
}