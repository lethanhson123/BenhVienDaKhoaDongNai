import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_DonViHanhChinh } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.model';
import { DM_DonViHanhChinhService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

@Component({
  selector: 'app-dm-benh-nhan',
  templateUrl: './dm-benh-nhan.component.html',
  styleUrls: ['./dm-benh-nhan.component.css']
})
export class DMBenhNhanComponent implements OnInit {

  @ViewChild('DM_BenhNhanSort') DM_BenhNhanSort: MatSort;
  @ViewChild('DM_BenhNhanPaginator') DM_BenhNhanPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_DonViHanhChinhService: DM_DonViHanhChinhService,
    public DM_BenhNhanService: DM_BenhNhanService,
  ) { }

  ngOnInit(): void {

  }
  ngAfterViewInit() {
    this.DM_DonViHanhChinhSearchTinhThanh();
    this.DM_BenhNhanSearch();
  }

  DM_DonViHanhChinhSearchTinhThanh() {
    this.DM_DonViHanhChinhService.BaseParameter.CapDonVi = 2;
    this.DM_DonViHanhChinhService.GetByCapDonViToListAsync().subscribe(
      res => {
        this.DM_DonViHanhChinhService.ListTinhThanh = (res as DM_DonViHanhChinh[]).sort((a, b) => (a.TenDonVi > b.TenDonVi ? 1 : -1));
        //this.DM_BenhNhanService.BaseParameter.TinhThanh_Id = environment.TinhThanhIDDongNai;
        this.DM_DonViHanhChinhSearchQuanHuyen();
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DonViHanhChinhSearchQuanHuyen() {
    this.DM_DonViHanhChinhService.BaseParameter.CapTren_Id = this.DM_BenhNhanService.BaseParameter.TinhThanh_Id;
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
    this.DM_DonViHanhChinhService.BaseParameter.CapTren_Id = this.DM_BenhNhanService.BaseParameter.QuanHuyen_Id;
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
    this.DM_BenhNhanService.IsShowLoading = true;
    this.DM_BenhNhanService.BaseParameter.Page = 0;
    this.DM_BenhNhanService.GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToCountAsync().subscribe(
      res => {
        let PageCount = (res as number);
        for (let i = 0; i <= PageCount; i++) {
          this.DM_BenhNhanService.IsShowLoading = true;
          this.DM_BenhNhanService.BaseParameter.Page = i;
          this.DM_BenhNhanService.GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToListAsync().subscribe(
            res => {
              if (res) {
                let List = (res as DM_BenhNhan[]);
                if (List) {
                  if (this.DM_BenhNhanService.BaseParameter.SearchString.length > 0) {
                    this.DM_BenhNhanService.List = List;
                  }
                  else {
                    for (let j = 0; j < List.length; j++) {
                      this.DM_BenhNhanService.List.push(List[j]);
                    }
                  }
                  this.DM_BenhNhanService.List = this.DM_BenhNhanService.List.sort((a, b) => (a.TenBenhNhan > b.TenBenhNhan ? 1 : -1));
                  this.DM_BenhNhanService.DataSource = new MatTableDataSource(this.DM_BenhNhanService.List);
                  this.DM_BenhNhanService.DataSource.sort = this.DM_BenhNhanSort;
                  this.DM_BenhNhanService.DataSource.paginator = this.DM_BenhNhanPaginator;
                }
              }
            },
            err => {
            },
            () => {
              this.DM_BenhNhanService.IsShowLoading = false;
            }
          );
        }
        if (PageCount == environment.InitializationNumber) {
          this.DM_BenhNhanService.IsShowLoading = false;
        }

      },
      err => {
      },
      () => {
      }
    );
  }
}
