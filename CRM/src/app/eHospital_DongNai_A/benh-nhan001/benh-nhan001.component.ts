import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { TiepNhan } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.model';
import { TiepNhanService } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.service';
import { CLSYeuCau } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau.model';
import { CLSYeuCauService } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau.service';
import { CLSYeuCau_PACS } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_PACS.model';
import { CLSYeuCau_PACSService } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_PACS.service';
import { CLSYeuCau_QMS } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_QMS.model';
import { CLSYeuCau_QMSService } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_QMS.service';
import { CLSYeuCau_ThayDoi } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_ThayDoi.model';
import { CLSYeuCau_ThayDoiService } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCau_ThayDoi.service';
import { CLSYeuCauChiTiet } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCauChiTiet.model';
import { CLSYeuCauChiTietService } from 'src/app/shared/eHospital_DongNai_A/CLSYeuCauChiTiet.service';
import { CLSKetQua } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua.model';
import { CLSKetQuaService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua.service';
import { CLSKetQua_DienCo } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_DienCo.model';
import { CLSKetQua_DienCoService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_DienCo.service';
import { CLSKetQua_Images } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_Images.model';
import { CLSKetQua_ImagesService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_Images.service';
import { CLSKetQua_SieuAmTim } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_SieuAmTim.model';
import { CLSKetQua_SieuAmTimService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_SieuAmTim.service';
import { CLSKetQua_XQ } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_XQ.model';
import { CLSKetQua_XQService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQua_XQ.service';
import { CLSKetQuaKhangSinhDo } from 'src/app/shared/eHospital_DongNai_A/CLSKetQuaKhangSinhDo.model';
import { CLSKetQuaKhangSinhDoService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQuaKhangSinhDo.service';
import { CLSKetQuaChiTiet } from 'src/app/shared/eHospital_DongNai_A/CLSKetQuaChiTiet.model';
import { CLSKetQuaChiTietService } from 'src/app/shared/eHospital_DongNai_A/CLSKetQuaChiTiet.service';
import { KhamBenh } from 'src/app/shared/eHospital_DongNai_A/KhamBenh.model';
import { KhamBenhService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh.service';



@Component({
  selector: 'app-benh-nhan001',
  templateUrl: './benh-nhan001.component.html',
  styleUrls: ['./benh-nhan001.component.css']
})
export class BenhNhan001Component implements OnInit {

  @ViewChild('DM_BenhNhanSort') DM_BenhNhanSort: MatSort;
  @ViewChild('DM_BenhNhanPaginator') DM_BenhNhanPaginator: MatPaginator;
  @ViewChild('TiepNhanSort') TiepNhanSort: MatSort;
  @ViewChild('TiepNhanPaginator') TiepNhanPaginator: MatPaginator;
  @ViewChild('CLSYeuCauSort') CLSYeuCauSort: MatSort;
  @ViewChild('CLSYeuCauPaginator') CLSYeuCauPaginator: MatPaginator;
  @ViewChild('CLSYeuCau_PACSSort') CLSYeuCau_PACSSort: MatSort;
  @ViewChild('CLSYeuCau_PACSPaginator') CLSYeuCau_PACSPaginator: MatPaginator;
  @ViewChild('CLSYeuCau_QMSSort') CLSYeuCau_QMSSort: MatSort;
  @ViewChild('CLSYeuCau_QMSPaginator') CLSYeuCau_QMSPaginator: MatPaginator;
  @ViewChild('CLSYeuCau_ThayDoiSort') CLSYeuCau_ThayDoiSort: MatSort;
  @ViewChild('CLSYeuCau_ThayDoiPaginator') CLSYeuCau_ThayDoiPaginator: MatPaginator;
  @ViewChild('CLSYeuCauChiTietSort') CLSYeuCauChiTietSort: MatSort;
  @ViewChild('CLSYeuCauChiTietPaginator') CLSYeuCauChiTietPaginator: MatPaginator;
  @ViewChild('CLSKetQuaSort') CLSKetQuaSort: MatSort;
  @ViewChild('CLSKetQuaPaginator') CLSKetQuaPaginator: MatPaginator;
  @ViewChild('CLSKetQua_DienCoSort') CLSKetQua_DienCoSort: MatSort;
  @ViewChild('CLSKetQua_DienCoPaginator') CLSKetQua_DienCoPaginator: MatPaginator;
  @ViewChild('CLSKetQua_ImagesSort') CLSKetQua_ImagesSort: MatSort;
  @ViewChild('CLSKetQua_ImagesPaginator') CLSKetQua_ImagesPaginator: MatPaginator;
  @ViewChild('CLSKetQua_SieuAmTimSort') CLSKetQua_SieuAmTimSort: MatSort;
  @ViewChild('CLSKetQua_SieuAmTimPaginator') CLSKetQua_SieuAmTimPaginator: MatPaginator;
  @ViewChild('CLSKetQua_XQSort') CLSKetQua_XQSort: MatSort;
  @ViewChild('CLSKetQua_XQPaginator') CLSKetQua_XQPaginator: MatPaginator;
  @ViewChild('CLSKetQuaKhangSinhDoSort') CLSKetQuaKhangSinhDoSort: MatSort;
  @ViewChild('CLSKetQuaKhangSinhDoPaginator') CLSKetQuaKhangSinhDoPaginator: MatPaginator;
  @ViewChild('CLSKetQuaChiTietSort') CLSKetQuaChiTietSort: MatSort;
  @ViewChild('CLSKetQuaChiTietPaginator') CLSKetQuaChiTietPaginator: MatPaginator;
  @ViewChild('KhamBenhSort') KhamBenhSort: MatSort;
  @ViewChild('KhamBenhPaginator') KhamBenhPaginator: MatPaginator;



  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BenhNhanService: DM_BenhNhanService,

    public TiepNhanService: TiepNhanService,
    public CLSYeuCauService: CLSYeuCauService,
    public CLSYeuCau_PACSService: CLSYeuCau_PACSService,
    public CLSYeuCau_QMSService: CLSYeuCau_QMSService,
    public CLSYeuCau_ThayDoiService: CLSYeuCau_ThayDoiService,
    public CLSYeuCauChiTietService: CLSYeuCauChiTietService,
    public CLSKetQuaService: CLSKetQuaService,
    public CLSKetQua_DienCoService: CLSKetQua_DienCoService,
    public CLSKetQua_ImagesService: CLSKetQua_ImagesService,
    public CLSKetQua_SieuAmTimService: CLSKetQua_SieuAmTimService,
    public CLSKetQua_XQService: CLSKetQua_XQService,
    public CLSKetQuaKhangSinhDoService: CLSKetQuaKhangSinhDoService,
    public CLSKetQuaChiTietService: CLSKetQuaChiTietService,
    public KhamBenhService: KhamBenhService,



  ) { }

  ngOnInit(): void {
    this.StartTimerInterval();
  }
  ngAfterViewInit() {
  }
  StartTimerInterval() {
    setInterval(() => {
      if (this.DM_BenhNhanService.IsShowLoading == true) {
        this.DM_BenhNhanService.IsShowLoading = false;
      }
    }, 10000)
  }
  DateBatDau(value) {
    this.DM_BenhNhanService.BaseParameter.BatDau = new Date(value);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.IsShowLoading = true;
    this.DM_BenhNhanService.GetBySearchStringToListAsync().subscribe(
      res => {
        this.DM_BenhNhanService.List = (res as DM_BenhNhan[]).sort((a, b) => (a.TenBenhNhan > b.TenBenhNhan ? 1 : -1));
        this.DM_BenhNhanService.DataSource = new MatTableDataSource(this.DM_BenhNhanService.List);
        this.DM_BenhNhanService.DataSource.sort = this.DM_BenhNhanSort;
        this.DM_BenhNhanService.DataSource.paginator = this.DM_BenhNhanPaginator;

        if (this.DM_BenhNhanService.List) {
          if (this.DM_BenhNhanService.List.length > 0) {
            this.DM_BenhNhanService.FormData = this.DM_BenhNhanService.List[0];
            this.TiepNhanSearch();
            this.CLSYeuCauSearch();
            this.KhamBenhSearch();

          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  KhamBenhSearch() {
    this.KhamBenhService.BaseParameter.BatDau = this.DM_BenhNhanService.BaseParameter.BatDau;
    this.KhamBenhService.BaseParameter.BenhNhan_Id = this.DM_BenhNhanService.FormData.BenhNhan_Id;
    this.KhamBenhService.GetByBenhNhan_Id_Year_Month_DayToListAsync().subscribe(
      res => {
        this.KhamBenhService.List = (res as KhamBenh[]).sort((a, b) => (a.ThoiGianKham > b.ThoiGianKham ? 1 : -1));
        this.KhamBenhService.DataSource = new MatTableDataSource(this.KhamBenhService.List);
        this.KhamBenhService.DataSource.sort = this.KhamBenhSort;
        this.KhamBenhService.DataSource.paginator = this.KhamBenhPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  TiepNhanSearch() {
    this.TiepNhanService.BaseParameter.BatDau = this.DM_BenhNhanService.BaseParameter.BatDau;
    this.TiepNhanService.BaseParameter.BenhNhan_Id = this.DM_BenhNhanService.FormData.BenhNhan_Id;
    this.TiepNhanService.GetByBenhNhan_Id_Year_Month_DayToListAsync().subscribe(
      res => {
        this.TiepNhanService.List = (res as TiepNhan[]).sort((a, b) => (a.ThoiGianTiepNhan > b.ThoiGianTiepNhan ? 1 : -1));
        this.TiepNhanService.DataSource = new MatTableDataSource(this.TiepNhanService.List);
        this.TiepNhanService.DataSource.sort = this.TiepNhanSort;
        this.TiepNhanService.DataSource.paginator = this.TiepNhanPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSYeuCauSearch() {
    this.CLSYeuCauService.BaseParameter.BatDau = this.DM_BenhNhanService.BaseParameter.BatDau;
    this.CLSYeuCauService.BaseParameter.BenhNhan_Id = this.DM_BenhNhanService.FormData.BenhNhan_Id;
    this.CLSYeuCauService.GetByBenhNhan_Id_Year_Month_DayToListAsync().subscribe(
      res => {
        this.CLSYeuCauService.List = (res as CLSYeuCau[]).sort((a, b) => (a.ThoiGianYeuCau > b.ThoiGianYeuCau ? 1 : -1));
        this.CLSYeuCauService.DataSource = new MatTableDataSource(this.CLSYeuCauService.List);
        this.CLSYeuCauService.DataSource.sort = this.CLSYeuCauSort;
        this.CLSYeuCauService.DataSource.paginator = this.CLSYeuCauPaginator;
        if (this.CLSYeuCauService.List) {
          if (this.CLSYeuCauService.List.length > 0) {
            this.CLSYeuCauService.BaseParameter.ListID = [];
            for (let i = 0; i < this.CLSYeuCauService.List.length; i++) {
              this.CLSYeuCauService.BaseParameter.ListID.push(this.CLSYeuCauService.List[i].CLSYeuCau_Id);
            }
            this.CLSYeuCau_ThayDoiSearch();
            this.CLSYeuCauChiTietSearch();
            this.CLSKetQuaSearch();
            this.CLSKetQua_XQSearch();
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSYeuCau_PACSSearch() {
    this.CLSYeuCau_PACSService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSYeuCau_PACSService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSYeuCau_PACSService.List = (res as CLSYeuCau_PACS[]).sort((a, b) => (a.CLSYeuCau_ID > b.CLSYeuCau_ID ? 1 : -1));
        this.CLSYeuCau_PACSService.DataSource = new MatTableDataSource(this.CLSYeuCau_PACSService.List);
        this.CLSYeuCau_PACSService.DataSource.sort = this.CLSYeuCau_PACSSort;
        this.CLSYeuCau_PACSService.DataSource.paginator = this.CLSYeuCau_PACSPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSYeuCau_QMSSearch() {
    this.CLSYeuCau_QMSService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSYeuCau_QMSService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSYeuCau_QMSService.List = (res as CLSYeuCau_QMS[]).sort((a, b) => (a.CLSYeuCau_Id > b.CLSYeuCau_Id ? 1 : -1));
        this.CLSYeuCau_QMSService.DataSource = new MatTableDataSource(this.CLSYeuCau_QMSService.List);
        this.CLSYeuCau_QMSService.DataSource.sort = this.CLSYeuCau_QMSSort;
        this.CLSYeuCau_QMSService.DataSource.paginator = this.CLSYeuCau_QMSPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSYeuCau_ThayDoiSearch() {
    this.CLSYeuCau_ThayDoiService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSYeuCau_ThayDoiService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSYeuCau_ThayDoiService.List = (res as CLSYeuCau_ThayDoi[]).sort((a, b) => (a.CLSYeuCau_Id > b.CLSYeuCau_Id ? 1 : -1));
        this.CLSYeuCau_ThayDoiService.DataSource = new MatTableDataSource(this.CLSYeuCau_ThayDoiService.List);
        this.CLSYeuCau_ThayDoiService.DataSource.sort = this.CLSYeuCau_ThayDoiSort;
        this.CLSYeuCau_ThayDoiService.DataSource.paginator = this.CLSYeuCau_ThayDoiPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSYeuCauChiTietSearch() {
    this.CLSYeuCauChiTietService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSYeuCauChiTietService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSYeuCauChiTietService.List = (res as CLSYeuCauChiTiet[]).sort((a, b) => (a.CLSYeuCau_Id > b.CLSYeuCau_Id ? 1 : -1));
        this.CLSYeuCauChiTietService.DataSource = new MatTableDataSource(this.CLSYeuCauChiTietService.List);
        this.CLSYeuCauChiTietService.DataSource.sort = this.CLSYeuCauChiTietSort;
        this.CLSYeuCauChiTietService.DataSource.paginator = this.CLSYeuCauChiTietPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQuaSearch() {
    this.CLSKetQuaService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSKetQuaService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQuaService.List = (res as CLSKetQua[]).sort((a, b) => (a.CLSYeuCau_Id > b.CLSYeuCau_Id ? 1 : -1));
        this.CLSKetQuaService.DataSource = new MatTableDataSource(this.CLSKetQuaService.List);
        this.CLSKetQuaService.DataSource.sort = this.CLSKetQuaSort;
        this.CLSKetQuaService.DataSource.paginator = this.CLSKetQuaPaginator;
        if (this.CLSKetQuaService.List) {
          if (this.CLSKetQuaService.List.length > 0) {
            this.CLSKetQuaService.BaseParameter.ListID = [];
            for (let i = 0; i < this.CLSKetQuaService.List.length; i++) {
              this.CLSKetQuaService.BaseParameter.ListID.push(this.CLSKetQuaService.List[i].CLSKetQua_Id);
            }           
            this.CLSKetQua_DienCoSearch();
            this.CLSKetQua_ImagesSearch();
            this.CLSKetQua_SieuAmTimSearch();
            this.CLSKetQuaKhangSinhDoSearch();
            this.CLSKetQuaChiTietSearch();

          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQua_DienCoSearch() {
    this.CLSKetQua_DienCoService.BaseParameter.ListID = this.CLSKetQuaService.BaseParameter.ListID;
    this.CLSKetQua_DienCoService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQua_DienCoService.List = (res as CLSKetQua_DienCo[]).sort((a, b) => (a.CLSKetQua_Id > b.CLSKetQua_Id ? 1 : -1));
        this.CLSKetQua_DienCoService.DataSource = new MatTableDataSource(this.CLSKetQua_DienCoService.List);
        this.CLSKetQua_DienCoService.DataSource.sort = this.CLSKetQua_DienCoSort;
        this.CLSKetQua_DienCoService.DataSource.paginator = this.CLSKetQua_DienCoPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQua_ImagesSearch() {
    this.CLSKetQua_ImagesService.BaseParameter.ListID = this.CLSKetQuaService.BaseParameter.ListID;
    this.CLSKetQua_ImagesService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQua_ImagesService.List = (res as CLSKetQua_Images[]).sort((a, b) => (a.CLSKetQua_Id > b.CLSKetQua_Id ? 1 : -1));
        this.CLSKetQua_ImagesService.DataSource = new MatTableDataSource(this.CLSKetQua_ImagesService.List);
        this.CLSKetQua_ImagesService.DataSource.sort = this.CLSKetQua_ImagesSort;
        this.CLSKetQua_ImagesService.DataSource.paginator = this.CLSKetQua_ImagesPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQua_SieuAmTimSearch() {
    this.CLSKetQua_SieuAmTimService.BaseParameter.ListID = this.CLSKetQuaService.BaseParameter.ListID;
    this.CLSKetQua_SieuAmTimService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQua_SieuAmTimService.List = (res as CLSKetQua_SieuAmTim[]).sort((a, b) => (a.CLSKetQua_Id > b.CLSKetQua_Id ? 1 : -1));
        this.CLSKetQua_SieuAmTimService.DataSource = new MatTableDataSource(this.CLSKetQua_SieuAmTimService.List);
        this.CLSKetQua_SieuAmTimService.DataSource.sort = this.CLSKetQua_SieuAmTimSort;
        this.CLSKetQua_SieuAmTimService.DataSource.paginator = this.CLSKetQua_SieuAmTimPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQua_XQSearch() {
    this.CLSKetQua_XQService.BaseParameter.ListID = this.CLSYeuCauService.BaseParameter.ListID;
    this.CLSKetQua_XQService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQua_XQService.List = (res as CLSKetQua_XQ[]).sort((a, b) => (a.CLSYeuCau_Id > b.CLSYeuCau_Id ? 1 : -1));
        this.CLSKetQua_XQService.DataSource = new MatTableDataSource(this.CLSKetQua_XQService.List);
        this.CLSKetQua_XQService.DataSource.sort = this.CLSKetQua_XQSort;
        this.CLSKetQua_XQService.DataSource.paginator = this.CLSKetQua_XQPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQuaKhangSinhDoSearch() {
    this.CLSKetQuaKhangSinhDoService.BaseParameter.ListID = this.CLSKetQuaService.BaseParameter.ListID;
    this.CLSKetQuaKhangSinhDoService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQuaKhangSinhDoService.List = (res as CLSKetQuaKhangSinhDo[]).sort((a, b) => (a.CLSKetQua_Id > b.CLSKetQua_Id ? 1 : -1));
        this.CLSKetQuaKhangSinhDoService.DataSource = new MatTableDataSource(this.CLSKetQuaKhangSinhDoService.List);
        this.CLSKetQuaKhangSinhDoService.DataSource.sort = this.CLSKetQuaKhangSinhDoSort;
        this.CLSKetQuaKhangSinhDoService.DataSource.paginator = this.CLSKetQuaKhangSinhDoPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  CLSKetQuaChiTietSearch() {
    this.CLSKetQuaChiTietService.BaseParameter.ListID = this.CLSKetQuaService.BaseParameter.ListID;
    this.CLSKetQuaChiTietService.GetByListIDToListAsync().subscribe(
      res => {
        this.CLSKetQuaChiTietService.List = (res as CLSKetQuaChiTiet[]).sort((a, b) => (a.CLSKetQua_Id > b.CLSKetQua_Id ? 1 : -1));
        this.CLSKetQuaChiTietService.DataSource = new MatTableDataSource(this.CLSKetQuaChiTietService.List);
        this.CLSKetQuaChiTietService.DataSource.sort = this.CLSKetQuaChiTietSort;
        this.CLSKetQuaChiTietService.DataSource.paginator = this.CLSKetQuaChiTietPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
}
