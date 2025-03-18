import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucChucVu } from 'src/app/shared/DanhMucChucVu.model';
import { DanhMucChucVuService } from 'src/app/shared/DanhMucChucVu.service';
@Component({
  selector: 'app-danh-muc-chuc-vu',
  templateUrl: './danh-muc-chuc-vu.component.html',
  styleUrls: ['./danh-muc-chuc-vu.component.css']
})
export class DanhMucChucVuComponent implements OnInit {

  @ViewChild('DanhMucChucVuSort') DanhMucChucVuSort: MatSort;
  @ViewChild('DanhMucChucVuPaginator') DanhMucChucVuPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucChucVuService: DanhMucChucVuService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.DanhMucChucVuSearch();
  }  
  DanhMucChucVuSearch() {
    this.DanhMucChucVuService.SearchAll(this.DanhMucChucVuSort, this.DanhMucChucVuPaginator);
  }
  DanhMucChucVuSave(element: DanhMucChucVu) {
    this.DanhMucChucVuService.FormData = element;
    this.NotificationService.warn(this.DanhMucChucVuService.ComponentSaveAll(this.DanhMucChucVuSort, this.DanhMucChucVuPaginator));
  }
  DanhMucChucVuDelete(element: DanhMucChucVu) {
    this.DanhMucChucVuService.FormData = element;
    this.NotificationService.warn(this.DanhMucChucVuService.ComponentDeleteAll(this.DanhMucChucVuSort, this.DanhMucChucVuPaginator));
  }
}