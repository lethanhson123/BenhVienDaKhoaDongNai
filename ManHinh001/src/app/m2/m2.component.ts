import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { interval } from 'rxjs';

@Component({
  selector: 'app-m2',
  templateUrl: './m2.component.html',
  styleUrls: ['./m2.component.css']
})
export class M2Component implements OnInit {

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
      this.DanhMucQuayDichVuSearch();
    }, environment.Interval)
  }
  DanhMucQuayDichVuSearch() {
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code01;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData01 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData01) {
          if (this.DanhMucQuayDichVuService.FormData01.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData01.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan06ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List01 = this.GoiSoChiTietService.List.filter(item => item.Active == true);
                for (let i = 0; i < this.GoiSoChiTietService.List01.length; i++) {
                  if (this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString = "0000";
                  }
                }
                this.GoiSoChiTietService.List02 = this.GoiSoChiTietService.List.filter(item => item.Active == false);
                for (let i = 0; i < this.GoiSoChiTietService.List02.length; i++) {
                  if (this.GoiSoChiTietService.List02[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List02[i].NgayCapSoSoThuTuString = "0000";
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
          if (this.DanhMucQuayDichVuService.FormData02.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData02.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan06ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List03 = this.GoiSoChiTietService.List.filter(item => item.Active == true);
                for (let i = 0; i < this.GoiSoChiTietService.List03.length; i++) {
                  if (this.GoiSoChiTietService.List03[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List03[i].NgayTiepNhanSoThuTuString = "0000";
                  }
                }
                this.GoiSoChiTietService.List04 = this.GoiSoChiTietService.List.filter(item => item.Active == false);
                for (let i = 0; i < this.GoiSoChiTietService.List04.length; i++) {                  
                  if (this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString = "0000";                    
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
}
