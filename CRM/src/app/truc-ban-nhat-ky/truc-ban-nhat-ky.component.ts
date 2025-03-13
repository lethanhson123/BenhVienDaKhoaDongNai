import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TrucBanNhatKy } from 'src/app/shared/TrucBanNhatKy.model';
import { TrucBanNhatKyService } from 'src/app/shared/TrucBanNhatKy.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

@Component({
  selector: 'app-truc-ban-nhat-ky',
  templateUrl: './truc-ban-nhat-ky.component.html',
  styleUrls: ['./truc-ban-nhat-ky.component.css']
})
export class TrucBanNhatKyComponent implements OnInit {

  @ViewChild('TrucBanNhatKySort') TrucBanNhatKySort: MatSort;
  @ViewChild('TrucBanNhatKyPaginator') TrucBanNhatKyPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TrucBanNhatKyService: TrucBanNhatKyService,

    public DM_PhongBanService: DM_PhongBanService,

  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DM_PhongBanSearch();
    this.TrucBanNhatKySearch();
  }
  DateNgayGhiNhan(element: TrucBanNhatKy, value) {
    element.NgayGhiNhan = new Date(value);
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  DM_PhongBanFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List.filter(item => item.TenPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List;
    }
  }
  TrucBanNhatKySearch() {
    this.TrucBanNhatKyService.SearchAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator);
  }
  TrucBanNhatKySave(element: TrucBanNhatKy) {
    let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == element.ParentID);
    if (DM_PhongBan) {
      if (DM_PhongBan.length > 0) {
        element.Khoa = DM_PhongBan[0].MaPhongBan + " - " + DM_PhongBan[0].TenPhongBan;
      }
    }
    this.TrucBanNhatKyService.FormData = element;
    this.NotificationService.warn(this.TrucBanNhatKyService.ComponentSaveAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator));
  }
  TrucBanNhatKyDelete(element: TrucBanNhatKy) {
    this.TrucBanNhatKyService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.TrucBanNhatKyService.ComponentDeleteAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator));
  }
}