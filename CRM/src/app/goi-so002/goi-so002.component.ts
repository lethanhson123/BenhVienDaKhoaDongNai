import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';
import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
import { ThanhVienQuayDichVu } from 'src/app/shared/ThanhVienQuayDichVu.model';
import { ThanhVienQuayDichVuService } from 'src/app/shared/ThanhVienQuayDichVu.service';
import { ThanhVienDichVu } from 'src/app/shared/ThanhVienDichVu.model';
import { ThanhVienDichVuService } from 'src/app/shared/ThanhVienDichVu.service';

@Component({
  selector: 'app-goi-so002',
  templateUrl: './goi-so002.component.html',
  styleUrls: ['./goi-so002.component.css']
})
export class GoiSo002Component implements OnInit {


  SoUuTien: number = environment.InitializationNumber;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public GoiSoService: GoiSoService,
    public GoiSoChiTietService: GoiSoChiTietService,
    public ThanhVienService: ThanhVienService,
    public ThanhVienQuayDichVuService: ThanhVienQuayDichVuService,
    public ThanhVienDichVuService: ThanhVienDichVuService,

  ) { }

  ngOnInit(): void {
    this.ThanhVienService.GetLogin();
    this.ThanhVienQuayDichVuSearch();
    this.ThanhVienDichVuSearch();
  }
  ThanhVienQuayDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.ThanhVienQuayDichVuService.BaseParameter.ParentID = this.ThanhVienService.FormDataLogin.ID;
    this.ThanhVienQuayDichVuService.GetByParentIDToListAsync().subscribe(
      res => {
        this.ThanhVienQuayDichVuService.List = (res as ThanhVienQuayDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.ThanhVienQuayDichVuService.ListFilter = this.ThanhVienQuayDichVuService.List;
        if (this.ThanhVienQuayDichVuService.List) {
          if (this.ThanhVienQuayDichVuService.List.length > 0) {
            this.GoiSoService.BaseParameter.DanhMucQuayDichVuID = this.ThanhVienQuayDichVuService.List[0].DanhMucQuayDichVuID;
          }
        }
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  ThanhVienDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.ThanhVienDichVuService.BaseParameter.ParentID = this.ThanhVienService.FormDataLogin.ID;
    this.ThanhVienDichVuService.GetByParentIDToListAsync().subscribe(
      res => {
        this.ThanhVienDichVuService.List = (res as ThanhVienDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.ThanhVienDichVuService.ListFilter = this.ThanhVienDichVuService.List;
        if (this.ThanhVienDichVuService.List) {
          if (this.ThanhVienDichVuService.List.length > 0) {
            this.GoiSoService.BaseParameter.DanhMucDichVuID = this.ThanhVienDichVuService.List[0].DanhMucDichVuID;
          }
        }
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );    
  }
  GoiSoTiepTheo() {
    this.GoiSoService.IsShowLoading = true;    
    this.GoiSoService.BaseParameter.SoHienTai = this.GoiSoService.FormData.SoHienTai;        
    this.GoiSoService.GoiSoTiepTheoAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync();
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.DanhMucDichVuID = this.GoiSoService.FormData.DanhMucDichVuID;
    this.GoiSoChiTietService.BaseParameter.NgayCapSoSoThuTu = this.GoiSoService.FormData.SoHienTai;    
    this.GoiSoChiTietService.GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync().subscribe(
      res => {
        this.GoiSoChiTietService.FormData = res as GoiSoChiTiet;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  GoiSoChiTietSave() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoChiTietService.SaveAsync().subscribe(
      res => {
        this.GoiSoChiTietService.FormData = res as GoiSoChiTiet;        
      },
      err => {        
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
}
