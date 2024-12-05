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
  selector: 'app-hien-thi0201',
  templateUrl: './hien-thi0201.component.html',
  styleUrls: ['./hien-thi0201.component.css']
})
export class HienThi0201Component implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {    
    this.GoiSoChiTietService.BaseParameter.SearchString = this.ActiveRouter.snapshot.params.SearchString;    
    this.GetGoiSoChiTietDangKy02();
    this.StartTimer1000();
    this.StartTimer();
  }
  GetGoiSoChiTietDangKy02() {        
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy02_001ToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.ListFull = (res as DanhMucQuayDichVu[]);
        this.DanhMucQuayDichVuService.List01 = [];
        this.DanhMucQuayDichVuService.List02 = [];
        let Count = this.DanhMucQuayDichVuService.ListFull.length / 2;
        for (let i = 0; i < this.DanhMucQuayDichVuService.ListFull.length; i++) {
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
      this.GoiSoChiTietService.BaseParameter.KetThuc=new Date();
      this.GetGoiSoChiTietDangKy02();
    }, 1000)
  }
  StartTimer() {
    setInterval(() => {      
      this.GetGoiSoChiTietDangKy02();
    }, environment.Interval)
  }
}