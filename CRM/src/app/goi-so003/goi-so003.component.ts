import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';


import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';



@Component({
  selector: 'app-goi-so003',
  templateUrl: './goi-so003.component.html',
  styleUrls: ['./goi-so003.component.css']
})
export class GoiSo003Component implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,

  ) { }

  ngOnInit(): void {
    this.GetGoiSoChiTietDangKy01();
    this.GetGoiSoChiTietDangKy02();
    this.GetGoiSoChiTietDangKy03();
    //this.StartTimer();
  }

  GetGoiSoChiTietDangKy01() {
    this.GoiSoChiTietService.IsShowLoading = true;
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy01ToListAsync().subscribe(
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
        this.GoiSoChiTietService.IsShowLoading = false;
      }
    );
  }
  GetGoiSoChiTietDangKy02() {
    this.GoiSoChiTietService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.ListID.push(1);
    this.GoiSoChiTietService.BaseParameter.ListID.push(2);
    this.GoiSoChiTietService.BaseParameter.ListID.push(3);
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy02ToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.List03 = (res as DanhMucQuayDichVu[]);
      },
      err => {
      },
      () => {
        this.GoiSoChiTietService.IsShowLoading = false;
      }
    );
  }
  GetGoiSoChiTietDangKy03() {
    this.GoiSoChiTietService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = 1;
    this.GoiSoChiTietService.BaseParameter.DanhMucDichVuID = 2;
    this.GoiSoChiTietService.BaseParameter.Number = 5;
    this.GoiSoChiTietService.GetGoiSoChiTietDangKy03ToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.ListFull = (res as GoiSoChiTiet[]);
      },
      err => {
      },
      () => {
        this.GoiSoChiTietService.IsShowLoading = false;
      }
    );
  }
  StartTimer() {
    setInterval(() => {
      this.GetGoiSoChiTietDangKy01();
    }, environment.Interval)
  }
}
