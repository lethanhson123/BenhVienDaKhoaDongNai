import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { BenhAn } from 'src/app/shared/eHospital_DongNai_A/BenhAn.model';
import { BenhAnService } from 'src/app/shared/eHospital_DongNai_A/BenhAn.service';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { DM_DoiTuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.model';
import { DM_DoiTuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.service';

import { DM_ICD } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.model';
import { DM_ICDService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

@Component({
  selector: 'app-benh-an',
  templateUrl: './benh-an.component.html',
  styleUrls: ['./benh-an.component.css']
})
export class BenhAnComponent implements OnInit {

  @ViewChild('BenhAnSort') BenhAnSort: MatSort;
  @ViewChild('BenhAnPaginator') BenhAnPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public BenhAnService: BenhAnService,

    public Sys_UsersService: Sys_UsersService,
    public Lst_DictionaryService: Lst_DictionaryService,
    public DM_BenhNhanService: DM_BenhNhanService,
    public DM_DoiTuongService: DM_DoiTuongService,
    public DM_ICDService: DM_ICDService,
    public DM_PhongBanService: DM_PhongBanService,
  ) { }

  ngOnInit(): void {
    this.Sys_UsersSearch();
    this.Lst_DictionarySearch();
    this.DM_DoiTuongSearch();
    this.DM_ICDSearch();
    this.DM_PhongBanSearch();
    //this.BenhAnSearch();
  }
  DateNgayVaoVien(value) {
    this.BenhAnService.BaseParameter.NgayVaoVien = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.ComponentGetAllToListAsync(this.Lst_DictionaryService);
  }
  DM_BenhNhanSearch() {
    this.DM_BenhNhanService.ComponentGetAllToListAsync(this.DM_BenhNhanService);
  }
  DM_DoiTuongSearch() {
    this.DM_DoiTuongService.ComponentGetAllToListAsync(this.DM_DoiTuongService);
  }
  DM_ICDSearch() {
    this.DM_ICDService.ComponentGetAllToListAsync(this.DM_ICDService);
  }
  DM_PhongBanSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_PhongBanService);
  }
  BenhAnSearch() {
    this.BenhAnService.IsShowLoading = true;
    this.BenhAnService.GetByNgayVaoVien_SearchStringToListAsync().subscribe(
      res => {
        this.BenhAnService.List = (res as BenhAn[]).sort((a, b) => (a.NgayRaVien > b.NgayRaVien ? 1 : -1));
        var ListBenhNhan = this.BenhAnService.List.map(function (a) { return a.BenhNhan_Id; });        
        if (ListBenhNhan) {
          this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhan;
          this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
            res => {
              this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
              for (let i = 0; i < this.BenhAnService.List.length; i++) {
                let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.BenhAnService.List[i].NguoiTao_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.BenhAnService.List[i].NguoiTaoName = Sys_Users[0].User_Name;
                  }
                }
                Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.BenhAnService.List[i].NguoiCapNhat_Id);
                if (Sys_Users) {
                  if (Sys_Users.length) {
                    this.BenhAnService.List[i].NguoiCapNhatName = Sys_Users[0].User_Name;
                  }
                }
                let Lst_Dictionary = this.Lst_DictionaryService.List.filter(item => item.Dictionary_Id == this.BenhAnService.List[i].LoaiBenhAn_Id);
                if (Lst_Dictionary) {
                  if (Lst_Dictionary.length) {
                    this.BenhAnService.List[i].LoaiBenhAnName = Lst_Dictionary[0].Dictionary_Name;
                  }
                }
                let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.BenhAnService.List[i].BenhNhan_Id);
                if (DM_BenhNhan) {
                  if (DM_BenhNhan.length) {
                    this.BenhAnService.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan;
                  }
                }
                let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.BenhAnService.List[i].DoiTuong_Id);
                if (DM_DoiTuong) {
                  if (DM_DoiTuong.length) {
                    this.BenhAnService.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
                  }
                }
                let DM_ICD = this.DM_ICDService.List.filter(item => item.ICD_Id == this.BenhAnService.List[i].ICD_VaoKhoa);
                if (DM_ICD) {
                  if (DM_ICD.length) {
                    this.BenhAnService.List[i].ICDVaoKhoaName = DM_ICD[0].MaICD;
                  }
                }
                let DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.BenhAnService.List[i].NoiLap_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.BenhAnService.List[i].NoiLapName = DM_PhongBan[0].TenPhongBan;
                  }
                }
                DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.BenhAnService.List[i].KhoaVao_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.BenhAnService.List[i].KhoaVaoName = DM_PhongBan[0].TenPhongBan;
                  }
                }
                DM_PhongBan = this.DM_PhongBanService.List.filter(item => item.PhongBan_Id == this.BenhAnService.List[i].KhoaRa_Id);
                if (DM_PhongBan) {
                  if (DM_PhongBan.length) {
                    this.BenhAnService.List[i].KhoaRaName = DM_PhongBan[0].TenPhongBan;
                  }
                }
              }
              this.BenhAnService.DataSource = new MatTableDataSource(this.BenhAnService.List);
              this.BenhAnService.DataSource.sort = this.BenhAnSort;
              this.BenhAnService.DataSource.paginator = this.BenhAnPaginator;     
            },
            err => {
            },
            () => {
            }
          );
        }        
      },
      err => {
      },
      () => {
        this.BenhAnService.IsShowLoading = false;
      }
    );
  }
  BenhAnSave(element: BenhAn) {
  }
  BenhAnDelete(element: BenhAn) {
  }
}