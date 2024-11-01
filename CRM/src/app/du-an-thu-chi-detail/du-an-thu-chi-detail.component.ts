import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucBieuMau } from 'src/app/shared/DanhMucBieuMau.model';
import { DanhMucBieuMauService } from 'src/app/shared/DanhMucBieuMau.service';
import { DanhMucHinhThucThanhToan } from 'src/app/shared/DanhMucHinhThucThanhToan.model';
import { DanhMucHinhThucThanhToanService } from 'src/app/shared/DanhMucHinhThucThanhToan.service';

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
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';
import { DuAnTapTinDinhKem } from 'src/app/shared/DuAnTapTinDinhKem.model';
import { DuAnTapTinDinhKemService } from 'src/app/shared/DuAnTapTinDinhKem.service';

@Component({
  selector: 'app-du-an-thu-chi-detail',
  templateUrl: './du-an-thu-chi-detail.component.html',
  styleUrls: ['./du-an-thu-chi-detail.component.css']
})
export class DuAnThuChiDetailComponent implements OnInit {


  @ViewChild('DuAnTapTinDinhKemSort') DuAnTapTinDinhKemSort: MatSort;
  @ViewChild('DuAnTapTinDinhKemPaginator') DuAnTapTinDinhKemPaginator: MatPaginator;

  IsDuAnThuChiSave: boolean = true;

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DuAnThuChiDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucBieuMauService: DanhMucBieuMauService,
    public DanhMucHinhThucThanhToanService: DanhMucHinhThucThanhToanService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,
    public ToChucTaiKhoanService: ToChucTaiKhoanService,

