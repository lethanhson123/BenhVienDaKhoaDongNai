import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucHopDong } from 'src/app/shared/DanhMucHopDong.model';
import { DanhMucHopDongService } from 'src/app/shared/DanhMucHopDong.service';

@Component({
  selector: 'app-danh-muc-hop-dong',
  templateUrl: './danh-muc-hop-dong.component.html',
  styleUrls: ['./danh-muc-hop-dong.component.css']
})
export class DanhMucHopDongComponent implements OnInit {

  @ViewChild('DanhMucHopDongSort') DanhMucHopDongSort: MatSort;
  @ViewChild('DanhMucHopDongPaginator') DanhMucHopDongPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucHopDongService: DanhMucHopDongService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.DanhMucHopDongSearch();
  }
  DanhMucHopDongSearch() {
    this.DanhMucHopDongService.SearchAllNotEmpty(this.DanhMucHopDongSort, this.DanhMucHopDongPaginator);
  }
  DanhMucHopDongSave(element: DanhMucHopDong) {
    this.DanhMucHopDongService.FormData = element;
    this.NotificationService.warn(this.DanhMucHopDongService.ComponentSaveAllNotEmpty(this.DanhMucHopDongSort, this.DanhMucHopDongPaginator));
  }
  DanhMucHopDongDelete(element: DanhMucHopDong) {
    this.DanhMucHopDongService.FormData = element;
    this.NotificationService.warn(this.DanhMucHopDongService.ComponentDeleteAllNotEmpty(this.DanhMucHopDongSort, this.DanhMucHopDongPaginator));
  }
}