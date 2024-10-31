import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
import { ToChuc } from 'src/app/shared/ToChuc.model';
import { ToChucService } from 'src/app/shared/ToChuc.service';

import { DuAn } from 'src/app/shared/DuAn.model';
import { DuAnService } from 'src/app/shared/DuAn.service';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';

@Component({
  selector: 'app-du-an-quyet-dinh-detail',
  templateUrl: './du-an-quyet-dinh-detail.component.html',
  styleUrls: ['./du-an-quyet-dinh-detail.component.css']
})
export class DuAnQuyetDinhDetailComponent implements OnInit {

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DuAnQuyetDinhDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,

    public DuAnService: DuAnService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,

  ) { }

  ngOnInit(): void {
    this.DuAnQuyetDinhSearch();
  }
  Close() {
    this.DialogRef.close();
  }
  DateNgayHieuLuc(value) {
    this.DuAnQuyetDinhService.FormData.NgayHieuLuc = new Date(value);
  }
  DateNgayKy(value) {
    this.DuAnQuyetDinhService.FormData.NgayKy = new Date(value);
  }
  ToChucSearch() {
    this.ToChucService.ComponentGetAllToListAsync(this.DuAnQuyetDinhService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListAsync(this.DuAnQuyetDinhService);
  }
  ThanhVienFilter(searchString: string) {
    this.ThanhVienService.Filter(searchString);
  }
  ThanhVienFilter001(searchString: string) {
    this.ThanhVienService.Filter001(searchString);
  }
  BenDauTuSearch() {
    let ListFilter = this.ToChucService.List.filter(item => item.ID == this.DuAnQuyetDinhService.FormData.BenDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnQuyetDinhService.FormData.BenDauTuName = ListFilter[0].Name;
      }
    }
  }
  NguoiDauTuSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnQuyetDinhService.FormData.NguoiDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnQuyetDinhService.FormData.NguoiDauTuName = ListFilter[0].Name;
        this.DuAnQuyetDinhService.FormData.NguoiDauTuChucDanh = ListFilter[0].DanhMucChucDanhName;
      }
    }
  }

  DuAnQuyetDinhSearch() {
    this.DuAnQuyetDinhService.IsShowLoading = true;
    this.DuAnQuyetDinhService.GetByIDAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.FormData = res as DuAnQuyetDinh;
        this.DuAnQuyetDinhService.FormData.ParentID = this.DuAnService.FormData.ID;
        this.DuAnQuyetDinhService.FormData.ParentName = this.DuAnService.FormData.Name;
        this.ToChucSearch();
        this.ThanhVienSearch();
      },
      err => {
      },
      () => {
        this.DuAnQuyetDinhService.IsShowLoading = false;
      }
    );
  }
  DuAnQuyetDinhSave() {
    this.DuAnQuyetDinhService.IsShowLoading = true;
    this.DuAnQuyetDinhService.FormData.ParentID = this.DuAnService.FormData.ID;
    this.DuAnQuyetDinhService.FormData.Code = this.DuAnService.FormData.Code;
    this.DuAnQuyetDinhService.SaveAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.FormData = res as DuAnQuyetDinh;

        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DuAnQuyetDinhService.IsShowLoading = false;
      }
    );
  }

}
