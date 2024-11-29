import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
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
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { DuAnThuChiService } from 'src/app/shared/DuAnThuChi.service';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';
import { DuAnQuyetToanPhanKy } from 'src/app/shared/DuAnQuyetToanPhanKy.model';
import { DuAnQuyetToanPhanKyService } from 'src/app/shared/DuAnQuyetToanPhanKy.service';
import { DuAnQuyetToanLuyKe } from 'src/app/shared/DuAnQuyetToanLuyKe.model';
import { DuAnQuyetToanLuyKeService } from 'src/app/shared/DuAnQuyetToanLuyKe.service';


@Component({
  selector: 'app-du-an-quyet-dinh-info',
  templateUrl: './du-an-quyet-dinh-info.component.html',
  styleUrls: ['./du-an-quyet-dinh-info.component.css']
})
export class DuAnQuyetDinhInfoComponent implements OnInit {

  @ViewChild('DuAnThuChiSort') DuAnThuChiSort: MatSort;
  @ViewChild('DuAnThuChiPaginator') DuAnThuChiPaginator: MatPaginator;

  @ViewChild('DuAnQuyetToanLuyKeSort') DuAnQuyetToanLuyKeSort: MatSort;
  @ViewChild('DuAnQuyetToanLuyKePaginator') DuAnQuyetToanLuyKePaginator: MatPaginator;

  @ViewChild('DuAnQuyetToanPhanKySort') DuAnQuyetToanPhanKySort: MatSort;
  @ViewChild('DuAnQuyetToanPhanKyPaginator') DuAnQuyetToanPhanKyPaginator: MatPaginator;

  IsDuAnQuyetToanLuyKe: boolean = true;
  IsDuAnQuyetToanPhanKy: boolean = true;

  constructor(
    private ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,

    public DuAnService: DuAnService,
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnQuyetToanPhanKyService: DuAnQuyetToanPhanKyService,
    public DuAnQuyetToanLuyKeService: DuAnQuyetToanLuyKeService,

  ) {
  }

  ngOnInit(): void {
    this.DuAnService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.DuAnID);
    this.DuAnQuyetDinhService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.DuAnQuyetDinhSearch();
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
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.GetByIDAsync().subscribe(
      res => {
        this.DuAnService.FormData = res as DuAn;
        this.DuAnService.IsShowLoading = true;
        this.DuAnQuyetDinhService.GetByIDAsync().subscribe(
          res => {

            this.DuAnQuyetDinhService.FormData = res as DuAnQuyetDinh;
            this.DuAnQuyetDinhService.FormData.ParentID = this.DuAnService.FormData.ID;
            this.DuAnQuyetDinhService.FormData.ParentName = this.DuAnService.FormData.Name;
            //this.ToChucSearch();
            //this.ThanhVienSearch();
            this.DuAnThuChiSearch();
            //this.DuAnQuyetToanLuyKeSearch();
            //this.DuAnQuyetToanPhanKySearch();
            this.DuAnQuyetToanLuyKeService.List = [];
            this.DuAnQuyetToanPhanKyService.List = [];
          },
          err => {
          },
          () => {
            this.DuAnService.IsShowLoading = false;
          }
        );
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
  DuAnQuyetDinhSave() {
    this.DuAnService.IsShowLoading = true;
    this.DuAnQuyetDinhService.FormData.ParentID = this.DuAnService.FormData.ID;
    this.DuAnQuyetDinhService.FormData.Code = this.DuAnService.FormData.Code;
    this.DuAnQuyetDinhService.SaveAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.FormData = res as DuAnQuyetDinh;
        this.Router.navigateByUrl(environment.DuAnQuyetDinhInfo + this.DuAnService.FormData.ID + "/" + this.DuAnQuyetDinhService.FormData.ID);
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
  DuAnQuyetDinhAdd() {
    this.Router.navigateByUrl(environment.DuAnQuyetDinhInfo + this.DuAnService.FormData.ID + "/" + environment.InitializationNumber);
    this.DuAnQuyetDinhService.BaseParameter.ID = environment.InitializationNumber;
    this.DuAnQuyetDinhSearch();
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
      this.DuAnThuChiService.BaseParameter.DuAnQuyetDinhID = this.DuAnQuyetDinhService.FormData.ID;
      this.DuAnThuChiService.GetByDuAnQuyetDinhIDToListAsync().subscribe(
        res => {
          this.DuAnThuChiService.List = (res as DuAnThuChi[]).sort((a, b) => (a.NgayGhiNhan > b.NgayGhiNhan ? 1 : -1));;
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
          this.DuAnThuChiSearch();
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
        this.DuAnThuChiService.FormData.DuAnQuyetDinhID = this.DuAnQuyetDinhService.FormData.ID;
        this.DuAnThuChiService.FormData.DuAnQuyetDinhSoQuyetDinh = this.DuAnQuyetDinhService.FormData.SoQuyetDinh;
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
      this.DuAnQuyetToanPhanKyService.BaseParameter.DuAnQuyetDinhID = this.DuAnQuyetDinhService.FormData.ID;
      this.DuAnQuyetToanPhanKyService.GetSQLByDuAnQuyetDinhIDToListAsync().subscribe(
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
      this.DuAnQuyetToanLuyKeService.BaseParameter.DuAnQuyetDinhID = this.DuAnQuyetDinhService.FormData.ID;
      this.DuAnQuyetToanLuyKeService.GetSQLByDuAnQuyetDinhIDToListAsync().subscribe(
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

}