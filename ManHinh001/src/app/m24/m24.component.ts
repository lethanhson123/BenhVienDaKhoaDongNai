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
  selector: 'app-m24',
  templateUrl: './m24.component.html',
  styleUrls: ['./m24.component.css']
})
export class M24Component implements OnInit {

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
             this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan07ToListAsync().subscribe(
               res => {
                 this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                 this.GoiSoChiTietService.List01 = this.GoiSoChiTietService.List.filter(item => item.Active == true && item.IsUuTien == false).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List01.length; i++) {
                   if (this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString = "T1118-000";
                     this.GoiSoChiTietService.List01[i].Name = "0000";
                   }
                 }
                 this.GoiSoChiTietService.List02 = this.GoiSoChiTietService.List.filter(item => item.Active == true && item.IsUuTien == true).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List02.length; i++) {
                   if (this.GoiSoChiTietService.List02[i].NgayTiepNhanSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List02[i].NgayTiepNhanSoThuTuString = "T1118-UT000";
                     this.GoiSoChiTietService.List02[i].Name = "UT000";
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
                 this.GoiSoChiTietService.List04 = this.GoiSoChiTietService.List.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List04.length; i++) {
                   if (this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List04[i].NgayCapSoSoThuTuString = "0000";
                     this.GoiSoChiTietService.List04[i].Display = "0000";
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
             this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan07ToListAsync().subscribe(
               res => {
                 this.GoiSoChiTietService.ListFilter = (res as GoiSoChiTiet[]);                 
                 this.GoiSoChiTietService.List11 = this.GoiSoChiTietService.ListFilter.filter(item => item.Active == true && item.IsUuTien == false).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List11.length; i++) {
                   if (this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString = "T1119-000";
                     this.GoiSoChiTietService.List11[i].Name = "0000";
                   }
                 }
                 this.GoiSoChiTietService.List12 = this.GoiSoChiTietService.ListFilter.filter(item => item.Active == true && item.IsUuTien == true).sort((a, b) => (a.NgayTiepNhanSoThuTu > b.NgayTiepNhanSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List12.length; i++) {
                   if (this.GoiSoChiTietService.List12[i].NgayTiepNhanSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List12[i].NgayTiepNhanSoThuTuString = "T1119-UT000";
                     this.GoiSoChiTietService.List12[i].Name = "UT000";
                   }
                 }
                 this.GoiSoChiTietService.List13 = this.GoiSoChiTietService.ListFilter.filter(item => item.Active == false && item.IsUuTien == false).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List13.length; i++) {
                   if (this.GoiSoChiTietService.List13[i].NgayCapSoSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List13[i].NgayCapSoSoThuTuString = "0000";
                   }
                 }
                 this.GoiSoChiTietService.List14 = this.GoiSoChiTietService.ListFilter.filter(item => item.Active == false && item.IsUuTien == true).sort((a, b) => (a.NgayCapSoSoThuTu > b.NgayCapSoSoThuTu ? 1 : -1));
                 for (let i = 0; i < this.GoiSoChiTietService.List14.length; i++) {
                   if (this.GoiSoChiTietService.List14[i].NgayCapSoSoThuTuString) {
                   }
                   else {
                     this.GoiSoChiTietService.List14[i].NgayCapSoSoThuTuString = "0000";
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
 