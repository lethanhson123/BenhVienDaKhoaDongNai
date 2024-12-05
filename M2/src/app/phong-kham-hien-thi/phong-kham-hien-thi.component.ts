import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { DanhMucPhongKham } from 'src/app/shared/DanhMucPhongKham.model';
import { DanhMucPhongKhamService } from 'src/app/shared/DanhMucPhongKham.service';

@Component({
  selector: 'app-phong-kham-hien-thi',
  templateUrl: './phong-kham-hien-thi.component.html',
  styleUrls: ['./phong-kham-hien-thi.component.css']
})
export class PhongKhamHienThiComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,

    public DanhMucPhongKhamService: DanhMucPhongKhamService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.DanhMucPhongKhamSearch();
    this.GetGoiSoChiTietDangKy05();
    this.StartTimer1000();
    this.StartTimer();
  }
  DanhMucPhongKhamSearch() {
    this.DanhMucPhongKhamService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.DanhMucPhongKhamID);
    this.DanhMucPhongKhamService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucPhongKhamService.FormData = (res as DanhMucPhongKham);
        this.GoiSoChiTietService.BaseParameter.DanhMucPhongKhamID = this.DanhMucPhongKhamService.FormData.ID;
      },
      err => {
      },
      () => {
      }
    );
  }
  GetGoiSoChiTietDangKy05() {    
    this.GoiSoChiTietService.BaseParameter.Number = 6;
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy05ToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.ListFull = (res as GoiSoChiTiet[]);

        this.GoiSoChiTietService.List01 = this.GoiSoChiTietService.ListFull.filter(item => item.Active == true);
        this.GoiSoChiTietService.List02 = this.GoiSoChiTietService.ListFull.filter(item => item.Active == false);
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
      this.GetGoiSoChiTietDangKy05();
    }, environment.Interval)
  }
}
