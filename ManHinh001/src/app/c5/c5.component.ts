import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

@Component({
  selector: 'app-c5',
  templateUrl: './c5.component.html',
  styleUrls: ['./c5.component.css']
})
export class C5Component implements OnInit {

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
                  if (this.GoiSoChiTietService.List01[i].HoTen) {
                  }
                  else {
                    this.GoiSoChiTietService.List01[i].HoTen = "0000";
                  }
                  if (this.GoiSoChiTietService.List01[i].NamSinh) {
                  }
                  else {
                    this.GoiSoChiTietService.List01[i].NamSinh = 0;
                  }
                }
                this.GoiSoChiTietService.List02 = this.GoiSoChiTietService.List.filter(item => item.Active == false);
                for (let i = 0; i < this.GoiSoChiTietService.List02.length; i++) {
                  if (this.GoiSoChiTietService.List02[i].HoTen) {
                  }
                  else {
                    this.GoiSoChiTietService.List02[i].HoTen = "0000";
                  }
                  if (this.GoiSoChiTietService.List02[i].NamSinh) {
                  }
                  else {
                    this.GoiSoChiTietService.List02[i].NamSinh = 0;
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
