import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucTinhTrang } from 'src/app/shared/DanhMucTinhTrang.model';
import { DanhMucTinhTrangService } from 'src/app/shared/DanhMucTinhTrang.service';

@Component({
  selector: 'app-danh-muc-tinh-trang',
  templateUrl: './danh-muc-tinh-trang.component.html',
  styleUrls: ['./danh-muc-tinh-trang.component.css']
})
export class DanhMucTinhTrangComponent implements OnInit {

  @ViewChild('DanhMucTinhTrangSort') DanhMucTinhTrangSort: MatSort;
  @ViewChild('DanhMucTinhTrangPaginator') DanhMucTinhTrangPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhTrangService: DanhMucTinhTrangService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucTinhTrangSearch();
  }

  DanhMucTinhTrangSearch() {
    this.DanhMucTinhTrangService.SearchAll(this.DanhMucTinhTrangSort, this.DanhMucTinhTrangPaginator);
  }
  DanhMucTinhTrangSave(element: DanhMucTinhTrang) {
    this.DanhMucTinhTrangService.FormData = element;
    this.NotificationService.warn(this.DanhMucTinhTrangService.ComponentSaveAll(this.DanhMucTinhTrangSort, this.DanhMucTinhTrangPaginator));
  }
  DanhMucTinhTrangDelete(element: DanhMucTinhTrang) {
    this.DanhMucTinhTrangService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucTinhTrangService.ComponentDeleteAll(this.DanhMucTinhTrangSort, this.DanhMucTinhTrangPaginator));
  }  
}