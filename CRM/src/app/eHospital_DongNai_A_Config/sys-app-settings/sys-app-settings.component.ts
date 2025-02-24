import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_AppSettings } from 'src/app/shared/eHospital_DongNai_A_Config/Sys_AppSettings.model';
import { Sys_AppSettingsService } from 'src/app/shared/eHospital_DongNai_A_Config/Sys_AppSettings.service';

@Component({
  selector: 'app-sys-app-settings',
  templateUrl: './sys-app-settings.component.html',
  styleUrls: ['./sys-app-settings.component.css']
})
export class SysAppSettingsComponent implements OnInit {

  @ViewChild('Sys_AppSettingsSort') Sys_AppSettingsSort: MatSort;
  @ViewChild('Sys_AppSettingsPaginator') Sys_AppSettingsPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_AppSettingsService: Sys_AppSettingsService,
  ) { }

  ngOnInit(): void {
    this.Sys_AppSettingsSearch();
  }
  IsSoNgayDuyetThuocChange() {
    if (this.Sys_AppSettingsService.BaseParameter.IsSoNgayDuyetThuoc == true) {
      this.Sys_AppSettingsService.BaseParameter.SearchString = environment.SoNgayDuyetThuoc;
    }
    else {
      this.Sys_AppSettingsService.BaseParameter.SearchString = environment.InitializationString;
    }
    this.Sys_AppSettingsSearch();
  }
  IsVienPhiNgoaiTruChange() {
    if (this.Sys_AppSettingsService.BaseParameter.IsVienPhiNgoaiTru == true) {
      this.Sys_AppSettingsService.BaseParameter.SearchString = environment.VienPhiNgoaiTru_ThoiGianLayDanhSachChiDinh_MAX;
    }
    else {
      this.Sys_AppSettingsService.BaseParameter.SearchString = environment.InitializationString;
    }
    this.Sys_AppSettingsSearch();
  }
  Sys_AppSettingsSearch() {
    this.Sys_AppSettingsService.SearchAll(this.Sys_AppSettingsSort, this.Sys_AppSettingsPaginator);
  }
  Sys_AppSettingsSave(element: Sys_AppSettings) {
    this.Sys_AppSettingsService.FormData = element;
    this.NotificationService.warn(this.Sys_AppSettingsService.ComponentSaveAll(this.Sys_AppSettingsSort, this.Sys_AppSettingsPaginator));
  }
  Sys_AppSettingsDelete(element: Sys_AppSettings) {
    this.Sys_AppSettingsService.FormData = element;
    this.NotificationService.warn(this.Sys_AppSettingsService.ComponentDeleteAll(this.Sys_AppSettingsSort, this.Sys_AppSettingsPaginator));
  }
  Sys_AppSettingsKhoiPhuc() {
    this.Sys_AppSettingsService.IsShowLoading = true;
    this.Sys_AppSettingsService.KhoiPhucAsync().subscribe(
      res => {
        this.Sys_AppSettingsService.List = (res as Sys_AppSettings[]);
        this.Sys_AppSettingsService.DataSource = new MatTableDataSource(this.Sys_AppSettingsService.List);
        this.Sys_AppSettingsService.DataSource.sort = this.Sys_AppSettingsSort;
        this.Sys_AppSettingsService.DataSource.paginator = this.Sys_AppSettingsPaginator;
      },
      err => {
      },
      () => {
        this.Sys_AppSettingsService.IsShowLoading = false;
      }
    );
  }
}