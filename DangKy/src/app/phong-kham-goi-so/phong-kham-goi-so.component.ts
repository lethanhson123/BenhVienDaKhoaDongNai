import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { DanhMucPhongKham } from 'src/app/shared/DanhMucPhongKham.model';
import { DanhMucPhongKhamService } from 'src/app/shared/DanhMucPhongKham.service';

@Component({
  selector: 'app-phong-kham-goi-so',
  templateUrl: './phong-kham-goi-so.component.html',
  styleUrls: ['./phong-kham-goi-so.component.css']
})
export class PhongKhamGoiSoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,
    
    public DanhMucPhongKhamService: DanhMucPhongKhamService,

    public GoiSoService: GoiSoService,
  ) {
  }

  ngOnInit(): void {
    let URL = environment.TiepNhanURL + "PhongKhamGoiSo/" + this.ActiveRouter.snapshot.params.DanhMucPhongKhamID;
    var Width = window.innerWidth;
    if (Width > 300) {
      this.NotificationService.OpenWindowByURLBottomRight(URL);
      window.close();
    }
    else {
      this.GoiSoService.BaseParameter.DanhMucPhongKhamID = Number(this.ActiveRouter.snapshot.params.DanhMucPhongKhamID);      
      this.DanhMucPhongKhamSearch();      
    }
  }
  DanhMucPhongKhamSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucPhongKhamService.BaseParameter.ID = this.GoiSoService.BaseParameter.DanhMucPhongKhamID;
    this.DanhMucPhongKhamService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucPhongKhamService.FormData = res as DanhMucPhongKham;
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
    this.GoiSoService.GoiSoTiepTheoByDanhMucPhongKhamIDAsync().subscribe(
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