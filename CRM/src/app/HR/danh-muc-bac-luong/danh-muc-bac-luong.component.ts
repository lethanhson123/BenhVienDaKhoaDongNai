import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucBacLuong } from 'src/app/shared/DanhMucBacLuong.model';
import { DanhMucBacLuongService } from 'src/app/shared/DanhMucBacLuong.service';

@Component({
  selector: 'app-danh-muc-bac-luong',
  templateUrl: './danh-muc-bac-luong.component.html',
  styleUrls: ['./danh-muc-bac-luong.component.css']
})
export class DanhMucBacLuongComponent implements OnInit {

  @ViewChild('DanhMucBacLuongSort') DanhMucBacLuongSort: MatSort;
  @ViewChild('DanhMucBacLuongPaginator') DanhMucBacLuongPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucBacLuongService: DanhMucBacLuongService,
  ) { }

  ngOnInit(): void {
    this.DanhMucBacLuongSearch();
  }

  DanhMucBacLuongSearch() {
    this.DanhMucBacLuongService.SearchAll(this.DanhMucBacLuongSort, this.DanhMucBacLuongPaginator);
  }
  DanhMucBacLuongSave(element: DanhMucBacLuong) {
    this.DanhMucBacLuongService.FormData = element;
    this.NotificationService.warn(this.DanhMucBacLuongService.ComponentSaveAll(this.DanhMucBacLuongSort, this.DanhMucBacLuongPaginator));
  }
  DanhMucBacLuongDelete(element: DanhMucBacLuong) {
    this.DanhMucBacLuongService.FormData = element;
    this.NotificationService.warn(this.DanhMucBacLuongService.ComponentDeleteAll(this.DanhMucBacLuongSort, this.DanhMucBacLuongPaginator));
  }
}