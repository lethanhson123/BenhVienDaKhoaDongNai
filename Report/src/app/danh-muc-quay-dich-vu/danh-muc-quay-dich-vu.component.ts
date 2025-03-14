import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucMauSac } from 'src/app/shared/DanhMucMauSac.model';
import { DanhMucMauSacService } from 'src/app/shared/DanhMucMauSac.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { DanhMucKhuVuc } from 'src/app/shared/DanhMucKhuVuc.model';
import { DanhMucKhuVucService } from 'src/app/shared/DanhMucKhuVuc.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

@Component({
  selector: 'app-danh-muc-quay-dich-vu',
  templateUrl: './danh-muc-quay-dich-vu.component.html',
  styleUrls: ['./danh-muc-quay-dich-vu.component.css']
})
export class DanhMucQuayDichVuComponent implements OnInit {

  @ViewChild('DanhMucQuayDichVuSort') DanhMucQuayDichVuSort: MatSort;
  @ViewChild('DanhMucQuayDichVuPaginator') DanhMucQuayDichVuPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public DanhMucKhuVucService: DanhMucKhuVucService,
    public DanhMucDichVuService: DanhMucDichVuService,
    public DanhMucMauSacService: DanhMucMauSacService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.DanhMucKhuVucSearch();
    this.DanhMucDichVuSearch();
    this.DanhMucMauSacSearch();
    this.DanhMucQuayDichVuSearch();
  }
  DanhMucKhuVucSearch() {
    this.DanhMucKhuVucService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }
  DanhMucDichVuSearch() {
    this.DanhMucDichVuService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }
  DanhMucMauSacSearch() {
    this.DanhMucMauSacService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }

  DanhMucQuayDichVuSearch() {
    this.DanhMucQuayDichVuService.SearchAll(this.DanhMucQuayDichVuSort, this.DanhMucQuayDichVuPaginator);
  }
  DanhMucQuayDichVuSave(element: DanhMucQuayDichVu) {
    this.DanhMucQuayDichVuService.FormData = element;
    this.NotificationService.warn(this.DanhMucQuayDichVuService.ComponentSaveAll(this.DanhMucQuayDichVuSort, this.DanhMucQuayDichVuPaginator));
  }
  DanhMucQuayDichVuDelete(element: DanhMucQuayDichVu) {
    this.DanhMucQuayDichVuService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucQuayDichVuService.ComponentDeleteAll(this.DanhMucQuayDichVuSort, this.DanhMucQuayDichVuPaginator));
  }
  DanhMucQuayDichVuKhoiPhuc() {
    this.DanhMucQuayDichVuService.IsShowLoading = true;
    this.DanhMucQuayDichVuService.KhoiPhucAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.List = (res as DanhMucQuayDichVu[]);
        this.DanhMucQuayDichVuService.DataSource = new MatTableDataSource(this.DanhMucQuayDichVuService.List);
        this.DanhMucQuayDichVuService.DataSource.sort = this.DanhMucQuayDichVuSort;
        this.DanhMucQuayDichVuService.DataSource.paginator = this.DanhMucQuayDichVuPaginator;
      },
      err => {
      },
      () => {
        this.DanhMucQuayDichVuService.IsShowLoading = false;
      }
    );
  }
  DanhMucQuayDichVuSaveList() {
    this.DanhMucQuayDichVuService.IsShowLoading = true;    
    this.DanhMucQuayDichVuService.SaveListAsync(this.DanhMucQuayDichVuService.List).subscribe(
      res => {
        this.DanhMucQuayDichVuSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucQuayDichVuService.IsShowLoading = false;
      }
    );
  }
}