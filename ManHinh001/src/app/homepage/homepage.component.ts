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

    public ManHinhThongBaoService: ManHinhThongBaoService,
    public ManHinhTapTinDinhKemService: ManHinhTapTinDinhKemService,
    public GoiSoThamSoService: GoiSoThamSoService,

  ) { }

  ngOnInit(): void {
    this.GoiSoThamSoSearch();
    this.ManHinhThongBaoSearch();
    this.ManHinhTapTinDinhKemSearch();

    this.StartTimerInterval();
    this.StartTimer600000();

    interval(environment.Interval).subscribe((x) => {
      this.ManHinhTapTinDinhKemIntervalIndex = this.ManHinhTapTinDinhKemIntervalIndex + 1;
      this.ManHinhTapTinDinhKemInterval = environment.Interval * this.ManHinhTapTinDinhKemIntervalIndex / 1000;

      if (this.ManHinhTapTinDinhKemIndex >= this.ManHinhTapTinDinhKemService.List.length) {
        this.ManHinhTapTinDinhKemIndex = environment.InitializationNumber;
      }
      if (this.ManHinhTapTinDinhKemInterval >= this.ManHinhTapTinDinhKemService.FormData.TongSoGiay) {
        if (this.ManHinhTapTinDinhKemIndex < this.ManHinhTapTinDinhKemService.List.length) {
          this.ManHinhTapTinDinhKemService.FormData = this.ManHinhTapTinDinhKemService.List[this.ManHinhTapTinDinhKemIndex];
          this.videoSrc = this.ManHinhTapTinDinhKemService.FormData.FileName;
          this.ManHinhTapTinDinhKemIndex = this.ManHinhTapTinDinhKemIndex + 1;
          this.ManHinhTapTinDinhKemIntervalIndex = environment.InitializationNumber;
        }
      }
    });

    interval(60000).subscribe((x) => {
      if (this.ManHinhThongBaoIndex >= this.ManHinhThongBaoService.List.length) {
        this.ManHinhThongBaoIndex = environment.InitializationNumber;
      }
      if (this.ManHinhThongBaoIndex < this.ManHinhThongBaoService.List.length) {
        this.ManHinhThongBaoService.FormData = this.ManHinhThongBaoService.List[this.ManHinhThongBaoIndex];
        this.ManHinhThongBaoIndex = this.ManHinhThongBaoIndex + 1;
      }
    });
  }

  GoiSoThamSoSearch() {
    this.GoiSoThamSoService.BaseParameter.ID = environment.GoiSoThamSoID;
    this.GoiSoThamSoService.GetByIDAsync().subscribe(
      res => {
        this.GoiSoThamSoService.FormData = (res as GoiSoThamSo);
        // if ((this.DanhMucQuayDichVuService.FormData01.Active == false) || (this.DanhMucQuayDichVuService.FormData02.Active == false)) {
        //   this.GoiSoThamSoService.FormData.Name = "col s6 m6 l6";
        //   this.GoiSoThamSoService.FormData.Code = "col s6 m6 l6";
        // }
        // if ((this.DanhMucQuayDichVuService.FormData01.ID == 0) || (this.DanhMucQuayDichVuService.FormData02.ID == 0)) {
        //   this.GoiSoThamSoService.FormData.Name = "col s6 m6 l6";
        //   this.GoiSoThamSoService.FormData.Code = "col s6 m6 l6";
        // }        
        this.GoiSoChiTietDangKy();        
      },
      err => {
      },
      () => {
      }
    );
  }

  ManHinhTapTinDinhKemSearch() {
    this.ManHinhTapTinDinhKemService.BaseParameter.Active = true;
    this.ManHinhTapTinDinhKemService.GetByActiveToListAsync().subscribe(
      res => {
        this.ManHinhTapTinDinhKemService.List = (res as ManHinhTapTinDinhKem[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
      },
      err => {
      },
      () => {
      }
    );
  }

  ManHinhThongBaoSearch() {
    this.ManHinhThongBaoService.BaseParameter.Active = true;
    this.ManHinhThongBaoService.GetByActiveToListAsync().subscribe(
      res => {
        this.ManHinhThongBaoService.List = (res as ManHinhThongBao[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.ManHinhThongBaoService.List) {
          if (this.ManHinhThongBaoService.List.length > 0) {
            if (this.ManHinhThongBaoService.FormData.ID == environment.InitializationNumber) {
              this.ManHinhThongBaoService.FormData = this.ManHinhThongBaoService.List[this.ManHinhThongBaoIndex];
              this.ManHinhThongBaoIndex = this.ManHinhThongBaoIndex + 1;
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

  GoiSoChiTietDangKy() {

    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code01;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData01 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData01) {
          if (this.DanhMucQuayDichVuService.FormData01.Active) {
            this.GoiSoChiTietService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code01;
            if ((this.GoiSoChiTietService.BaseParameter.Code == "29") || (this.GoiSoChiTietService.BaseParameter.Code == "30") || (this.GoiSoChiTietService.BaseParameter.Code == "31") || (this.GoiSoChiTietService.BaseParameter.Code == "32")) {
              this.IsBHYT = false;
            }
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            if (this.GoiSoThamSoService.FormData) {
              if (this.GoiSoThamSoService.FormData.BuocNhayTiepNhan) {
                if (this.GoiSoThamSoService.FormData.BuocNhayTiepNhan > 0) {
                  this.GoiSoChiTietService.BaseParameter.Number = this.GoiSoThamSoService.FormData.BuocNhayTiepNhan;
                }
              }
            }
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan04_001ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List01 = (res as GoiSoChiTiet[]).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                if (this.GoiSoChiTietService.List01) {
                  if (this.GoiSoChiTietService.List01.length > 0) {
                    this.GoiSoChiTietService.FormData01 = this.GoiSoChiTietService.List01[0];
                  }
                }
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
          if (this.DanhMucQuayDichVuService.FormData02.Active) {
            this.GoiSoChiTietService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code02;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            if (this.GoiSoThamSoService.FormData) {
              if (this.GoiSoThamSoService.FormData.BuocNhayTiepNhan) {
                if (this.GoiSoThamSoService.FormData.BuocNhayTiepNhan > 0) {
                  this.GoiSoChiTietService.BaseParameter.Number = this.GoiSoThamSoService.FormData.BuocNhayTiepNhan;
                }
              }
            }
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan04_001ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List02 = (res as GoiSoChiTiet[]).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                if (this.GoiSoChiTietService.List02) {
                  if (this.GoiSoChiTietService.List02.length > 0) {
                    this.GoiSoChiTietService.FormData02 = this.GoiSoChiTietService.List02[0];
                  }
                }
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
      },
      err => {
      },
      () => {
      }
    );
  }


  StartTimerInterval() {
    setInterval(() => {
      this.GoiSoThamSoSearch();
    }, environment.Interval)
  }
  StartTimer600000() {
    setInterval(() => {
      this.ManHinhThongBaoSearch();
      this.ManHinhTapTinDinhKemSearch();
    }, 600000)
  }
}