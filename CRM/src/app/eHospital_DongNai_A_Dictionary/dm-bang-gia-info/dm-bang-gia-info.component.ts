import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { DM_BangGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary//DM_BangGia.model';
import { DM_BangGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary//DM_BangGia.service';

import { DM_LoaiGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.model';
import { DM_LoaiGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.service';

import { DM_DichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.model';
import { DM_DichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu.service';

import { DM_DichVu_DonGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu_DonGia.model';
import { DM_DichVu_DonGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DichVu_DonGia.service';

@Component({
  selector: 'app-dm-bang-gia-info',
  templateUrl: './dm-bang-gia-info.component.html',
  styleUrls: ['./dm-bang-gia-info.component.css']
})
export class DMBangGiaInfoComponent implements OnInit {

  @ViewChild('DM_DichVu_DonGiaSort') DM_DichVu_DonGiaSort: MatSort;
  @ViewChild('DM_DichVu_DonGiaPaginator') DM_DichVu_DonGiaPaginator: MatPaginator;


  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BangGiaService: DM_BangGiaService,
    public DM_LoaiGiaService: DM_LoaiGiaService,
    public DM_DichVuService: DM_DichVuService,
    public DM_DichVu_DonGiaService: DM_DichVu_DonGiaService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DM_BangGiaService.BaseParameter.BangGia_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.DM_BangGiaSearch();    
  }
  DateNgayBanHanh(value) {
    this.DM_BangGiaService.FormData.NgayBanHanh = new Date(value);
  }
  DateNgayHieuLuc(value) {
    this.DM_BangGiaService.FormData.NgayHieuLuc = new Date(value);
  }
  DateNgayHetHieuLuc(value) {
    this.DM_BangGiaService.FormData.NgayHetHieuLuc = new Date(value);
  }
  DM_LoaiGiaSearch() {
    this.DM_LoaiGiaService.ComponentGetAllToListAsync(this.DM_BangGiaService);
  }
  DM_DichVuSearch() {
    this.DM_DichVuService.ComponentGetAllToListAsync(this.DM_BangGiaService);
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
  DM_DichVu_DonGiaSearch() {
    this.DM_BangGiaService.IsShowLoading = true;
    this.DM_DichVuService.GetAllToListAsync().subscribe(
      res => {
        this.DM_DichVuService.ListFilter = (res as DM_DichVu[]);
        this.DM_DichVu_DonGiaService.BaseParameter.BangGia_Id = this.DM_BangGiaService.FormData.BangGia_Id;
        this.DM_DichVu_DonGiaService.GetByBangGia_IdAndEmptyToListAsync().subscribe(
          res => {
            this.DM_DichVu_DonGiaService.List = (res as DM_DichVu_DonGia[]);
            for (let i = 0; i < this.DM_DichVu_DonGiaService.List.length; i++) {
              let DichVu = this.DM_DichVuService.ListFilter.filter(item => item.DichVu_Id == this.DM_DichVu_DonGiaService.List[i].DichVu_Id);
              if (DichVu) {
                if (DichVu.length > 0) {
                  this.DM_DichVu_DonGiaService.List[i].DichVuName = DichVu[0].TenDichVu;
                }
              }
            }
            for (let i = 0; i < this.DM_DichVu_DonGiaService.List.length; i++) {
              let LoaiGia = this.DM_LoaiGiaService.ListFilter.filter(item => item.LoaiGia_Id == this.DM_DichVu_DonGiaService.List[i].LoaiGia_Id);
              if (LoaiGia) {
                if (LoaiGia.length > 0) {
                  this.DM_DichVu_DonGiaService.List[i].LoaiGiaName = LoaiGia[0].TenLoaiGia + " - " + LoaiGia[0].MaLoaiGia + " [" + LoaiGia[0].LoaiGia_Id + "]";
                }
              }
            }
            this.DM_DichVu_DonGiaService.DataSource = new MatTableDataSource(this.DM_DichVu_DonGiaService.List);
            this.DM_DichVu_DonGiaService.DataSource.sort = this.DM_DichVu_DonGiaSort;
            this.DM_DichVu_DonGiaService.DataSource.paginator = this.DM_DichVu_DonGiaPaginator;
            this.DM_BangGiaService.IsShowLoading = false;
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
  DM_DichVu_DonGiaSave(element: DM_DichVu_DonGia) {
    this.DM_BangGiaService.IsShowLoading = true;
    element.BangGia_Id = this.DM_BangGiaService.FormData.BangGia_Id;
    element.LoaiGia_Id = this.DM_BangGiaService.FormData.LoaiGia_Id;
    this.DM_DichVu_DonGiaService.FormData = element;
    this.DM_DichVu_DonGiaService.SaveAsync().subscribe(
      res => {
        this.DM_DichVu_DonGiaService.FormData = res as DM_DichVu_DonGia;
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BangGiaService.IsShowLoading = false;
      }
    );
  }
  DM_BangGiaSearch() {
    this.DM_BangGiaService.IsShowLoading = true;
    this.DM_BangGiaService.GetByBangGia_IdAsync().subscribe(
      res => {
        this.DM_BangGiaService.FormData = res as DM_BangGia;
        this.DM_LoaiGiaSearch();
        this.DM_DichVu_DonGiaSearch();
      },
      err => {
      },
      () => {
        this.DM_BangGiaService.IsShowLoading = false;
      }
    );
  }
  DM_BangGiaSave() {
    this.DM_BangGiaService.IsShowLoading = true;
    this.DM_BangGiaService.SaveAsync().subscribe(
      res => {
        this.DM_BangGiaService.FormData = res as DM_BangGia;
        this.Router.navigateByUrl(environment.DMBangGiaInfo + this.DM_BangGiaService.FormData.BangGia_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BangGiaService.IsShowLoading = false;
      }
    );
  }


}