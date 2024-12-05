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

import { interval } from 'rxjs';

@Component({
  selector: 'app-man-hinh03',
  templateUrl: './man-hinh03.component.html',
  styleUrls: ['./man-hinh03.component.css']
})
export class ManHinh03Component implements OnInit {

  videoSrc: string = environment.InitializationString;
  ManHinhTapTinDinhKemIndex: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemInterval: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemIntervalIndex: number = environment.InitializationNumber;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public DownloadService: DownloadService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,

    public ManHinhTapTinDinhKemService: ManHinhTapTinDinhKemService,
    public ManHinhThongBaoService: ManHinhThongBaoService,
  ) { }

  ngOnInit(): void {
    this.GoiSoChiTietService.BaseParameter.SearchString = this.ActiveRouter.snapshot.params.SearchString;
    this.GetGoiSoChiTietDangKy02();
    this.ManHinhThongBaoSearch();
    this.ManHinhTapTinDinhKemSearch();

    this.StartTimerInterval();
    this.StartTimer1000();
    this.StartTimer10000();
    this.StartTimer60000();

    interval(environment.Interval).subscribe((x) => {
      this.ManHinhTapTinDinhKemIntervalIndex = this.ManHinhTapTinDinhKemIntervalIndex + 1;
      this.ManHinhTapTinDinhKemInterval = environment.Interval * this.ManHinhTapTinDinhKemIntervalIndex / 1000;
      if (this.ManHinhTapTinDinhKemIndex >= this.ManHinhTapTinDinhKemService.List.length) {
        this.ManHinhTapTinDinhKemIndex = environment.InitializationNumber;
      }
      if (this.ManHinhTapTinDinhKemInterval > this.ManHinhTapTinDinhKemService.FormData.TongSoGiay) {
        if (this.ManHinhTapTinDinhKemIndex < this.ManHinhTapTinDinhKemService.List.length) {
          this.ManHinhTapTinDinhKemService.FormData = this.ManHinhTapTinDinhKemService.List[this.ManHinhTapTinDinhKemIndex];
          this.videoSrc = this.ManHinhTapTinDinhKemService.FormData.FileName;
          this.ManHinhTapTinDinhKemIndex = this.ManHinhTapTinDinhKemIndex + 1;
        }
      }
    });
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
        this.ManHinhThongBaoService.FormData.Description = environment.InitializationString;
        for (let i = 0; i < this.ManHinhThongBaoService.List.length; i++) {
          this.ManHinhThongBaoService.FormData.Description = this.ManHinhThongBaoService.List[i].Description + ". " + this.ManHinhThongBaoService.FormData.Description;
        }
      },
      err => {
      },
      () => {
      }
    );
  }

  GetGoiSoChiTietDangKy02() {
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy02_002ToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.List01 = (res as DanhMucQuayDichVu[]);
        for (let i = 0; i < this.DanhMucQuayDichVuService.List01.length; i++) {
          if (this.DanhMucQuayDichVuService.List01[i].Display) {
          }
          else {
            this.DanhMucQuayDichVuService.List01[i].Display = "0987";
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
      this.GetGoiSoChiTietDangKy02();
    }, environment.Interval)
  }
  StartTimer1000() {
    setInterval(() => {
      this.GoiSoChiTietService.BaseParameter.KetThuc = new Date();
    }, 1000)
  }
  StartTimer10000() {
    setInterval(() => {
      this.ManHinhThongBaoSearch();
    }, 10000)
  }
  StartTimer60000() {
    setInterval(() => {
      this.ManHinhTapTinDinhKemSearch();
    }, 600000)
  }
}