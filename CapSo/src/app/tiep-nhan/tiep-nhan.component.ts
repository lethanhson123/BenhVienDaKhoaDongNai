import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

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
  ) {
  }

  ngOnInit(): void {
    let URL = environment.TiepNhanURL + "TiepNhan/" + this.ActiveRouter.snapshot.params.DanhMucDichVuID + "/" + this.ActiveRouter.snapshot.params.DanhMucQuayDichVuID;
    var Width = window.innerWidth;
    // if (Width > 300) {
    //   this.NotificationService.OpenWindowByURLBottomRight(URL);
    //   window.close();
    // }
    // else {
    //   this.GoiSoService.BaseParameter.DanhMucDichVuID = Number(this.ActiveRouter.snapshot.params.DanhMucDichVuID);
    //   this.GoiSoService.BaseParameter.DanhMucQuayDichVuID = Number(this.ActiveRouter.snapshot.params.DanhMucQuayDichVuID);
    //   this.DanhMucDichVuSearch();
    //   this.DanhMucQuayDichVuSearch();
    // }
    this.GoiSoService.BaseParameter.DanhMucDichVuID = Number(this.ActiveRouter.snapshot.params.DanhMucDichVuID);
    this.GoiSoService.BaseParameter.DanhMucQuayDichVuID = Number(this.ActiveRouter.snapshot.params.DanhMucQuayDichVuID);
    this.DanhMucDichVuSearch();
    this.DanhMucQuayDichVuSearch();
  }
  DanhMucDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucDichVuService.BaseParameter.ID = this.GoiSoService.BaseParameter.DanhMucDichVuID;
    this.DanhMucDichVuService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucDichVuService.FormData = res as DanhMucDichVu;
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
    this.DanhMucQuayDichVuService.BaseParameter.ID = this.GoiSoService.BaseParameter.DanhMucQuayDichVuID;
    this.DanhMucQuayDichVuService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData = res as DanhMucQuayDichVu;
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
    this.GoiSoService.GoiSoTiepTheoAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }

}