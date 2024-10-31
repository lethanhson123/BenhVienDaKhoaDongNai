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
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { DuAnThuChiService } from 'src/app/shared/DuAnThuChi.service';
import { DuAnTapTinDinhKem } from 'src/app/shared/DuAnTapTinDinhKem.model';
import { DuAnTapTinDinhKemService } from 'src/app/shared/DuAnTapTinDinhKem.service';
import { DuAnThuChiDetailComponent } from '../du-an-thu-chi-detail/du-an-thu-chi-detail.component';

@Component({
  selector: 'app-du-an-detail',
  templateUrl: './du-an-detail.component.html',
  styleUrls: ['./du-an-detail.component.css']
})
export class DuAnDetailComponent implements OnInit {

  @ViewChild('DuAnThuChiSort') DuAnThuChiSort: MatSort;
  @ViewChild('DuAnThuChiPaginator') DuAnThuChiPaginator: MatPaginator;

  @ViewChild('DuAnTapTinDinhKemSort') DuAnTapTinDinhKemSort: MatSort;
  @ViewChild('DuAnTapTinDinhKemPaginator') DuAnTapTinDinhKemPaginator: MatPaginator;

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
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnTapTinDinhKemService: DuAnTapTinDinhKemService,

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
  DateNgayKy(value) {
    this.DuAnService.FormData.NgayKy = new Date(value);
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
        this.DuAnService.FormData.NguoiDauTuChucDanh = ListFilter[0].DanhMucChucDanhName;
      }
    }
  }
  NguoiThucHienSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnService.FormData.NguoiThucHienID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnService.FormData.NguoiThucHienName = ListFilter[0].Name;
        this.DuAnService.FormData.NguoiThucHienChucDanh = ListFilter[0].DanhMucChucDanhName;
      }
    }
  }
  DuAnSearch() {
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.GetByIDAsync().subscribe(
      res => {
        this.DuAnService.FormData = res as DuAn;
        this.DanhMucTinhTrangSearch();
        this.ToChucSearch();
        this.ThanhVienSearch();
        this.DuAnTapTinDinhKemSearch();
        this.DuAnThuChiSearch();
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
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
  DuAnPrint() {
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.BaseParameter.ID = this.DuAnService.FormData.ID;
    this.DuAnService.CreateHTMLByIDAsync().subscribe(
      res => {
        this.DuAnService.FormData = res as DuAn;
        this.NotificationService.OpenWindowByURL(this.DuAnService.FormData.FileName);        
      },
      err => {        
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }

  DuAnTapTinDinhKemSearch() {
    this.DuAnTapTinDinhKemService.BaseParameter.ParentID = this.DuAnService.FormData.ID;
    this.DuAnTapTinDinhKemService.BaseParameter.Code = this.DuAnService.FormData.Code;
    this.DuAnTapTinDinhKemService.SearchByCode(this.DuAnTapTinDinhKemSort, this.DuAnTapTinDinhKemPaginator, this.DuAnService);
  }
  DuAnTapTinDinhKemSave(element: DuAnTapTinDinhKem) {
    this.DuAnService.IsShowLoading = true;
    element.ParentID = this.DuAnService.FormData.ID;
    element.Code = this.DuAnService.FormData.Code;
    this.DuAnTapTinDinhKemService.FormData = element;
    this.DuAnTapTinDinhKemService.SaveAndUploadFilesAsync().subscribe(
      res => {
        this.DuAnTapTinDinhKemSearch();
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
  DuAnTapTinDinhKemDelete(element: DuAnTapTinDinhKem) {
    this.DuAnTapTinDinhKemService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DuAnTapTinDinhKemService.ComponentDeleteByCode(this.DuAnTapTinDinhKemSort, this.DuAnTapTinDinhKemPaginator, this.DuAnService));
  }
  DuAnTapTinDinhKemChangeFile(files: FileList) {
    if (files) {
      this.DuAnTapTinDinhKemService.FileToUpload = files;
    }
  }

  DuAnThuChiSearch() {
    if (this.DuAnThuChiService.BaseParameter.SearchString.length > 0) {
      this.DuAnThuChiService.BaseParameter.SearchString = this.DuAnThuChiService.BaseParameter.SearchString.trim();
      if (this.DuAnThuChiService.DataSource) {
        this.DuAnThuChiService.DataSource.filter = this.DuAnThuChiService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DuAnService.IsShowLoading = true;
      this.DuAnThuChiService.BaseParameter.ParentID = this.DuAnService.FormData.ID;
      this.DuAnThuChiService.BaseParameter.Code = this.DuAnService.FormData.Code;
      this.DuAnThuChiService.GetByCodeToListAsync().subscribe(
        res => {
          this.DuAnThuChiService.List = (res as any[]).sort((a, b) => (a.NgayBatDau > b.NgayBatDau ? 1 : -1));
          this.DuAnThuChiService.ListFilter = this.DuAnThuChiService.List.filter(item => item.ID > 0);
          this.DuAnThuChiService.DataSource = new MatTableDataSource(this.DuAnThuChiService.List);
          this.DuAnThuChiService.DataSource.sort = this.DuAnThuChiSort;
          this.DuAnThuChiService.DataSource.paginator = this.DuAnThuChiPaginator;
        },
        err => {
        },
        () => {
          this.DuAnService.IsShowLoading = false;
        }
      );
    }
  }
  DuAnThuChiDelete(element: DuAnThuChi) {
    if (confirm(environment.DeleteConfirm)) {
      this.DuAnService.IsShowLoading = true;
      this.DuAnThuChiService.BaseParameter.ID = element.ID;
      this.DuAnThuChiService.RemoveAsync().subscribe(
        res => {
          this.DuAnSearch();
          this.NotificationService.warn(environment.DeleteSuccess);
        },
        err => {
          this.NotificationService.warn(environment.DeleteNotSuccess);
        },
        () => {
          this.DuAnService.IsShowLoading = false;
        }
      );
    }
  }
  DuAnThuChiAdd(ID: number) {
    this.DuAnThuChiService.BaseParameter.ID = ID;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: ID };
    const dialog = this.Dialog.open(DuAnThuChiDetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.DuAnSearch();

    });
  }
}
