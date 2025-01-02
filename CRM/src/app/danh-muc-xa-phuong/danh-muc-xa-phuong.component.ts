import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';
import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { DanhMucTinhThanhToaDoService } from 'src/app/shared/DanhMucTinhThanhToaDo.service';
import { DanhMucTinhThanhToaDoDetailComponent } from '../danh-muc-tinh-thanh-toa-do-detail/danh-muc-tinh-thanh-toa-do-detail.component';

@Component({
  selector: 'app-danh-muc-xa-phuong',
  templateUrl: './danh-muc-xa-phuong.component.html',
  styleUrls: ['./danh-muc-xa-phuong.component.css']
})
export class DanhMucXaPhuongComponent implements OnInit {

  @ViewChild('DanhMucXaPhuongSort') DanhMucXaPhuongSort: MatSort;
  @ViewChild('DanhMucXaPhuongPaginator') DanhMucXaPhuongPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void {
    this.DanhMucTinhThanhSearch();
    this.DanhMucQuanHuyenSearch();
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucXaPhuongService.IsShowLoading = true;
    this.DanhMucTinhThanhService.GetAllToListAsync().subscribe(
      res => {
        this.DanhMucTinhThanhService.List = (res as DanhMucTinhThanh[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucQuanHuyenSearch();
      },
      err => {
      },
      () => {
        this.DanhMucXaPhuongService.IsShowLoading = false;
      }
    );
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucXaPhuongService.IsShowLoading = true;
    this.DanhMucQuanHuyenService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucQuanHuyenService.List = (res as DanhMucQuanHuyen[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucXaPhuongSearch();
      },
      err => {
      },
      () => {
        this.DanhMucXaPhuongService.IsShowLoading = false;
      }
    );
  }
  DanhMucXaPhuongSearch() {
    this.DanhMucXaPhuongService.SearchByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService);
  }
  DanhMucXaPhuongSave(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.FormData = element;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentSaveByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService));
  }
  DanhMucXaPhuongDelete(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentDeleteByParentID(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator, this.DanhMucXaPhuongService));
  }
  DanhMucTinhThanhToaDoAdd(element: DanhMucTinhThanh) {
    this.DanhMucTinhThanhToaDoService.BaseParameter.ParentID = element.ID;
    this.DanhMucTinhThanhToaDoService.BaseParameter.Name = element.Name;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: element.ID };
    const dialog = this.Dialog.open(DanhMucTinhThanhToaDoDetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
    });
  }
}