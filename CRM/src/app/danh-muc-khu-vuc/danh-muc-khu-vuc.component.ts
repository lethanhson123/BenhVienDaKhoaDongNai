import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucKhuVuc } from 'src/app/shared/DanhMucKhuVuc.model';
import { DanhMucKhuVucService } from 'src/app/shared/DanhMucKhuVuc.service';

@Component({
  selector: 'app-danh-muc-khu-vuc',
  templateUrl: './danh-muc-khu-vuc.component.html',
  styleUrls: ['./danh-muc-khu-vuc.component.css']
})
export class DanhMucKhuVucComponent implements OnInit {

  @ViewChild('DanhMucKhuVucSort') DanhMucKhuVucSort: MatSort;
  @ViewChild('DanhMucKhuVucPaginator') DanhMucKhuVucPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucKhuVucService: DanhMucKhuVucService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucKhuVucSearch();
  }

  DanhMucKhuVucSearch() {
    this.DanhMucKhuVucService.SearchAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator);
  }
  DanhMucKhuVucSave(element: DanhMucKhuVuc) {
    this.DanhMucKhuVucService.FormData = element;
    this.NotificationService.warn(this.DanhMucKhuVucService.ComponentSaveAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator));
  }
  DanhMucKhuVucDelete(element: DanhMucKhuVuc) {
    this.DanhMucKhuVucService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucKhuVucService.ComponentDeleteAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator));
  }  
}