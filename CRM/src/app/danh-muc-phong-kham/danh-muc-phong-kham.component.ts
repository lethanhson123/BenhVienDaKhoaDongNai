import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucPhongKham } from 'src/app/shared/DanhMucPhongKham.model';
import { DanhMucPhongKhamService } from 'src/app/shared/DanhMucPhongKham.service';

import { DanhMucKhuVuc } from 'src/app/shared/DanhMucKhuVuc.model';
import { DanhMucKhuVucService } from 'src/app/shared/DanhMucKhuVuc.service';

import { DanhMucKhoaChuyenMon } from 'src/app/shared/DanhMucKhoaChuyenMon.model';
import { DanhMucKhoaChuyenMonService } from 'src/app/shared/DanhMucKhoaChuyenMon.service';

@Component({
  selector: 'app-danh-muc-phong-kham',
  templateUrl: './danh-muc-phong-kham.component.html',
  styleUrls: ['./danh-muc-phong-kham.component.css']
})
export class DanhMucPhongKhamComponent implements OnInit {

  @ViewChild('DanhMucPhongKhamSort') DanhMucPhongKhamSort: MatSort;
  @ViewChild('DanhMucPhongKhamPaginator') DanhMucPhongKhamPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucPhongKhamService: DanhMucPhongKhamService,
    public DanhMucKhuVucService: DanhMucKhuVucService,
    public DanhMucKhoaChuyenMonService: DanhMucKhoaChuyenMonService,
  ) { }

  ngOnInit(): void { 
    
  }
  ngAfterViewInit() {
    this.DanhMucKhuVucSearch();
    this.DanhMucKhoaChuyenMonSearch();
    this.DanhMucPhongKhamSearch();
  }
  DanhMucKhuVucSearch() {
    this.DanhMucKhuVucService.ComponentGetAllToListAsync(this.DanhMucPhongKhamService);
  }
  DanhMucKhoaChuyenMonSearch() {
    this.DanhMucKhoaChuyenMonService.ComponentGetAllToListAsync(this.DanhMucPhongKhamService);
  }

  DanhMucPhongKhamSearch() {
    this.DanhMucPhongKhamService.SearchAll(this.DanhMucPhongKhamSort, this.DanhMucPhongKhamPaginator);
  }
  DanhMucPhongKhamSave(element: DanhMucPhongKham) {
    this.DanhMucPhongKhamService.FormData = element;
    this.NotificationService.warn(this.DanhMucPhongKhamService.ComponentSaveAll(this.DanhMucPhongKhamSort, this.DanhMucPhongKhamPaginator));
  }
  DanhMucPhongKhamDelete(element: DanhMucPhongKham) {
    this.DanhMucPhongKhamService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucPhongKhamService.ComponentDeleteAll(this.DanhMucPhongKhamSort, this.DanhMucPhongKhamPaginator));
  }  
}