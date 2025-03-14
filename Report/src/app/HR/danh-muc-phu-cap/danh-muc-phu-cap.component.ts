import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucPhuCap } from 'src/app/shared/DanhMucPhuCap.model';
import { DanhMucPhuCapService } from 'src/app/shared/DanhMucPhuCap.service';

@Component({
  selector: 'app-danh-muc-phu-cap',
  templateUrl: './danh-muc-phu-cap.component.html',
  styleUrls: ['./danh-muc-phu-cap.component.css']
})
export class DanhMucPhuCapComponent implements OnInit {

  @ViewChild('DanhMucPhuCapSort') DanhMucPhuCapSort: MatSort;
  @ViewChild('DanhMucPhuCapPaginator') DanhMucPhuCapPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucPhuCapService: DanhMucPhuCapService,
  ) { }

  ngOnInit(): void {
    this.DanhMucPhuCapSearch();
  }

  DanhMucPhuCapSearch() {
    this.DanhMucPhuCapService.SearchAll(this.DanhMucPhuCapSort, this.DanhMucPhuCapPaginator);
  }
  DanhMucPhuCapSave(element: DanhMucPhuCap) {
    this.DanhMucPhuCapService.FormData = element;
    this.NotificationService.warn(this.DanhMucPhuCapService.ComponentSaveAll(this.DanhMucPhuCapSort, this.DanhMucPhuCapPaginator));
  }
  DanhMucPhuCapDelete(element: DanhMucPhuCap) {
    this.DanhMucPhuCapService.FormData = element;
    this.NotificationService.warn(this.DanhMucPhuCapService.ComponentDeleteAll(this.DanhMucPhuCapSort, this.DanhMucPhuCapPaginator));
  }
}