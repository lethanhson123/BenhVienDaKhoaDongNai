import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhachHang } from 'src/app/shared/KhachHang.model';
import { KhachHangService } from 'src/app/shared/KhachHang.service';
import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

@Component({
  selector: 'app-khach-hang-info',
  templateUrl: './khach-hang-info.component.html',
  styleUrls: ['./khach-hang-info.component.css']
})
export class KhachHangInfoComponent implements OnInit {

  @ViewChild('GoiSoChiTietSort') GoiSoChiTietSort: MatSort;
  @ViewChild('GoiSoChiTietPaginator') GoiSoChiTietPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhachHangService: KhachHangService,
    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.KhachHangService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);    
    this.KhachHangSearch();
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.GetAllToListAsync().subscribe(
      res => {
        this.DanhMucTinhThanhService.List = (res as DanhMucTinhThanh[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));     
        this.DanhMucQuanHuyenSearch();        
      },
      err => {
      },
      () => {       
      }
    );    
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.BaseParameter.ParentID = this.KhachHangService.FormData.DanhMucTinhThanhID;    
    this.DanhMucQuanHuyenService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucQuanHuyenService.List = (res as DanhMucQuanHuyen[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));     
        this.DanhMucXaPhuongSearch();        
      },
      err => {
      },
      () => {       
      }
    );    
  }
  DanhMucXaPhuongSearch() {    
    this.DanhMucXaPhuongService.BaseParameter.ParentID = this.KhachHangService.FormData.DanhMucQuanHuyenID;
    this.DanhMucXaPhuongService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucXaPhuongService.List = (res as DanhMucXaPhuong[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));                
      },
      err => {
      },
      () => {       
      }
    );    
  }
  DateNgaySinh(value) {
    this.KhachHangService.FormData.NgaySinh = new Date(value);
  }
  KhachHangSearch() {
    this.KhachHangService.IsShowLoading = true;
    this.KhachHangService.GetByIDAsync().subscribe(
      res => {
        this.KhachHangService.FormData = res as KhachHang;
        this.DanhMucTinhThanhSearch();     
        this.GoiSoChiTietSearch();  
      },
      err => {
      },
      () => {
        this.KhachHangService.IsShowLoading = false;
      }
    );
  }
  KhachHangSave() {
    this.KhachHangService.IsShowLoading = true;
    this.KhachHangService.SaveAsync().subscribe(
      res => {
        this.KhachHangService.FormData = res as KhachHang;
        this.Router.navigateByUrl(environment.KhachHangInfo + this.KhachHangService.FormData.ID);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.KhachHangService.IsShowLoading = false;
      }
    );
  }
  KhachHangAdd() {
    this.Router.navigateByUrl(environment.KhachHangInfo + environment.InitializationNumber);
    this.KhachHangService.BaseParameter.ID = environment.InitializationNumber;
    this.KhachHangSearch();
  }
  GoiSoChiTietSearch() {
    this.KhachHangService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.KhachHangID = this.KhachHangService.FormData.ID;
    this.GoiSoChiTietService.GetByKhachHangIDToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
        this.GoiSoChiTietService.DataSource = new MatTableDataSource(this.GoiSoChiTietService.List);
        this.GoiSoChiTietService.DataSource.sort = this.GoiSoChiTietSort;
        this.GoiSoChiTietService.DataSource.paginator = this.GoiSoChiTietPaginator;
      },
      err => {
      },
      () => {
        this.KhachHangService.IsShowLoading = false;
      }
    );
  }
}