import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { ManHinhTapTinDinhKem } from 'src/app/shared/ManHinhTapTinDinhKem.model';
import { ManHinhTapTinDinhKemService } from 'src/app/shared/ManHinhTapTinDinhKem.service';

import { interval } from 'rxjs';

@Component({
  selector: 'app-group',
  templateUrl: './group.component.html',
  styleUrls: ['./group.component.css']
})
export class GroupComponent implements OnInit {

  videoSrc: string = environment.InitializationString;
  ManHinhTapTinDinhKemIndex: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemInterval: number = environment.InitializationNumber;
  ManHinhTapTinDinhKemIntervalIndex: number = environment.InitializationNumber;

  ManHinhThongBaoIndex: number = environment.InitializationNumber;
  IsBHYT: boolean = true;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public DownloadService: DownloadService,
    public DanhMucDichVuService: DanhMucDichVuService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,
    public ManHinhTapTinDinhKemService: ManHinhTapTinDinhKemService,
  ) { }

  ngOnInit(): void {
    this.DanhMucDichVuSearch();
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
  }
  StartTimerInterval() {
    setInterval(() => {
      this.DanhMucDichVuSearch();
    }, environment.Interval)
  }
  StartTimer600000() {
    setInterval(() => {
      this.ManHinhTapTinDinhKemSearch();
    }, 600000)
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
  DanhMucDichVuSearch() {
    this.DanhMucDichVuService.BaseParameter.GroupOrder = this.ActiveRouter.snapshot.params.GroupOrder;
    this.DanhMucDichVuService.GetByGroupOrderToListAsync().subscribe(
      res => {
        this.DanhMucDichVuService.List = (res as DanhMucDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.DanhMucDichVuService.List) {
          if (this.DanhMucDichVuService.List.length > 0) {
            this.DanhMucDichVuService.FormData = this.DanhMucDichVuService.List[0];
            this.GoiSoSearch();
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  GoiSoSearch() {
    this.GoiSoChiTietService.BaseParameter.GroupOrder = this.ActiveRouter.snapshot.params.GroupOrder;
    this.GoiSoChiTietService.BaseParameter.Number = 1;
    this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan05ToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
        if (this.GoiSoChiTietService.List) {
          if (this.GoiSoChiTietService.List.length > 0) {
            for (let i = 0; i < this.GoiSoChiTietService.List.length; i++) {
              if (this.GoiSoChiTietService.List[i].NgayTiepNhanSoThuTuString) {
              }
              else {
                this.GoiSoChiTietService.List[i].NgayTiepNhanSoThuTuString = "0000";
              }
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