    public DuAnService: DuAnService,
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnTapTinDinhKemService: DuAnTapTinDinhKemService,
  ) { }

  ngOnInit(): void {
    this.DuAnThuChiSearch();
  }
  Close() {
    this.DialogRef.close();
  }
  DateNgayGhiNhan(value) {
    this.DuAnThuChiService.FormData.NgayGhiNhan = new Date(value);
  }
  DanhMucBieuMauSearch() {
    this.DanhMucBieuMauService.ComponentGetAllToListAsync(this.DuAnThuChiService);
  }
  DanhMucHinhThucThanhToanSearch() {
    this.DanhMucHinhThucThanhToanService.ComponentGetAllToListAsync(this.DuAnThuChiService);
  }
  DuAnQuyetDinhSearch() {
    this.DuAnThuChiService.IsShowLoading = true;
    this.DuAnQuyetDinhService.BaseParameter.ParentID = this.DuAnService.FormData.ID;
    this.DuAnQuyetDinhService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.List = (res as DuAnQuyetDinh[]).sort((a, b) => (a.NgayKy > b.NgayKy ? 1 : -1));
        this.DuAnQuyetDinhService.ListFilter = this.DuAnQuyetDinhService.List;
      },
      err => {
      },
      () => {
        this.DuAnThuChiService.IsShowLoading = false;
      }
    );
  }
  ToChucSearch() {
    this.ToChucService.ComponentGetAllToListAsync(this.DuAnThuChiService);
  }
  ToChucTaiKhoanSearch() {
    this.DuAnThuChiService.IsShowLoading = true;
    this.ToChucTaiKhoanService.GetAllToListAsync().subscribe(
      res => {
        this.ToChucTaiKhoanService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.ToChucTaiKhoanService.ListFilter = this.ToChucTaiKhoanService.List;
        this.ToChucTaiKhoanService.ListFilter001 = this.ToChucTaiKhoanService.List.filter(item => item.ParentID == this.DuAnThuChiService.FormData.BenDauTuID);
        this.ToChucTaiKhoanService.ListFilter002 = this.ToChucTaiKhoanService.List.filter(item => item.ParentID == this.DuAnThuChiService.FormData.BenThucHienID);
      },
      err => {
      },
      () => {
        this.DuAnThuChiService.IsShowLoading = false;
      }
    );
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListAsync(this.DuAnThuChiService);
  }
  ThanhVienFilter(searchString: string) {
    this.ThanhVienService.Filter(searchString);
  }
  ThanhVienFilter001(searchString: string) {
    this.ThanhVienService.Filter001(searchString);
  }
  BenDauTuSearch() {
    let ListFilter = this.ToChucService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.BenDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.BenDauTuName = ListFilter[0].Name;
      }
    }
    this.ToChucTaiKhoanService.ListFilter001 = this.ToChucTaiKhoanService.List.filter(item => item.ParentID == this.DuAnThuChiService.FormData.BenDauTuID);
  }
  BenThucHienSearch() {
    let ListFilter = this.ToChucService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.BenThucHienID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.BenThucHienName = ListFilter[0].Name;
      }
    }
    this.ToChucTaiKhoanService.ListFilter002 = this.ToChucTaiKhoanService.List.filter(item => item.ParentID == this.DuAnThuChiService.FormData.BenThucHienID);
  }
  NguoiDauTuSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.NguoiDauTuID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.NguoiDauTuName = ListFilter[0].Name;
        this.DuAnThuChiService.FormData.NguoiDauTuChucDanh = ListFilter[0].DanhMucChucDanhName;
      }
    }
  }
  NguoiThucHienSearch() {
    let ListFilter = this.ThanhVienService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.NguoiThucHienID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.NguoiThucHienName = ListFilter[0].Name;
        this.DuAnThuChiService.FormData.NguoiThucHienChucDanh = ListFilter[0].DanhMucChucDanhName;
      }
    }
  }
  BenDauTuTaiKhoanSearch() {
    this.DuAnThuChiService.FormData.BenDauTuSoTaiKhoan = environment.InitializationString;
    this.DuAnThuChiService.FormData.BenDauTuNganHang = environment.InitializationString;
    let ListFilter = this.ToChucTaiKhoanService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.BenDauTuTaiKhoanID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.BenDauTuSoTaiKhoan = ListFilter[0].Display;
        this.DuAnThuChiService.FormData.BenDauTuNganHang = ListFilter[0].Description;
      }
    }
  }
  BenThucHienTaiKhoanSearch() {
    this.DuAnThuChiService.FormData.BenThucHienSoTaiKhoan = environment.InitializationString;
    this.DuAnThuChiService.FormData.BenThucHienNganHang = environment.InitializationString;
    let ListFilter = this.ToChucTaiKhoanService.List.filter(item => item.ID == this.DuAnThuChiService.FormData.BenThucHienTaiKhoanID);
    if (ListFilter) {
      if (ListFilter.length > 0) {
        this.DuAnThuChiService.FormData.BenThucHienSoTaiKhoan = ListFilter[0].Display;
        this.DuAnThuChiService.FormData.BenThucHienNganHang = ListFilter[0].Description;
      }
    }
  }

  DuAnThuChiSearch() {
    this.DuAnThuChiService.IsShowLoading = true;
    this.DuAnThuChiService.GetByIDAsync().subscribe(
      res => {
        this.DuAnThuChiService.FormData = res as DuAnThuChi;
        this.DuAnThuChiService.FormData.ParentID = this.DuAnService.FormData.ID;
        this.DuAnThuChiService.FormData.ParentName = this.DuAnService.FormData.Name;
        this.DuAnThuChiService.FormData.DuAnQuyetDinhID = this.DuAnQuyetDinhService.FormData.ID;
        this.DuAnThuChiService.FormData.DuAnQuyetDinhSoQuyetDinh = this.DuAnQuyetDinhService.FormData.SoQuyetDinh;
        this.DanhMucBieuMauSearch();
        this.DanhMucHinhThucThanhToanSearch();
        this.ToChucSearch();
        this.ToChucTaiKhoanSearch();
        this.ThanhVienSearch();
        this.DuAnTapTinDinhKemSearch();
        this.DuAnQuyetDinhSearch();
        if (this.DuAnThuChiService.FormData.Active == true) {
          this.IsDuAnThuChiSave = false;
        }
      },
      err => {
      },
      () => {
        this.DuAnThuChiService.IsShowLoading = false;
      }
    );
  }
  DuAnThuChiSave() {
    this.DuAnThuChiService.IsShowLoading = true;
    this.DuAnThuChiService.FormData.ParentID = this.DuAnService.FormData.ID;
    this.DuAnThuChiService.FormData.Code = this.DuAnService.FormData.Code;
    this.DuAnThuChiService.SaveAsync().subscribe(
      res => {
        this.DuAnThuChiService.FormData = res as DuAnThuChi;
        if (this.DuAnThuChiService.FormData.Active == true) {
          this.IsDuAnThuChiSave = false;
        }
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DuAnThuChiService.IsShowLoading = false;
      }
    );
  }

  DuAnTapTinDinhKemSearch() {
    this.DuAnTapTinDinhKemService.BaseParameter.TypeName = this.DuAnThuChiService.FormData.TypeName;
    this.DuAnTapTinDinhKemService.SearchByTypeName(this.DuAnTapTinDinhKemSort, this.DuAnTapTinDinhKemPaginator, this.DuAnThuChiService);
  }
  DuAnTapTinDinhKemSave(element: DuAnTapTinDinhKem) {
    this.DuAnService.IsShowLoading = true;
    element.DuAnThuChiID = this.DuAnThuChiService.FormData.ID;
    element.Code = this.DuAnThuChiService.FormData.Code;
    element.TypeName = this.DuAnThuChiService.FormData.TypeName;
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
    this.NotificationService.warn(this.DuAnTapTinDinhKemService.ComponentDeleteByTypeName(this.DuAnTapTinDinhKemSort, this.DuAnTapTinDinhKemPaginator, this.DuAnThuChiService));
  }
  DuAnTapTinDinhKemChangeFile(files: FileList) {
    if (files) {
      this.DuAnTapTinDinhKemService.FileToUpload = files;
    }
  }
}
