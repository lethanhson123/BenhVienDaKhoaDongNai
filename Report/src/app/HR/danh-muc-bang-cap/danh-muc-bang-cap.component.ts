import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucBangCap } from 'src/app/shared/DanhMucBangCap.model';
import { DanhMucBangCapService } from 'src/app/shared/DanhMucBangCap.service';

@Component({
  selector: 'app-danh-muc-bang-cap',
  templateUrl: './danh-muc-bang-cap.component.html',
  styleUrls: ['./danh-muc-bang-cap.component.css']
})
export class DanhMucBangCapComponent implements OnInit {

  @ViewChild('DanhMucBangCapSort') DanhMucBangCapSort: MatSort;
  @ViewChild('DanhMucBangCapPaginator') DanhMucBangCapPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucBangCapService: DanhMucBangCapService,
  ) { }

  ngOnInit(): void {
    this.DanhMucBangCapSearch();
  }

  DanhMucBangCapSearch() {
    this.DanhMucBangCapService.SearchAll(this.DanhMucBangCapSort, this.DanhMucBangCapPaginator);
  }
  DanhMucBangCapSave(element: DanhMucBangCap) {
    this.DanhMucBangCapService.FormData = element;
    this.NotificationService.warn(this.DanhMucBangCapService.ComponentSaveAll(this.DanhMucBangCapSort, this.DanhMucBangCapPaginator));
  }
  DanhMucBangCapDelete(element: DanhMucBangCap) {
    this.DanhMucBangCapService.FormData = element;
    this.NotificationService.warn(this.DanhMucBangCapService.ComponentDeleteAll(this.DanhMucBangCapSort, this.DanhMucBangCapPaginator));
  }
}