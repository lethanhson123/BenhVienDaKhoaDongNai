import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { QuanLyCongViec } from 'src/app/shared/QuanLyCongViec.model';
import { QuanLyCongViecService } from 'src/app/shared/QuanLyCongViec.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';
import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

@Component({
  selector: 'app-quan-ly-cong-viec',
  templateUrl: './quan-ly-cong-viec.component.html',
  styleUrls: ['./quan-ly-cong-viec.component.css']
})
export class QuanLyCongViecComponent implements OnInit {

  @ViewChild('QuanLyCongViecSort') QuanLyCongViecSort: MatSort;
  @ViewChild('QuanLyCongViecPaginator') QuanLyCongViecPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public QuanLyCongViecService: QuanLyCongViecService,

    public DM_PhongBanService: DM_PhongBanService,
    public ThanhVienService: ThanhVienService,

  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DM_PhongBanSearch();
    this.ThanhVienSearch();
    this.QuanLyCongViecSearch();
  }
  DateNgayGhiNhan(element: QuanLyCongViec, value) {
    element.NgayGhiNhan = new Date(value);
  }
  DateNgayDuyet(element: QuanLyCongViec, value) {
    element.NgayDuyet = new Date(value);
  }
  DateNgayTrienKhai(element: QuanLyCongViec, value) {
    element.NgayTrienKhai = new Date(value);
  }
  DateNgayHetHan(element: QuanLyCongViec, value) {
    element.NgayHetHan = new Date(value);
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListAsync(this.ThanhVienService);
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
  QuanLyCongViecSearch() {
    this.QuanLyCongViecService.SearchAll(this.QuanLyCongViecSort, this.QuanLyCongViecPaginator);
  }
  QuanLyCongViecSave(element: QuanLyCongViec) {
    let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == element.ParentID);
    if (DM_PhongBan) {
      if (DM_PhongBan.length > 0) {
        element.ParentName = DM_PhongBan[0].MaPhongBan + " - " + DM_PhongBan[0].TenPhongBan;
      }
    }    
    this.QuanLyCongViecService.FormData = element;
    this.NotificationService.warn(this.QuanLyCongViecService.ComponentSaveAll(this.QuanLyCongViecSort, this.QuanLyCongViecPaginator));
  }
  QuanLyCongViecDelete(element: QuanLyCongViec) {
    this.QuanLyCongViecService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.QuanLyCongViecService.ComponentDeleteAll(this.QuanLyCongViecSort, this.QuanLyCongViecPaginator));
  }
}