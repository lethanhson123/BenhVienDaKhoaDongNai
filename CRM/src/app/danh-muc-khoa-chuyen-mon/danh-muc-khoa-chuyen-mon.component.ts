import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucKhoaChuyenMon } from 'src/app/shared/DanhMucKhoaChuyenMon.model';
import { DanhMucKhoaChuyenMonService } from 'src/app/shared/DanhMucKhoaChuyenMon.service';

@Component({
  selector: 'app-danh-muc-khoa-chuyen-mon',
  templateUrl: './danh-muc-khoa-chuyen-mon.component.html',
  styleUrls: ['./danh-muc-khoa-chuyen-mon.component.css']
})
export class DanhMucKhoaChuyenMonComponent implements OnInit {

  @ViewChild('DanhMucKhoaChuyenMonSort') DanhMucKhoaChuyenMonSort: MatSort;
  @ViewChild('DanhMucKhoaChuyenMonPaginator') DanhMucKhoaChuyenMonPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucKhoaChuyenMonService: DanhMucKhoaChuyenMonService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucKhoaChuyenMonSearch();
  }

  DanhMucKhoaChuyenMonSearch() {
    this.DanhMucKhoaChuyenMonService.SearchAll(this.DanhMucKhoaChuyenMonSort, this.DanhMucKhoaChuyenMonPaginator);
  }
  DanhMucKhoaChuyenMonSave(element: DanhMucKhoaChuyenMon) {
    this.DanhMucKhoaChuyenMonService.FormData = element;
    this.NotificationService.warn(this.DanhMucKhoaChuyenMonService.ComponentSaveAll(this.DanhMucKhoaChuyenMonSort, this.DanhMucKhoaChuyenMonPaginator));
  }
  DanhMucKhoaChuyenMonDelete(element: DanhMucKhoaChuyenMon) {
    this.DanhMucKhoaChuyenMonService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucKhoaChuyenMonService.ComponentDeleteAll(this.DanhMucKhoaChuyenMonSort, this.DanhMucKhoaChuyenMonPaginator));
  }  
}