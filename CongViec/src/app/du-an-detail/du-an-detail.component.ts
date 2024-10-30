import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucTinhTrang } from 'src/app/shared/DanhMucTinhTrang.model';
import { DanhMucTinhTrangService } from 'src/app/shared/DanhMucTinhTrang.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
import { ToChuc } from 'src/app/shared/ToChuc.model';
import { ToChucService } from 'src/app/shared/ToChuc.service';
import { ToChucTaiKhoan } from 'src/app/shared/ToChucTaiKhoan.model';
import { ToChucTaiKhoanService } from 'src/app/shared/ToChucTaiKhoan.service';

import { DuAn } from 'src/app/shared/DuAn.model';
import { DuAnService } from 'src/app/shared/DuAn.service';

@Component({
  selector: 'app-du-an-detail',
  templateUrl: './du-an-detail.component.html',
  styleUrls: ['./du-an-detail.component.css']
})
export class DuAnDetailComponent implements OnInit {

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DuAnDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,
    public DanhMucTinhTrangService: DanhMucTinhTrangService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,
    public ToChucTaiKhoanService: ToChucTaiKhoanService,

    public DuAnService: DuAnService,

  ) { }

  ngOnInit(): void {
    this.DuAnSearch();
  }
  Close() {
    this.DialogRef.close();
  }
  DateNgayBatDau(value) {
    this.DuAnService.FormData.NgayBatDau = new Date(value);
  }
  DateNgayKetThuc(value) {
    this.DuAnService.FormData.NgayKetThuc = new Date(value);
  }
  DanhMucTinhTrangSearch() {
    this.DanhMucTinhTrangService.ComponentGetAllToListAsync(this.DuAnService);
  }
  ToChucSearch() {
    this.ToChucService.ComponentGetAllToListAsync(this.DuAnService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListAsync(this.DuAnService);
  }
  ThanhVienFilter(searchString: string) {
    this.ThanhVienService.Filter(searchString);
  }
  ThanhVienFilter001(searchString: string) {
    this.ThanhVienService.Filter001(searchString);
  }
  BenDauTuSearch() {
    let ListFilter = this.ToChucService.List.filter(item => item.ID == this.DuAnService.FormData.BenDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnService.FormData.BenDauTuName = ListFilter[0].Name;
      }
    }
  }
  BenThucHienSearch() {
    let ListFilter = this.ToChucService.List.filter(item => item.ID == this.DuAnService.FormData.BenThucHienID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnService.FormData.BenThucHienName = ListFilter[0].Name;
      }
    }
  }
  NguoiDauTuSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnService.FormData.NguoiDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnService.FormData.NguoiDauTuName = ListFilter[0].Name;
      }
    }
  }
  NguoiThucHienSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnService.FormData.NguoiThucHienID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnService.FormData.NguoiThucHienName = ListFilter[0].Name;
      }
    }
  }
  DuAnSearch() {
    this.DuAnService.GetByIDAsync().subscribe(
      res => {
        this.DuAnService.FormData = res as DuAn;
        this.DanhMucTinhTrangSearch();
        this.ToChucSearch();
        this.ThanhVienSearch();
      },
      err => {
      }
    );
  }

  DuAnSave() {
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.SaveAsync().subscribe(
      res => {
        this.DuAnService.FormData = res as DuAn;

        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
}
