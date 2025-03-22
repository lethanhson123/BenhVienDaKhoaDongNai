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
  selector: 'app-m4',
  templateUrl: './m4.component.html',
  styleUrls: ['./m4.component.css']
})
export class M4Component implements OnInit {

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
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan08ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List01 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List01.length; i++) {
                  if (this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List01[i].Name = "00000";
                  }
                }
                this.GoiSoChiTietService.List04 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List04.length; i++) {
                  if (this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List04[i].Display = "0000";
                  }
                }               
                this.GoiSoChiTietService.List03 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == false).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List03.length; i++) {
                  if (this.GoiSoChiTietService.List03[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List03[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List03[i].Display = "0000";
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
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan08ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List11 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List11.length; i++) {
                  if (this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List11[i].Name = "00000";
                  }
                }
                this.GoiSoChiTietService.List14 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List14.length; i++) {
                  if (this.GoiSoChiTietService.List14[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List14[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List14[i].Display = "0000";
                  }
                }               
                this.GoiSoChiTietService.List13 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == false).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List13.length; i++) {
                  if (this.GoiSoChiTietService.List13[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List13[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List13[i].Display = "0000";
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
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code03;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData03 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData03) {
          if (this.DanhMucQuayDichVuService.FormData03.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData03.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan08ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List21 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List21.length; i++) {
                  if (this.GoiSoChiTietService.List21[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List21[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List21[i].Name = "00000";
                  }
                }
                this.GoiSoChiTietService.List24 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List24.length; i++) {
                  if (this.GoiSoChiTietService.List24[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List24[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List24[i].Display = "0000";
                  }
                }              
                this.GoiSoChiTietService.List23 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == false).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List23.length; i++) {
                  if (this.GoiSoChiTietService.List23[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List23[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List23[i].Display = "0000";
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
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code04;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData04 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData04) {
          if (this.DanhMucQuayDichVuService.FormData04.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData04.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan08ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List31 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List31.length; i++) {
                  if (this.GoiSoChiTietService.List31[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List31[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List31[i].Name = "00000";
                  }
                }
                this.GoiSoChiTietService.List34 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List34.length; i++) {
                  if (this.GoiSoChiTietService.List34[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List34[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List34[i].Display = "0000";
                  }
                }               
                this.GoiSoChiTietService.List33 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == false).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List33.length; i++) {
                  if (this.GoiSoChiTietService.List33[i].NgayCapSoSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List33[i].NgayCapSoSoThuTuString = "0000";
                    this.GoiSoChiTietService.List33[i].Display = "0000";
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