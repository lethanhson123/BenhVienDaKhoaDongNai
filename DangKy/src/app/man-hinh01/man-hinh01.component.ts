import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

@Component({
  selector: 'app-man-hinh01',
  templateUrl: './man-hinh01.component.html',
  styleUrls: ['./man-hinh01.component.css']
})
export class ManHinh01Component implements OnInit {

  constructor(
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.GetGoiSoChiTietDangKy01();
    this.StartTimer1000();
    this.StartTimer();
  }
  GetGoiSoChiTietDangKy01() {
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy01ToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.ListFull = (res as DanhMucQuayDichVu[]);
       
        this.DanhMucQuayDichVuService.List01 = [];
        this.DanhMucQuayDichVuService.List02 = [];
        let Count = this.DanhMucQuayDichVuService.ListFull.length / 2;
        for (let i = 0; i < this.DanhMucQuayDichVuService.ListFull.length; i++) {
          if (this.DanhMucQuayDichVuService.ListFull[i].Display) {
          }
          else {
            this.DanhMucQuayDichVuService.ListFull[i].Display = "0987";
          }
          if (i < Count) {
            this.DanhMucQuayDichVuService.List01.push(this.DanhMucQuayDichVuService.ListFull[i]);
          }
          else {
            this.DanhMucQuayDichVuService.List02.push(this.DanhMucQuayDichVuService.ListFull[i]);
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  StartTimer1000() {
    setInterval(() => {
      this.GoiSoChiTietService.BaseParameter.KetThuc = new Date();
    }, 1000)
  }
  StartTimer() {
    setInterval(() => {
      this.GetGoiSoChiTietDangKy01();
    }, environment.Interval)
  }

}