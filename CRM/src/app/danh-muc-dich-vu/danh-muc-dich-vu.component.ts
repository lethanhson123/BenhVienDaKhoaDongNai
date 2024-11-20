import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

@Component({
  selector: 'app-danh-muc-dich-vu',
  templateUrl: './danh-muc-dich-vu.component.html',
  styleUrls: ['./danh-muc-dich-vu.component.css']
})
export class DanhMucDichVuComponent implements OnInit {

  @ViewChild('DanhMucDichVuSort') DanhMucDichVuSort: MatSort;
  @ViewChild('DanhMucDichVuPaginator') DanhMucDichVuPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucDichVuSearch();
  }

  DanhMucDichVuSearch() {
    this.DanhMucDichVuService.SearchAll(this.DanhMucDichVuSort, this.DanhMucDichVuPaginator);
  }
  DanhMucDichVuSave(element: DanhMucDichVu) {
    this.DanhMucDichVuService.FormData = element;
    this.NotificationService.warn(this.DanhMucDichVuService.ComponentSaveAll(this.DanhMucDichVuSort, this.DanhMucDichVuPaginator));
  }
  DanhMucDichVuDelete(element: DanhMucDichVu) {
    this.DanhMucDichVuService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucDichVuService.ComponentDeleteAll(this.DanhMucDichVuSort, this.DanhMucDichVuPaginator));
  }  
}