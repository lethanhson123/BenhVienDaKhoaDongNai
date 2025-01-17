import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DM_DonViHanhChinh } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.model';
import { DM_DonViHanhChinhService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

@Component({
  selector: 'app-dm-benh-nhan-info',
  templateUrl: './dm-benh-nhan-info.component.html',
  styleUrls: ['./dm-benh-nhan-info.component.css']
})
export class DMBenhNhanInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_DonViHanhChinhService: DM_DonViHanhChinhService,
    public DM_BenhNhanService: DM_BenhNhanService,
  ) { }

  ngOnInit(): void {
    this.DM_BenhNhanService.BaseParameter.BenhNhan_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.DM_BenhNhanSearch();
  }
  DateNgaySinh(value) {
    this.DM_BenhNhanService.FormData.NgaySinh = new Date(value);
  }
  DateNgayCapThe(value) {
    this.DM_BenhNhanService.FormData.NgayCapThe = new Date(value);
  }
  DateCMND_NgayCap(value) {
    this.DM_BenhNhanService.FormData.CMND_NgayCap = new Date(value);
  }
  DateNgayTuVong(value) {
    this.DM_BenhNhanService.FormData.NgayTuVong = new Date(value);
  }
  Lst_Dictionary_TypeSearchQuocTich() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = 33;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListQuocTich = (res as Lst_Dictionary[]);        
      },
      err => {
      },
      () => {
      }
    );
  }
  Lst_Dictionary_TypeSearchDanToc() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = 34;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListDanToc = (res as Lst_Dictionary[]);        
      },
      err => {
      },
      () => {
      }
    );
  }
  Lst_Dictionary_TypeSearchNgheNghiep() {
    this.Lst_DictionaryService.BaseParameter.CapDonVi = 42;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.ListNgheNghiep = (res as Lst_Dictionary[]);        
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DonViHanhChinhSearchTinhThanh() {
    this.DM_DonViHanhChinhService.BaseParameter.CapDonVi = 2;
    this.DM_DonViHanhChinhService.GetByCapDonViToListAsync().subscribe(
      res => {
        this.DM_DonViHanhChinhService.ListTinhThanh = (res as DM_DonViHanhChinh[]).sort((a, b) => (a.TenDonVi > b.TenDonVi ? 1 : -1));
        this.DM_DonViHanhChinhSearchQuanHuyen();
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DonViHanhChinhSearchQuanHuyen() {
    this.DM_DonViHanhChinhService.BaseParameter.CapTren_Id = this.DM_BenhNhanService.FormData.TinhThanh_Id;
    this.DM_DonViHanhChinhService.BaseParameter.CapDonVi = 3;
    this.DM_DonViHanhChinhService.GetByCapDonVi_CapTren_IdToListAsync().subscribe(
      res => {
        this.DM_DonViHanhChinhService.ListQuanHuyen = (res as DM_DonViHanhChinh[]).sort((a, b) => (a.TenDonVi > b.TenDonVi ? 1 : -1));
        this.DM_DonViHanhChinhSearchXaPhuong();
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DonViHanhChinhSearchXaPhuong() {
    this.DM_DonViHanhChinhService.BaseParameter.CapTren_Id = this.DM_BenhNhanService.FormData.QuanHuyen_Id;
    this.DM_DonViHanhChinhService.BaseParameter.CapDonVi = 4;
    this.DM_DonViHanhChinhService.GetByCapDonVi_CapTren_IdToListAsync().subscribe(
      res => {
        this.DM_DonViHanhChinhService.ListXaPhuong = (res as DM_DonViHanhChinh[]).sort((a, b) => (a.TenDonVi > b.TenDonVi ? 1 : -1));        
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.GetByBenhNhan_IdAsync().subscribe(
      res => {
        this.DM_BenhNhanService.FormData = res as DM_BenhNhan;
        if (this.DM_BenhNhanService.FormData.BenhNhan_Id == environment.InitializationNumber) {
        }
        this.DM_DonViHanhChinhSearchTinhThanh();
        this.Lst_Dictionary_TypeSearchQuocTich();
        this.Lst_Dictionary_TypeSearchDanToc();
        this.Lst_Dictionary_TypeSearchNgheNghiep();

      },
      err => {
      }
    );
  }
  DM_BenhNhanSave() {
    this.DM_BenhNhanService.IsShowLoading = true;
    this.DM_BenhNhanService.SaveAsync().subscribe(
      res => {
        this.DM_BenhNhanService.FormData = res as DM_BenhNhan;
        this.Router.navigateByUrl(environment.DMBenhNhanInfo + this.DM_BenhNhanService.FormData.BenhNhan_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BenhNhanService.IsShowLoading = false;
      }
    );
  }
}
