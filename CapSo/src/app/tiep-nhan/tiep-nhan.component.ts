import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

@Component({
  selector: 'app-tiep-nhan',
  templateUrl: './tiep-nhan.component.html',
  styleUrls: ['./tiep-nhan.component.css']
})
export class TiepNhanComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,

    public GoiSoService: GoiSoService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) {
  }

  ngOnInit(): void {
    let URL = "Homepage";
    if (this.ActiveRouter.snapshot.routeConfig.path) {
      URL = this.ActiveRouter.snapshot.routeConfig.path;
      URL = URL.split('/')[0]
    }
    URL = environment.TiepNhanURL + URL + "/" + this.ActiveRouter.snapshot.params.DanhMucDichVuCode + "/" + this.ActiveRouter.snapshot.params.DanhMucQuayDichVuCode;
    var Width = window.innerWidth;
    // if (Width > 300) {
    //   this.NotificationService.OpenWindowByURLBottomRight200(URL);
    //   window.close();
    // }
    // else {     
    //   this.DanhMucDichVuSearch();
    //   this.DanhMucQuayDichVuSearch();
    // }
    this.DanhMucDichVuSearch();
    this.DanhMucQuayDichVuSearch();
  }
  DanhMucDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.DanhMucDichVuCode;
    this.DanhMucDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucDichVuService.FormData = res as DanhMucDichVu;
        this.GoiSoService.BaseParameter.DanhMucDichVuID = this.DanhMucDichVuService.FormData.ID;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  DanhMucQuayDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.DanhMucQuayDichVuCode;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData = res as DanhMucQuayDichVu;
        this.GoiSoService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData.ID;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  GoiSoTiepTheo() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoService.BaseParameter.SoHienTai = this.GoiSoService.FormData.SoHienTai;
    this.GoiSoService.GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
    document.getElementById("Code").focus();
  }
  GoiSoChiTietSave() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.SoHienTai = this.GoiSoService.FormData.SoHienTai;
    this.GoiSoChiTietService.BaseParameter.Code = this.GoiSoService.BaseParameter.Code;
    this.GoiSoChiTietService.BaseParameter.DanhMucDichVuID = this.DanhMucDichVuService.FormData.ID;
    this.GoiSoChiTietService.UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync().subscribe(
      res => {
        this.GoiSoChiTietService.FormData = res as GoiSoChiTiet;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
    this.GoiSoService.BaseParameter.Code = environment.InitializationString;
    document.getElementById("Code").focus();
  }
}