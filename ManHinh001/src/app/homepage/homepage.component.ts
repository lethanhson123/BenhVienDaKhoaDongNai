import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { ManHinhThongBao } from 'src/app/shared/ManHinhThongBao.model';
import { ManHinhThongBaoService } from 'src/app/shared/ManHinhThongBao.service';
import { ManHinhTapTinDinhKem } from 'src/app/shared/ManHinhTapTinDinhKem.model';
import { ManHinhTapTinDinhKemService } from 'src/app/shared/ManHinhTapTinDinhKem.service';

import { GoiSoThamSo } from 'src/app/shared/GoiSoThamSo.model';
import { GoiSoThamSoService } from 'src/app/shared/GoiSoThamSo.service';

import { interval } from 'rxjs';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  videoSrc: string = environment.InitializationString;
  ManHinhTapTinDinhKemIndex: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemInterval: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemIntervalIndex: number = environment.InitializationNumber;

  ManHinhThongBaoIndex: number = environment.InitializationNumber;
  IsBHYT: boolean = true;
  constructor(
    public ActiveRouter: ActivatedRoute,
    public DownloadService: DownloadService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,

  ) { }

  ngOnInit(): void {
    this.DanhMucQuayDichVuSearch();
    this.StartTimerInterval();
  }
  StartTimerInterval() {
    setInterval(() => {
      console.log(this.DanhMucQuayDichVuService.FormData01);
      this.DanhMucQuayDichVuSearch();
    }, this.DanhMucQuayDichVuService.FormData01.Interval * 1000)
  }
  DanhMucQuayDichVuSearch() {
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code01;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData01 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData01) {
          if (this.DanhMucQuayDichVuService.FormData01.ID > 0) {
            if (this.DanhMucQuayDichVuService.FormData01.Active) {             
              if (this.DanhMucQuayDichVuService.FormData01.Interval == null) {
                this.DanhMucQuayDichVuService.FormData01.Interval = environment.Interval15;
              }

              this.GoiSoChiTietService.BaseParameter.Code = this.DanhMucQuayDichVuService.FormData01.Code;
              this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
              this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan04_001ToListAsync().subscribe(
                res => {
                  this.GoiSoChiTietService.List01 = (res as GoiSoChiTiet[]).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                  for (let i = 0; i < this.GoiSoChiTietService.List01.length; i++) {
                    if (this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString) {
                    }
                    else {
                      this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString = "0000";
                    }
                  }
                },
                err => {
                },
                () => {
                }
              );      
            }
          }
        }
      },
      err => {
      },
      () => {
      }
    );

    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code02;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData02 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData02) {
          if (this.DanhMucQuayDichVuService.FormData02.ID > 0) {
            if (this.DanhMucQuayDichVuService.FormData02.Active) {
              this.GoiSoChiTietService.BaseParameter.Code = this.DanhMucQuayDichVuService.FormData02.Code;
              this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
              this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan04_001ToListAsync().subscribe(
                res => {
                  this.GoiSoChiTietService.List02 = (res as GoiSoChiTiet[]).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                  for (let i = 0; i < this.GoiSoChiTietService.List02.length; i++) {
                    if (this.GoiSoChiTietService.List02[i].NgayTiepNhanSoThuTuString) {
                    }
                    else {
                      this.GoiSoChiTietService.List02[i].NgayTiepNhanSoThuTuString = "0000";
                    }
                  }
                },
                err => {
                },
                () => {
                }
              );
            }
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }



}