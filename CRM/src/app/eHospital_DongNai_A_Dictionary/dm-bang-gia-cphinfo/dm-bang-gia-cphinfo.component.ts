import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { DM_BangGia_CPH } from 'src/app/shared/eHospital_DongNai_A_Dictionary//DM_BangGia_CPH.model';
import { DM_BangGia_CPHService } from 'src/app/shared/eHospital_DongNai_A_Dictionary//DM_BangGia_CPH.service';

import { DM_LoaiGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.model';
import { DM_LoaiGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.service';

import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { DM_DichVu_DonGia_CPH } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu_DonGia_CPH.model';
import { DM_DichVu_DonGia_CPHService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu_DonGia_CPH.service';

@Component({
  selector: 'app-dm-bang-gia-cphinfo',
  templateUrl: './dm-bang-gia-cphinfo.component.html',
  styleUrls: ['./dm-bang-gia-cphinfo.component.css']
})
export class DMBangGiaCPHInfoComponent implements OnInit {

  @ViewChild('DM_DichVu_DonGia_CPHSort') DM_DichVu_DonGia_CPHSort: MatSort;
  @ViewChild('DM_DichVu_DonGia_CPHPaginator') DM_DichVu_DonGia_CPHPaginator: MatPaginator;


  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BangGia_CPHService: DM_BangGia_CPHService,
    public DM_LoaiGiaService: DM_LoaiGiaService,
    public DM_DichVuService: DM_DichVuService,
    public DM_DichVu_DonGia_CPHService: DM_DichVu_DonGia_CPHService,
  ) { }

  ngOnInit(): void {
    this.DM_BangGia_CPHService.BaseParameter.BangGia_CPH_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.DM_BangGia_CPHSearch();    
  }
  DateNgayBanHanh(value) {
    this.DM_BangGia_CPHService.FormData.NgayBanHanh = new Date(value);
  }
  DateNgayHieuLuc(value) {
    this.DM_BangGia_CPHService.FormData.NgayHieuLuc = new Date(value);
  }
  DateNgayHetHieuLuc(value) {
    this.DM_BangGia_CPHService.FormData.NgayHetHieuLuc = new Date(value);
  }
  DM_LoaiGiaSearch() {
    this.DM_LoaiGiaService.ComponentGetAllToListAsync(this.DM_BangGia_CPHService);
  }
  DM_DichVuSearch() {
    this.DM_DichVuService.ComponentGetAllToListAsync(this.DM_BangGia_CPHService);
  }
  DM_DichVuFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_DichVuService.ListFilter = this.DM_DichVuService.List.filter(item => item.DichVu_Id.toString().indexOf(searchString) !== -1 || item.TenDichVu.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaDichVu.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_DichVuService.ListFilter = this.DM_DichVuService.List;
    }
  }
  DM_DichVu_DonGia_CPHSearch() {
    this.DM_BangGia_CPHService.IsShowLoading = true;
    this.DM_DichVuService.GetAllToListAsync().subscribe(
      res => {
        this.DM_DichVuService.ListFilter = (res as DM_DichVu[]);
        this.DM_DichVu_DonGia_CPHService.BaseParameter.BangGia_CPH_Id = this.DM_BangGia_CPHService.FormData.BangGia_CPH_Id;
        this.DM_DichVu_DonGia_CPHService.GetByBangGia_CPH_IdAndEmptyToListAsync().subscribe(
          res => {
            this.DM_DichVu_DonGia_CPHService.List = (res as DM_DichVu_DonGia_CPH[]);
            for (let i = 0; i < this.DM_DichVu_DonGia_CPHService.List.length; i++) {
              let DichVu = this.DM_DichVuService.ListFilter.filter(item => item.DichVu_Id == this.DM_DichVu_DonGia_CPHService.List[i].DichVu_Id);
              if (DichVu) {
                if (DichVu.length > 0) {
                  this.DM_DichVu_DonGia_CPHService.List[i].DichVuName = DichVu[0].TenDichVu;
                }
              }
            }
            for (let i = 0; i < this.DM_DichVu_DonGia_CPHService.List.length; i++) {
              let LoaiGia = this.DM_LoaiGiaService.ListFilter.filter(item => item.LoaiGia_Id == this.DM_DichVu_DonGia_CPHService.List[i].LoaiGia_Id);
              if (LoaiGia) {
                if (LoaiGia.length > 0) {
                  this.DM_DichVu_DonGia_CPHService.List[i].LoaiGiaName = LoaiGia[0].TenLoaiGia + " - " + LoaiGia[0].MaLoaiGia + " [" + LoaiGia[0].LoaiGia_Id + "]";
                }
              }
            }
            this.DM_DichVu_DonGia_CPHService.DataSource = new MatTableDataSource(this.DM_DichVu_DonGia_CPHService.List);
            this.DM_DichVu_DonGia_CPHService.DataSource.sort = this.DM_DichVu_DonGia_CPHSort;
            this.DM_DichVu_DonGia_CPHService.DataSource.paginator = this.DM_DichVu_DonGia_CPHPaginator;
            this.DM_BangGia_CPHService.IsShowLoading = false;
          },
          err => {
          },
          () => {
          }
        );
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_DichVu_DonGia_CPHSave(element: DM_DichVu_DonGia_CPH) {
    this.DM_BangGia_CPHService.IsShowLoading = true;
    element.BangGia_CPH_Id = this.DM_BangGia_CPHService.FormData.BangGia_CPH_Id;
    element.LoaiGia_Id = this.DM_BangGia_CPHService.FormData.LoaiGia_Id;
    this.DM_DichVu_DonGia_CPHService.FormData = element;
    this.DM_DichVu_DonGia_CPHService.SaveAsync().subscribe(
      res => {
        this.DM_DichVu_DonGia_CPHService.FormData = res as DM_DichVu_DonGia_CPH;
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BangGia_CPHService.IsShowLoading = false;
      }
    );
  }
  DM_BangGia_CPHSearch() {
    this.DM_BangGia_CPHService.IsShowLoading = true;
    this.DM_BangGia_CPHService.GetByBangGia_CPH_IdAsync().subscribe(
      res => {
        this.DM_BangGia_CPHService.FormData = res as DM_BangGia_CPH;
        this.DM_LoaiGiaSearch();
        this.DM_DichVu_DonGia_CPHSearch();
      },
      err => {
      },
      () => {
        this.DM_BangGia_CPHService.IsShowLoading = false;
      }
    );
  }
  DM_BangGia_CPHSave() {
    this.DM_BangGia_CPHService.IsShowLoading = true;
    this.DM_BangGia_CPHService.SaveAsync().subscribe(
      res => {
        this.DM_BangGia_CPHService.FormData = res as DM_BangGia_CPH;
        this.Router.navigateByUrl(environment.DMBangGiaCPHInfo + this.DM_BangGia_CPHService.FormData.BangGia_CPH_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BangGia_CPHService.IsShowLoading = false;
      }
    );
  }


}