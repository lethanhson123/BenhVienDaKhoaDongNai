import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { ChartOptions, ChartType, ChartDataSets, Chart, ChartConfiguration, ChartData } from 'chart.js';
import { Color, Label, SingleDataSet, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';
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

import { Report } from 'src/app/shared/Report.model';
import { ReportService } from 'src/app/shared/Report.service';

@Component({
  selector: 'app-du-an-info',
  templateUrl: './du-an-info.component.html',
  styleUrls: ['./du-an-info.component.css']
})
export class DuAnInfoComponent implements OnInit {

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

  IsDuAnQuyetToanLuyKe: boolean = true;
  IsDuAnQuyetToanPhanKy: boolean = true;
  IsDuAnQuyetDinh: boolean = true;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,
    public ToChucTaiKhoanService: ToChucTaiKhoanService,

    public DuAnService: DuAnService,
    public DuAnTapTinDinhKemService: DuAnTapTinDinhKemService,
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnQuyetToanPhanKyService: DuAnQuyetToanPhanKyService,
    public DuAnQuyetToanLuyKeService: DuAnQuyetToanLuyKeService,

    public ReportService: ReportService,

  ) {
  }

  ngOnInit(): void {
    this.DuAnService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.DuAnSearch();
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
        //this.DanhMucTinhTrangSearch();
        //this.ToChucSearch();
        //this.ThanhVienSearch();
        this.DuAnTapTinDinhKemSearch();
        this.DuAnThuChiSearch();
        this.DuAnQuyetDinhSearch();
        //this.DuAnQuyetToanPhanKySearch();
        //this.DuAnQuyetToanLuyKeSearch();
        this.DuAnQuyetToanLuyKeService.List = [];
        this.DuAnQuyetToanPhanKyService.List = [];
        this.Report0001();
        this.Report0002();
        this.Report0003();
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
        this.Router.navigateByUrl(environment.DuAnInfo + this.DuAnService.FormData.ID);
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
  DuAnAdd() {
    this.Router.navigateByUrl(environment.DuAnInfo + environment.InitializationNumber);
    this.DuAnService.BaseParameter.ID = environment.InitializationNumber;
    this.DuAnSearch();
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

          this.DuAnThuChiService.ListActive = this.DuAnThuChiService.List;
          this.DuAnThuChiService.FormDataActive.ID = environment.InitializationNumber;
          this.DuAnThuChiService.FormDataActive.DonGia = environment.InitializationNumber;
          this.DuAnThuChiService.FormDataActive.GhiCo = environment.InitializationNumber;
          this.DuAnThuChiService.FormDataActive.GhiNo = environment.InitializationNumber;
          this.DuAnThuChiService.FormDataActive.ConLai = environment.InitializationNumber;

          for (let i = 0; i < this.DuAnThuChiService.ListActive.length; i++) {
            this.DuAnThuChiService.ListActive[i].Active = false;
            this.DuAnThuChiService.FormDataActive.DonGia = this.DuAnThuChiService.FormDataActive.DonGia + this.DuAnThuChiService.ListActive[i].DonGia;
            this.DuAnThuChiService.FormDataActive.GhiCo = this.DuAnThuChiService.FormDataActive.GhiCo + this.DuAnThuChiService.ListActive[i].GhiCo;
            this.DuAnThuChiService.FormDataActive.GhiNo = this.DuAnThuChiService.FormDataActive.GhiNo + this.DuAnThuChiService.ListActive[i].GhiNo;
            this.DuAnThuChiService.FormDataActive.ConLai = this.DuAnThuChiService.FormDataActive.ConLai + this.DuAnThuChiService.ListActive[i].ConLai;
          }
          this.DuAnThuChiService.ListActive.push(this.DuAnThuChiService.FormDataActive);

          this.DuAnThuChiService.DataSource = new MatTableDataSource(this.DuAnThuChiService.ListActive);
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
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
  DuAnQuyetDinhActiveChange(element: DuAnQuyetDinh) {
    this.DuAnQuyetDinhService.ListActive001.push(element);
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

          this.DuAnQuyetDinhService.ListActive = this.DuAnQuyetDinhService.List;
          this.DuAnQuyetDinhService.FormDataActive.ID = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.MucDauTu = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.MucDauTuConLai = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.TamUngGhiCo = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.TamUngConLai = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.GhiCo = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.GhiNo = environment.InitializationNumber;
          this.DuAnQuyetDinhService.FormDataActive.ConLai = environment.InitializationNumber;

          for (let i = 0; i < this.DuAnQuyetDinhService.ListActive.length; i++) {
            this.DuAnQuyetDinhService.ListActive[i].Active = false;
            this.DuAnQuyetDinhService.FormDataActive.MucDauTu = this.DuAnQuyetDinhService.FormDataActive.MucDauTu + this.DuAnQuyetDinhService.ListActive[i].MucDauTu;
            this.DuAnQuyetDinhService.FormDataActive.MucDauTuConLai = this.DuAnQuyetDinhService.FormDataActive.MucDauTuConLai + this.DuAnQuyetDinhService.ListActive[i].MucDauTuConLai;
            this.DuAnQuyetDinhService.FormDataActive.TamUngGhiCo = this.DuAnQuyetDinhService.FormDataActive.TamUngGhiCo + this.DuAnQuyetDinhService.ListActive[i].TamUngGhiCo;
            this.DuAnQuyetDinhService.FormDataActive.TamUngConLai = this.DuAnQuyetDinhService.FormDataActive.TamUngConLai + this.DuAnQuyetDinhService.ListActive[i].TamUngConLai;
            this.DuAnQuyetDinhService.FormDataActive.GhiCo = this.DuAnQuyetDinhService.FormDataActive.GhiCo + this.DuAnQuyetDinhService.ListActive[i].GhiCo;
            this.DuAnQuyetDinhService.FormDataActive.GhiNo = this.DuAnQuyetDinhService.FormDataActive.GhiNo + this.DuAnQuyetDinhService.ListActive[i].GhiNo;
            this.DuAnQuyetDinhService.FormDataActive.ConLai = this.DuAnQuyetDinhService.FormDataActive.ConLai + this.DuAnQuyetDinhService.ListActive[i].ConLai;
          }
          this.DuAnQuyetDinhService.ListActive.push(this.DuAnQuyetDinhService.FormDataActive);


          this.DuAnQuyetDinhService.DataSource = new MatTableDataSource(this.DuAnQuyetDinhService.ListActive);
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


    this.DuAnService.IsShowLoading = true;
    this.DuAnQuyetDinhService.BaseParameter.ID = environment.InitializationNumber;
    this.DuAnQuyetDinhService.GetByIDAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.FormData = (res as any);
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );

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
      this.DuAnQuyetToanPhanKyService.GetSQLByParentIDToListAsync().subscribe(
        res => {
          this.DuAnQuyetToanPhanKyService.List = (res as DuAnQuyetToanPhanKy[]);
          if (this.IsDuAnQuyetToanPhanKy == true) {
            this.DuAnQuyetToanPhanKyService.List = this.DuAnQuyetToanPhanKyService.List.filter(item => item.GhiCo > 0 || item.GhiNo > 0);
          }
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
      this.DuAnQuyetToanLuyKeService.GetSQLByParentIDToListAsync().subscribe(
        res => {
          this.DuAnQuyetToanLuyKeService.List = (res as DuAnQuyetToanLuyKe[]);
          if (this.IsDuAnQuyetToanLuyKe == true) {
            this.DuAnQuyetToanLuyKeService.List = this.DuAnQuyetToanLuyKeService.List.filter(item => item.GhiCo > 0 || item.GhiNo > 0);
          }
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
  DuAnQuyetToanLuyKeActiveChange(element: DuAnQuyetToanLuyKe) {
    this.DuAnService.IsShowLoading = true;
    this.DuAnQuyetToanLuyKeService.FormData = element;
    this.DuAnQuyetToanLuyKeService.SaveAsync().subscribe(
      res => {
        this.DuAnQuyetToanLuyKeService.FormData = res as DuAnQuyetToanLuyKe;
        this.DuAnThuChiSearch();
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

  DuAnQuyetToanPhanKyActiveChange(element: DuAnQuyetToanPhanKy) {
    this.DuAnService.IsShowLoading = true;
    this.DuAnQuyetToanPhanKyService.FormData = element;
    this.DuAnQuyetToanPhanKyService.SaveAsync().subscribe(
      res => {
        this.DuAnQuyetToanPhanKyService.FormData = res as DuAnQuyetToanPhanKy;
        this.DuAnThuChiSearch();
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


  public Report0001_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return label + '';
        }
      }
    }
  };
  public Report0001_0001_Color: Color[] = [
  ]
  public Report0001_0001_Label: Label[] = [];
  public Report0001_0001_Type: ChartType = 'doughnut';
  public Report0001_0001_Legend = true;
  public Report0001_0001_Plugins = [];

  public Report0001_0001_Data: ChartDataSets[] = [
  ];

  public Report0001_0002_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return label + '';
        }
      }
    }
  };
  public Report0001_0002_Color: Color[] = [
  ]
  public Report0001_0002_Label: Label[] = [];
  public Report0001_0002_Type: ChartType = 'pie';
  public Report0001_0002_Legend = true;
  public Report0001_0002_Plugin = [];

  public Report0001_0002_Data: ChartDataSets[] = [
  ];

  public Report0001_0003_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return label + '';
        }
      }
    }
  };
  public Report0001_0003_Color: Color[] = [
  ]
  public Report0001_0003_Label: Label[] = [];
  public Report0001_0003_Type: ChartType = 'pie';
  public Report0001_0003_Legend = true;
  public Report0001_0003_Plugin = [];

  public Report0001_0003_Data: ChartDataSets[] = [
  ];

  public Report0002_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    animation: {
      duration: 1,
      onComplete: function () {
        var chartInstance = this.chart,
          ctx = chartInstance.ctx;
        ctx.textAlign = 'center';
        ctx.fillStyle = "rgba(0, 0, 0, 1)";
        ctx.textBaseline = 'bottom';
        this.data.datasets.forEach(function (dataset, i) {
          var meta = chartInstance.controller.getDatasetMeta(i);
          meta.data.forEach(function (bar, index) {
            var data = dataset.data[index];
            ctx.fillText(data, bar._model.x, bar._model.y - 5);

          });
        });
      }
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          return Number(tooltipItem.yLabel).toFixed(0).replace(/./g, function (c, i, a) {
            return i > 0 && c !== "." && (a.length - i) % 3 === 0 ? "." + c : c;
          });
        }
      }
    },
    scales: {
      yAxes: [
        {
          id: 'A',
          position: 'left',
        }, {
          id: 'B',
          position: 'right',
        }
      ]
    },
  };
  public Report0002_0001_Color: Color[] = [
  ]
  public Report0002_0001_Label: Label[] = [];
  public Report0002_0001_Type: ChartType = 'bar';
  public Report0002_0001_Legend = true;
  public Report0002_0001_Plugin = [];

  public Report0002_0001_Data: ChartDataSets[] = [
  ];

  public Report0003_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'right'
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return value + '';
        }
      }
    }
  };
  public Report0003_0001_Color: Color[] = [
  ]
  public Report0003_0001_Label: Label[] = [];
  public Report0003_0001_Type: ChartType = 'line';
  public Report0003_0001_Legend = true;
  public Report0003_0001_Plugin = [];

  public Report0003_0001_Data: ChartDataSets[] = [
  ];

  Report0001() {
    this.DuAnService.IsShowLoading = true;
    this.ReportService.BaseParameter.ID = this.DuAnService.FormData.ID;
    this.ReportService.Report0001ToListAsync().subscribe(
      res => {
        this.ReportService.List0001 = (res as Report[]);
        let LabelArray001 = [];
        let DataArray001 = [];
        let LabelArray002 = [];
        let DataArray002 = [];
        let LabelArray003 = [];
        let DataArray003 = [];
        for (let i = 0; i < this.ReportService.List0001.length; i++) {
          LabelArray001.push(this.ReportService.List0001[i].Display);
          DataArray001.push(this.ReportService.List0001[i].MucDauTu);

          LabelArray002.push(this.ReportService.List0001[i].Note);
          DataArray002.push(this.ReportService.List0001[i].ConLai);

          LabelArray003.push(this.ReportService.List0001[i].Description);
          DataArray003.push(this.ReportService.List0001[i].GhiCo);
        }
        this.Report0001_0001_Label = LabelArray001;
        this.Report0001_0001_Data = [
          { data: DataArray001, stack: 'a' },
        ];

        this.Report0001_0002_Label = LabelArray002;
        this.Report0001_0002_Data = [
          { data: DataArray002, stack: 'a' },
        ];

        this.Report0001_0003_Label = LabelArray003;
        this.Report0001_0003_Data = [
          { data: DataArray003, stack: 'a' },
        ];
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
  Report0002() {
    this.DuAnService.IsShowLoading = true;
    this.ReportService.BaseParameter.ID = this.DuAnService.FormData.ID;
    this.ReportService.Report0002ToListAsync().subscribe(
      res => {
        this.ReportService.List0002 = (res as Report[]);
        let LabelArray001 = [];
        let DataArray001 = [];
        for (let i = 0; i < this.ReportService.List0002.length; i++) {
          LabelArray001.push(this.ReportService.List0002[i].Display);
          DataArray001.push(this.ReportService.List0002[i].GhiNoTongCong);
        }
        this.Report0002_0001_Label = LabelArray001;
        let Label001: string = 'Biểu mẫu (đồng)';
        this.Report0002_0001_Data = [
          { data: DataArray001, label: Label001, stack: 'b', yAxisID: 'B', }
        ];
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
  Report0003() {
    this.DuAnService.IsShowLoading = true;
    this.ReportService.BaseParameter.ID = this.DuAnService.FormData.ID;
    this.ReportService.Report0003ToListAsync().subscribe(
      res => {
        this.ReportService.List0003 = (res as Report[]);
        let LabelArray001 = [];
        let NameArray001 = [];
        for (let i = 0; i < this.ReportService.List0003.length; i++) {
          let Code = LabelArray001.filter(item => item == this.ReportService.List0003[i].Code);
          if (Code) {
            if (Code.length == 0) {
              LabelArray001.push(this.ReportService.List0003[i].Code);
            }
          }
          let NameArraySub = NameArray001.filter(item => item == this.ReportService.List0003[i].Name);
          if (NameArraySub) {
            if (NameArraySub.length == 0) {
              let Name = this.ReportService.List0003[i].Name;
              NameArray001.push(Name);
              let DataArray = this.ReportService.List0003.filter(item => item.Name == Name);
              let GhiNo = [];
              for (let j = 0; j < DataArray.length; j++) {
                GhiNo.push(DataArray[j].GhiNo);
              }
              let Data: any = {
                type: "line",
                fill: false,
                data: GhiNo,
                label: Name,
                borderColor: this.DownloadService.GetRandomColor(GhiNo.length)
              }
              this.Report0003_0001_Data.push(Data);
            }
          }
        }
        this.Report0003_0001_Label = LabelArray001;
        this.Report0003_0001_Data.splice(0, 1)
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }

}
