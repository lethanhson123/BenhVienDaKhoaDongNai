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

@Component({
  selector: 'app-man-hinh02',
  templateUrl: './man-hinh02.component.html',
  styleUrls: ['./man-hinh02.component.css']
})
export class ManHinh02Component implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
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
    this.StartTimer();
    this.StartTimerInterval();
    this.StartTimer1000();
    this.StartTimer10000();
  }

  ManHinhTapTinDinhKemSearch() {
    this.ManHinhTapTinDinhKemService.BaseParameter.Active = true;
    this.ManHinhTapTinDinhKemService.GetByActiveToListAsync().subscribe(
      res => {
        this.ManHinhTapTinDinhKemService.List = (res as ManHinhTapTinDinhKem[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        for (let i = 0; i < this.ManHinhTapTinDinhKemService.List.length; i++) {
          if (this.ManHinhTapTinDinhKemService.List[i].SortOrder > this.ManHinhTapTinDinhKemService.FormData.SortOrder) {
            this.ManHinhTapTinDinhKemService.FormData = this.ManHinhTapTinDinhKemService.List[i];
            i = this.ManHinhTapTinDinhKemService.List.length;
          }
        }
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
      },
      err => {
      },
      () => {
      }
    );
  }

  StartTimer() {
    setInterval(() => {
      this.ManHinhTapTinDinhKemSearch();
    }, this.ManHinhTapTinDinhKemService.FormData.TongSoGiay * 1000)
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
}