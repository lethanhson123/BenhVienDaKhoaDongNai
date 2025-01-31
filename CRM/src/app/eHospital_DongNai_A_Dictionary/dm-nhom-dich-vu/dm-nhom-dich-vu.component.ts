import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_NhomDichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_NhomDichVu.model';
import { DM_NhomDichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_NhomDichVu.service';

import { DM_LoaiDichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiDichVu.model';
import { DM_LoaiDichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiDichVu.service';

@Component({
  selector: 'app-dm-nhom-dich-vu',
  templateUrl: './dm-nhom-dich-vu.component.html',
  styleUrls: ['./dm-nhom-dich-vu.component.css']
})
export class DMNhomDichVuComponent implements OnInit {

  @ViewChild('DM_NhomDichVuSort') DM_NhomDichVuSort: MatSort;
  @ViewChild('DM_NhomDichVuPaginator') DM_NhomDichVuPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_NhomDichVuService: DM_NhomDichVuService,

    public DM_LoaiDichVuService: DM_LoaiDichVuService,
  ) { }

  ngOnInit(): void {
    this.DM_LoaiDichVuSearch();
    this.DM_NhomDichVuSearch001();
  }
  DM_LoaiDichVuSearch() {
    this.DM_LoaiDichVuService.ComponentGetAllToListAsync(this.DM_NhomDichVuService);
  }
  DM_NhomDichVuSearch001() {
    this.DM_NhomDichVuService.GetAllToListAsync().subscribe(
      res => {
        this.DM_NhomDichVuService.ListFilter = (res as any[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_NhomDichVuSearch() {
    if (this.DM_NhomDichVuService.BaseParameter.SearchString.length > 0) {
      this.DM_NhomDichVuService.BaseParameter.SearchString = this.DM_NhomDichVuService.BaseParameter.SearchString.trim();
      if (this.DM_NhomDichVuService.DataSource) {
        this.DM_NhomDichVuService.DataSource.filter = this.DM_NhomDichVuService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_NhomDichVuService.IsShowLoading = true;
      this.DM_NhomDichVuService.GetByLoaiDichVu_IdAndEmptyToListAsync().subscribe(
        res => {
          this.DM_NhomDichVuService.List = (res as any[]);
          //this.DM_NhomDichVuService.List = (res as DM_NhomDichVu[]).sort((a, b) => (a.CapTren_Id > b.CapTren_Id ? 1 : -1));
          this.DM_NhomDichVuService.DataSource = new MatTableDataSource(this.DM_NhomDichVuService.List);
          this.DM_NhomDichVuService.DataSource.sort = this.DM_NhomDichVuSort;
          this.DM_NhomDichVuService.DataSource.paginator = this.DM_NhomDichVuPaginator;
        },
        err => {
        },
        () => {
          this.DM_NhomDichVuService.IsShowLoading = false;
        }
      );
    }
  }
  DM_NhomDichVuSave(element: DM_NhomDichVu) {
    this.DM_NhomDichVuService.FormData = element;
    this.NotificationService.warn(this.DM_NhomDichVuService.ComponentSaveAll(this.DM_NhomDichVuSort, this.DM_NhomDichVuPaginator));
  }
  DM_NhomDichVuDelete(element: DM_NhomDichVu) {
    this.DM_NhomDichVuService.FormData = element;
    this.NotificationService.warn(this.DM_NhomDichVuService.ComponentDeleteAll(this.DM_NhomDichVuSort, this.DM_NhomDichVuPaginator));
  }
}
