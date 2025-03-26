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
  selector: 'app-danh-muc-quay-dich-vu-khoa-kham-benh',
  templateUrl: './danh-muc-quay-dich-vu-khoa-kham-benh.component.html',
  styleUrls: ['./danh-muc-quay-dich-vu-khoa-kham-benh.component.css']
})
export class DanhMucQuayDichVuKhoaKhamBenhComponent implements OnInit {

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
    this.DanhMucMauSacSearch();
    this.DanhMucDichVuSearch();   
    //this.DanhMucQuayDichVuSearch();
  }
  DanhMucKhuVucSearch() {
    this.DanhMucKhuVucService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }
  DanhMucDichVuSearch() {
    if (this.DanhMucDichVuService.List) {
      if (this.DanhMucDichVuService.List.length == 0) {
        this.DanhMucDichVuService.GetAllToListAsync().subscribe(
          res => {
            this.DanhMucDichVuService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
            this.DanhMucQuayDichVuSearch();
          },
          err => {
          },
          () => {
          }
        );
      }
      else {
      }
    }
    else {
    }
    this.DanhMucDichVuService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }
  DanhMucMauSacSearch() {
    this.DanhMucMauSacService.ComponentGetAllToListAsync(this.DanhMucQuayDichVuService);
  }

  DanhMucQuayDichVuSearch() {
    this.DanhMucQuayDichVuService.GetAllAndEmptyToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.List01 = (res as DanhMucQuayDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucDichVuService.ListFilter = this.DanhMucDichVuService.List.filter(item => item.GroupOrder == 1);

        this.DanhMucQuayDichVuService.List = [];
        this.DanhMucQuayDichVuService.List.push(this.DanhMucQuayDichVuService.List01.filter(item => item.ID == 0)[0]);
        for (let i = 0; i < this.DanhMucDichVuService.ListFilter.length; i++) {
          let ListDanhMucQuayDichVu = this.DanhMucQuayDichVuService.List01.filter(item => item.DanhMucDichVuID == this.DanhMucDichVuService.ListFilter[i].ID);
          for (let j = 0; j < ListDanhMucQuayDichVu.length; j++) {
            this.DanhMucQuayDichVuService.List.push(ListDanhMucQuayDichVu[j]);
          }
        }

        this.DanhMucQuayDichVuService.List=this.DanhMucQuayDichVuService.List.sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucQuayDichVuService.DataSource = new MatTableDataSource(this.DanhMucQuayDichVuService.List);
        this.DanhMucQuayDichVuService.DataSource.sort = this.DanhMucQuayDichVuSort;
        this.DanhMucQuayDichVuService.DataSource.paginator = this.DanhMucQuayDichVuPaginator;
      },
      err => {
      },
      () => {
      }
    );
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
    this.DanhMucQuayDichVuService.ListFilter = this.DanhMucQuayDichVuService.List.filter(item => item.ID > 0);
    this.DanhMucQuayDichVuService.SaveListAsync(this.DanhMucQuayDichVuService.ListFilter).subscribe(
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