import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucHinhThucThanhToan } from 'src/app/shared/DanhMucHinhThucThanhToan.model';
import { DanhMucHinhThucThanhToanService } from 'src/app/shared/DanhMucHinhThucThanhToan.service';

@Component({
  selector: 'app-danh-muc-hinh-thuc-thanh-toan',
  templateUrl: './danh-muc-hinh-thuc-thanh-toan.component.html',
  styleUrls: ['./danh-muc-hinh-thuc-thanh-toan.component.css']
})
export class DanhMucHinhThucThanhToanComponent implements OnInit {

  @ViewChild('DanhMucHinhThucThanhToanSort') DanhMucHinhThucThanhToanSort: MatSort;
  @ViewChild('DanhMucHinhThucThanhToanPaginator') DanhMucHinhThucThanhToanPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucHinhThucThanhToanService: DanhMucHinhThucThanhToanService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucHinhThucThanhToanSearch();
  }

  DanhMucHinhThucThanhToanSearch() {
    this.DanhMucHinhThucThanhToanService.SearchAll(this.DanhMucHinhThucThanhToanSort, this.DanhMucHinhThucThanhToanPaginator);
  }
  DanhMucHinhThucThanhToanSave(element: DanhMucHinhThucThanhToan) {
    this.DanhMucHinhThucThanhToanService.FormData = element;
    this.NotificationService.warn(this.DanhMucHinhThucThanhToanService.ComponentSaveAll(this.DanhMucHinhThucThanhToanSort, this.DanhMucHinhThucThanhToanPaginator));
  }
  DanhMucHinhThucThanhToanDelete(element: DanhMucHinhThucThanhToan) {
    this.DanhMucHinhThucThanhToanService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucHinhThucThanhToanService.ComponentDeleteAll(this.DanhMucHinhThucThanhToanSort, this.DanhMucHinhThucThanhToanPaginator));
  }  
}