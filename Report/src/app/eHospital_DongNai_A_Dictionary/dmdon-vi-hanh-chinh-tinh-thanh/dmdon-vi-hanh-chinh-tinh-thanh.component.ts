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

@Component({
  selector: 'app-dmdon-vi-hanh-chinh-tinh-thanh',
  templateUrl: './dmdon-vi-hanh-chinh-tinh-thanh.component.html',
  styleUrls: ['./dmdon-vi-hanh-chinh-tinh-thanh.component.css']
})
export class DMDonViHanhChinhTinhThanhComponent implements OnInit {

  @ViewChild('DM_DonViHanhChinhSort') DM_DonViHanhChinhSort: MatSort;
  @ViewChild('DM_DonViHanhChinhPaginator') DM_DonViHanhChinhPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_DonViHanhChinhService: DM_DonViHanhChinhService,
  ) { }

  ngOnInit(): void {
    this.DM_DonViHanhChinhSearch();
  }
  DM_DonViHanhChinh001() {
    this.DM_DonViHanhChinhService.DisplayColumns003 = this.DM_DonViHanhChinhService.DisplayColumns001;
  }
  DM_DonViHanhChinh002() {
    this.DM_DonViHanhChinhService.DisplayColumns003 = this.DM_DonViHanhChinhService.DisplayColumns002;
  }
  DM_DonViHanhChinhSearch() {
    if (this.DM_DonViHanhChinhService.BaseParameter.SearchString.length > 0) {
      this.DM_DonViHanhChinhService.BaseParameter.SearchString = this.DM_DonViHanhChinhService.BaseParameter.SearchString.trim();
      if (this.DM_DonViHanhChinhService.DataSource) {
        this.DM_DonViHanhChinhService.DataSource.filter = this.DM_DonViHanhChinhService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_DonViHanhChinhService.BaseParameter.CapDonVi = 2;
      this.DM_DonViHanhChinhService.GetByCapDonViAndEmptyToListAsync().subscribe(
        res => {
          this.DM_DonViHanhChinhService.List = (res as DM_DonViHanhChinh[]);
          this.DM_DonViHanhChinhService.DataSource = new MatTableDataSource(this.DM_DonViHanhChinhService.List);
          this.DM_DonViHanhChinhService.DataSource.sort = this.DM_DonViHanhChinhSort;
          this.DM_DonViHanhChinhService.DataSource.paginator = this.DM_DonViHanhChinhPaginator;
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  DM_DonViHanhChinhSave(element: DM_DonViHanhChinh) {
    this.DM_DonViHanhChinhService.IsShowLoading = true;
    this.DM_DonViHanhChinhService.FormData = element;
    this.DM_DonViHanhChinhService.SaveAsync().subscribe(
      res => {
        this.DM_DonViHanhChinhService.FormData = res as DM_DonViHanhChinh;
        this.DM_DonViHanhChinhSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_DonViHanhChinhService.IsShowLoading = false;
      }
    );
  }
  DM_DonViHanhChinhDelete(element: DM_DonViHanhChinh) {
    this.DM_DonViHanhChinhService.FormData = element;
    this.NotificationService.warn(this.DM_DonViHanhChinhService.ComponentDeleteSearchString(this.DM_DonViHanhChinhSort, this.DM_DonViHanhChinhPaginator));
  }
}