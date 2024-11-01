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
import { DuAnTapTinDinhKem } from 'src/app/shared/DuAnTapTinDinhKem.model';
import { DuAnTapTinDinhKemService } from 'src/app/shared/DuAnTapTinDinhKem.service';
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { DuAnThuChiService } from 'src/app/shared/DuAnThuChi.service';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';
import { DuAnQuyetToanPhanKy } from 'src/app/shared/DuAnQuyetToanPhanKy.model';
import { DuAnQuyetToanPhanKyService } from 'src/app/shared/DuAnQuyetToanPhanKy.service';
import { DuAnQuyetToanLuyKe } from 'src/app/shared/DuAnQuyetToanLuyKe.model';
import { DuAnQuyetToanLuyKeService } from 'src/app/shared/DuAnQuyetToanLuyKe.service';
import { DuAnThuChiDetailComponent } from '../du-an-thu-chi-detail/du-an-thu-chi-detail.component';
import { DuAnQuyetDinhDetailComponent } from '../du-an-quyet-dinh-detail/du-an-quyet-dinh-detail.component';

@Component({
  selector: 'app-du-an-detail',
  templateUrl: './du-an-detail.component.html',
  styleUrls: ['./du-an-detail.component.css']
})
export class DuAnDetailComponent implements OnInit {

  @ViewChild('DuAnTapTinDinhKemSort') DuAnTapTinDinhKemSort: MatSort;
  @ViewChild('DuAnTapTinDinhKemPaginator') DuAnTapTinDinhKemPaginator: MatPaginator;

  @ViewChild('DuAnThuChiSort') DuAnThuChiSort: MatSort;
  @ViewChild('DuAnThuChiPaginator') DuAnThuChiPaginator: MatPaginator;

  @ViewChild('DuAnQuyetDinhSort') DuAnQuyetDinhSort: MatSort;
  @ViewChild('DuAnQuyetDinhPaginator') DuAnQuyetDinhPaginator: MatPaginator; 

  @ViewChild('DuAnQuyetToanLuyKeSort') DuAnQuyetToanLuyKeSort: MatSort;
  @ViewChild('DuAnQuyetToanLuyKePaginator') DuAnQuyetToanLuyKePaginator: MatPaginator; 

