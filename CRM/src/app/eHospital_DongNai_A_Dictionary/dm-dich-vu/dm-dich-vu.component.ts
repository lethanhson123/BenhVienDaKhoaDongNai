import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { DM_NhomDichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_NhomDichVu.model';
import { DM_NhomDichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_NhomDichVu.service';

@Component({
  selector: 'app-dm-dich-vu',
  templateUrl: './dm-dich-vu.component.html',
  styleUrls: ['./dm-dich-vu.component.css']
})
export class DMDichVuComponent implements OnInit {

  @ViewChild('DM_DichVuSort') DM_DichVuSort: MatSort;
  @ViewChild('DM_DichVuPaginator') DM_DichVuPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_DichVuService: DM_DichVuService,
    public DM_NhomDichVuService: DM_NhomDichVuService,
  ) { }

  ngOnInit(): void {
    this.DM_NhomDichVuSearch();
  }
  DM_NhomDichVuSearch() {
    this.DM_NhomDichVuService.ComponentGetAllToListAsync(this.DM_DichVuService);
  }
  DM_NhomDichVuFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_NhomDichVuService.ListFilter = this.DM_NhomDichVuService.List.filter(item => item.TenNhomDichVu.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaNhomDichVu.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_NhomDichVuService.ListFilter = this.DM_NhomDichVuService.List;
    }
  }
  DM_DichVuSearch() {
    if (this.DM_DichVuService.BaseParameter.SearchString.length > 0) {
      this.DM_DichVuService.BaseParameter.SearchString = this.DM_DichVuService.BaseParameter.SearchString.trim();
      if (this.DM_DichVuService.DataSource) {
        this.DM_DichVuService.DataSource.filter = this.DM_DichVuService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_DichVuService.IsShowLoading = true;
      this.DM_DichVuService.GetByNhomDichVu_IdAndEmptyToListAsync().subscribe(
        res => {
          this.DM_DichVuService.List = (res as any[]);
          //this.DM_DichVuService.List = (res as DM_DichVu[]).sort((a, b) => (a.CapTren_Id > b.CapTren_Id ? 1 : -1));
          this.DM_DichVuService.DataSource = new MatTableDataSource(this.DM_DichVuService.List);
          this.DM_DichVuService.DataSource.sort = this.DM_DichVuSort;
          this.DM_DichVuService.DataSource.paginator = this.DM_DichVuPaginator;
        },
        err => {
        },
        () => {
          this.DM_DichVuService.IsShowLoading = false;
        }
      );
    }
  }
  DM_DichVuSave(element: DM_DichVu) {
    this.DM_DichVuService.FormData = element;
    this.NotificationService.warn(this.DM_DichVuService.ComponentSaveAll(this.DM_DichVuSort, this.DM_DichVuPaginator));
  }
  DM_DichVuDelete(element: DM_DichVu) {
    this.DM_DichVuService.FormData = element;
    this.NotificationService.warn(this.DM_DichVuService.ComponentDeleteAll(this.DM_DichVuSort, this.DM_DichVuPaginator));
  }
}
