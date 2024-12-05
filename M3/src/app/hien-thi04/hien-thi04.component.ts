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
  selector: 'app-hien-thi04',
  templateUrl: './hien-thi04.component.html',
  styleUrls: ['./hien-thi04.component.css']
})
export class HienThi04Component implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.ActiveRouter.snapshot.params.DanhMucQuayDichVuID;
    this.GetGoiSoChiTietDangKy04();
    this.StartTimer1000();
    this.StartTimer();
  }
  GetGoiSoChiTietDangKy04() {
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy04ToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.List04 = (res as GoiSoChiTiet[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  StartTimer1000() {
    setInterval(() => {
      this.GoiSoChiTietService.BaseParameter.KetThuc=new Date();      
    }, 1000)
  }
  StartTimer() {
    setInterval(() => {      
      this.GetGoiSoChiTietDangKy04();
    }, environment.Interval)
  }
}