  @ViewChild('DuAnQuyetToanPhanKySort') DuAnQuyetToanPhanKySort: MatSort;
  @ViewChild('DuAnQuyetToanPhanKyPaginator') DuAnQuyetToanPhanKyPaginator: MatPaginator; 

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
    public DuAnTapTinDinhKemService: DuAnTapTinDinhKemService,
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnQuyetToanPhanKyService: DuAnQuyetToanPhanKyService,
    public DuAnQuyetToanLuyKeService: DuAnQuyetToanLuyKeService,

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
        this.DuAnQuyetDinhSearch();
        this.DuAnQuyetToanPhanKySearch();
        this.DuAnQuyetToanLuyKeSearch();
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
      this.DuAnThuChiService.GetSQLByCodeToListAsync().subscribe(
        res => {
          this.DuAnThuChiService.List = (res as DuAnThuChi[]);          
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
    this.DuAnService.IsShowLoading = true;
    this.DuAnThuChiService.BaseParameter.ID = ID;
    this.DuAnThuChiService.GetByIDAsync().subscribe(
      res => {
        this.DuAnThuChiService.FormData = (res as DuAnThuChi);
        this.DuAnThuChiService.FormData.ParentID = this.DuAnService.FormData.ID;
        this.DuAnThuChiService.FormData.ParentName = this.DuAnService.FormData.Name;
        const dialogConfig = new MatDialogConfig();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        dialogConfig.width = environment.DialogConfigWidth;
        dialogConfig.data = { ID: ID };
        const dialog = this.Dialog.open(DuAnThuChiDetailComponent, dialogConfig);
        dialog.afterClosed().subscribe(() => {
          this.DuAnSearch();
        });
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }

  DuAnQuyetDinhSearch() {
    if (this.DuAnQuyetDinhService.BaseParameter.SearchString.length > 0) {
      this.DuAnQuyetDinhService.BaseParameter.SearchString = this.DuAnQuyetDinhService.BaseParameter.SearchString.trim();
      if (this.DuAnQuyetDinhService.DataSource) {
        this.DuAnQuyetDinhService.DataSource.filter = this.DuAnQuyetDinhService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DuAnService.IsShowLoading = true;
      this.DuAnQuyetDinhService.BaseParameter.ParentID = this.DuAnService.FormData.ID;
      this.DuAnQuyetDinhService.BaseParameter.Code = this.DuAnService.FormData.Code;
      this.DuAnQuyetDinhService.GetByCodeToListAsync().subscribe(
        res => {
          this.DuAnQuyetDinhService.List = (res as any[]);
          this.DuAnQuyetDinhService.ListFilter = this.DuAnQuyetDinhService.List.filter(item => item.ID > 0);
          this.DuAnQuyetDinhService.DataSource = new MatTableDataSource(this.DuAnQuyetDinhService.List);
          this.DuAnQuyetDinhService.DataSource.sort = this.DuAnQuyetDinhSort;
          this.DuAnQuyetDinhService.DataSource.paginator = this.DuAnQuyetDinhPaginator;
        },
        err => {
        },
        () => {
          this.DuAnService.IsShowLoading = false;
        }
      );
    }
  }
  DuAnQuyetDinhDelete(element: DuAnQuyetDinh) {
    if (confirm(environment.DeleteConfirm)) {
      this.DuAnService.IsShowLoading = true;
      this.DuAnQuyetDinhService.BaseParameter.ID = element.ID;
      this.DuAnQuyetDinhService.RemoveAsync().subscribe(
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
  DuAnQuyetDinhAdd(ID: number) {
    this.DuAnService.IsShowLoading = true;
    this.DuAnQuyetDinhService.BaseParameter.ID = ID;
    this.DuAnQuyetDinhService.GetByIDAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.FormData = (res as DuAnQuyetDinh);
        this.DuAnQuyetDinhService.FormData.ParentID = this.DuAnService.FormData.ID;
        this.DuAnQuyetDinhService.FormData.ParentName = this.DuAnService.FormData.Name;
        const dialogConfig = new MatDialogConfig();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        dialogConfig.width = environment.DialogConfigWidth;
        dialogConfig.data = { ID: ID };
        const dialog = this.Dialog.open(DuAnQuyetDinhDetailComponent, dialogConfig);
        dialog.afterClosed().subscribe(() => {
          this.DuAnSearch();
        });
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }

  DuAnQuyetToanPhanKySearch() {
    if (this.DuAnQuyetToanPhanKyService.BaseParameter.SearchString.length > 0) {
      this.DuAnQuyetToanPhanKyService.BaseParameter.SearchString = this.DuAnQuyetToanPhanKyService.BaseParameter.SearchString.trim();
      if (this.DuAnQuyetToanPhanKyService.DataSource) {
        this.DuAnQuyetToanPhanKyService.DataSource.filter = this.DuAnQuyetToanPhanKyService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DuAnService.IsShowLoading = true;
      this.DuAnQuyetToanPhanKyService.BaseParameter.ParentID = this.DuAnService.FormData.ID;      
      this.DuAnQuyetToanPhanKyService.GetByParentIDToListAsync().subscribe(
        res => {
          this.DuAnQuyetToanPhanKyService.List = (res as DuAnQuyetToanPhanKy[]);
          this.DuAnQuyetToanPhanKyService.ListFilter = this.DuAnQuyetToanPhanKyService.List.filter(item => item.ID > 0);
          this.DuAnQuyetToanPhanKyService.DataSource = new MatTableDataSource(this.DuAnQuyetToanPhanKyService.List);
          this.DuAnQuyetToanPhanKyService.DataSource.sort = this.DuAnQuyetToanPhanKySort;
          this.DuAnQuyetToanPhanKyService.DataSource.paginator = this.DuAnQuyetToanPhanKyPaginator;
        },
        err => {
        },
        () => {
          this.DuAnService.IsShowLoading = false;
        }
      );
    }
  }
  DuAnQuyetToanLuyKeSearch() {
    if (this.DuAnQuyetToanLuyKeService.BaseParameter.SearchString.length > 0) {
      this.DuAnQuyetToanLuyKeService.BaseParameter.SearchString = this.DuAnQuyetToanLuyKeService.BaseParameter.SearchString.trim();
      if (this.DuAnQuyetToanLuyKeService.DataSource) {
        this.DuAnQuyetToanLuyKeService.DataSource.filter = this.DuAnQuyetToanLuyKeService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DuAnService.IsShowLoading = true;
      this.DuAnQuyetToanLuyKeService.BaseParameter.ParentID = this.DuAnService.FormData.ID;      
      this.DuAnQuyetToanLuyKeService.GetByParentIDToListAsync().subscribe(
        res => {
          this.DuAnQuyetToanLuyKeService.List = (res as DuAnQuyetToanLuyKe[]);
          this.DuAnQuyetToanLuyKeService.ListFilter = this.DuAnQuyetToanLuyKeService.List.filter(item => item.ID > 0);
          this.DuAnQuyetToanLuyKeService.DataSource = new MatTableDataSource(this.DuAnQuyetToanLuyKeService.List);
          this.DuAnQuyetToanLuyKeService.DataSource.sort = this.DuAnQuyetToanLuyKeSort;
          this.DuAnQuyetToanLuyKeService.DataSource.paginator = this.DuAnQuyetToanLuyKePaginator;
        },
        err => {
        },
        () => {
          this.DuAnService.IsShowLoading = false;
        }
      );
    }
  }
}
