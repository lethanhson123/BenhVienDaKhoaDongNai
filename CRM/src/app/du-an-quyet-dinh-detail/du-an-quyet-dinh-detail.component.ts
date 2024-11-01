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
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { DuAnThuChiService } from 'src/app/shared/DuAnThuChi.service';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';
import { DuAnQuyetToanPhanKy } from 'src/app/shared/DuAnQuyetToanPhanKy.model';
import { DuAnQuyetToanPhanKyService } from 'src/app/shared/DuAnQuyetToanPhanKy.service';
import { DuAnQuyetToanLuyKe } from 'src/app/shared/DuAnQuyetToanLuyKe.model';
import { DuAnQuyetToanLuyKeService } from 'src/app/shared/DuAnQuyetToanLuyKe.service';
import { DuAnThuChiDetailComponent } from '../du-an-thu-chi-detail/du-an-thu-chi-detail.component';


@Component({
  selector: 'app-du-an-quyet-dinh-detail',
  templateUrl: './du-an-quyet-dinh-detail.component.html',
  styleUrls: ['./du-an-quyet-dinh-detail.component.css']
})
export class DuAnQuyetDinhDetailComponent implements OnInit {

  @ViewChild('DuAnThuChiSort') DuAnThuChiSort: MatSort;
  @ViewChild('DuAnThuChiPaginator') DuAnThuChiPaginator: MatPaginator;

  @ViewChild('DuAnQuyetToanLuyKeSort') DuAnQuyetToanLuyKeSort: MatSort;
  @ViewChild('DuAnQuyetToanLuyKePaginator') DuAnQuyetToanLuyKePaginator: MatPaginator; 

  @ViewChild('DuAnQuyetToanPhanKySort') DuAnQuyetToanPhanKySort: MatSort;
  @ViewChild('DuAnQuyetToanPhanKyPaginator') DuAnQuyetToanPhanKyPaginator: MatPaginator; 

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DuAnQuyetDinhDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
    public ToChucService: ToChucService,

    public DuAnService: DuAnService,
    public DuAnThuChiService: DuAnThuChiService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnQuyetToanPhanKyService: DuAnQuyetToanPhanKyService,
    public DuAnQuyetToanLuyKeService: DuAnQuyetToanLuyKeService,

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
        this.DuAnThuChiSearch();
        this.DuAnQuyetToanLuyKeSearch();
        this.DuAnQuyetToanPhanKySearch();
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

  DuAnThuChiSearch() {
    if (this.DuAnThuChiService.BaseParameter.SearchString.length > 0) {
      this.DuAnThuChiService.BaseParameter.SearchString = this.DuAnThuChiService.BaseParameter.SearchString.trim();
      if (this.DuAnThuChiService.DataSource) {
        this.DuAnThuChiService.DataSource.filter = this.DuAnThuChiService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DuAnService.IsShowLoading = true;      
      this.DuAnThuChiService.BaseParameter.SoQuyetDinh = this.DuAnQuyetDinhService.FormData.SoQuyetDinh;
      this.DuAnThuChiService.GetBySoQuyetDinhToListAsync().subscribe(
        res => {
          this.DuAnThuChiService.List = (res as DuAnThuChi[]).sort((a, b) => (a.NgayGhiNhan > b.NgayGhiNhan ? 1 : -1));;          
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
        const dialogConfig = new MatDialogConfig();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        dialogConfig.width = environment.DialogConfigWidth;
        dialogConfig.data = { ID: ID };
        const dialog = this.Dialog.open(DuAnThuChiDetailComponent, dialogConfig);
        dialog.afterClosed().subscribe(() => {
          this.DuAnThuChiSearch();
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
      this.DuAnQuyetToanPhanKyService.BaseParameter.SoQuyetDinh = this.DuAnQuyetDinhService.FormData.SoQuyetDinh;
      this.DuAnQuyetToanPhanKyService.GetBySoQuyetDinhToListAsync().subscribe(
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
      this.DuAnQuyetToanLuyKeService.BaseParameter.SoQuyetDinh = this.DuAnQuyetDinhService.FormData.SoQuyetDinh;
      this.DuAnQuyetToanLuyKeService.GetBySoQuyetDinhToListAsync().subscribe(
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

  DuAnQuyetToanLuyKeActiveChange(element: DuAnQuyetToanLuyKe) {
    this.DuAnQuyetDinhService.IsShowLoading = true;    
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
        this.DuAnQuyetDinhService.IsShowLoading = false;
      }
    );
  }

  DuAnQuyetToanPhanKyActiveChange(element: DuAnQuyetToanPhanKy) {
    this.DuAnQuyetDinhService.IsShowLoading = true;    
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
        this.DuAnQuyetDinhService.IsShowLoading = false;
      }
    );
  }

}
