import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucChuyenNganh } from 'src/app/shared/DanhMucChuyenNganh.model';
import { DanhMucChuyenNganhService } from 'src/app/shared/DanhMucChuyenNganh.service';

@Component({
  selector: 'app-danh-muc-chuyen-nganh',
  templateUrl: './danh-muc-chuyen-nganh.component.html',
  styleUrls: ['./danh-muc-chuyen-nganh.component.css']
})
export class DanhMucChuyenNganhComponent implements OnInit {

   @ViewChild('DanhMucChuyenNganhSort') DanhMucChuyenNganhSort: MatSort;
    @ViewChild('DanhMucChuyenNganhPaginator') DanhMucChuyenNganhPaginator: MatPaginator;
  
    constructor(
      public NotificationService: NotificationService,
      public DownloadService: DownloadService,
  
      public DanhMucChuyenNganhService: DanhMucChuyenNganhService,
    ) { }
  
    ngOnInit(): void {
      this.DanhMucChuyenNganhSearch();
    }
  
    DanhMucChuyenNganhSearch() {
      this.DanhMucChuyenNganhService.SearchAll(this.DanhMucChuyenNganhSort, this.DanhMucChuyenNganhPaginator);
    }
    DanhMucChuyenNganhSave(element: DanhMucChuyenNganh) {
      this.DanhMucChuyenNganhService.FormData = element;
      this.NotificationService.warn(this.DanhMucChuyenNganhService.ComponentSaveAll(this.DanhMucChuyenNganhSort, this.DanhMucChuyenNganhPaginator));
    }
    DanhMucChuyenNganhDelete(element: DanhMucChuyenNganh) {
      this.DanhMucChuyenNganhService.FormData = element;
      this.NotificationService.warn(this.DanhMucChuyenNganhService.ComponentDeleteAll(this.DanhMucChuyenNganhSort, this.DanhMucChuyenNganhPaginator));
    }
  }