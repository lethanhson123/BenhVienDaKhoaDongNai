import { Component, OnInit, ViewChild } from '@angular/core';

import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';
import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

@Component({
  selector: 'app-tiep-nhan-s',
  templateUrl: './tiep-nhan-s.component.html',
  styleUrls: ['./tiep-nhan-s.component.css']
})
export class TiepNhanSComponent implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,

    public GoiSoService: GoiSoService,
  ) {
  }

  ngOnInit(): void {
    // this.DanhMucDichVuSearch();
    // this.DanhMucQuayDichVuSearch();
    let URL = environment.TiepNhanURL + "TiepNhanS";
    var Width = window.innerWidth;
    if (Width > 300) {
      this.NotificationService.OpenWindowByURLBottomRight(URL,300,200);
      window.close();
    }
    else {      
      this.DanhMucDichVuSearch();
      this.DanhMucQuayDichVuSearch();
    }
  }
  DanhMucDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucDichVuService.BaseParameter.Active = true;
    this.DanhMucDichVuService.GetByActiveToListAsync().subscribe(
      res => {
        this.DanhMucDichVuService.List = (res as DanhMucDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.DanhMucDichVuService.List) {
          if (this.DanhMucDichVuService.List.length > 0) {
            this.GoiSoService.BaseParameter.DanhMucDichVuID = this.DanhMucDichVuService.List[0].ID;
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
  DanhMucQuayDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucQuayDichVuService.BaseParameter.Active = true;
    this.DanhMucQuayDichVuService.GetByActiveToListAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.List = (res as DanhMucQuayDichVu[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.DanhMucQuayDichVuService.List) {
          if (this.DanhMucQuayDichVuService.List.length > 0) {
            this.GoiSoService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.List[0].ID;
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
    let IsGoiSo = true;
    if (this.GoiSoService.BaseParameter.DanhMucQuayDichVuID == environment.InitializationNumber) {
      IsGoiSo = false;
      alert("Vui lòng chọn Quầy");
    }
    if (this.GoiSoService.BaseParameter.DanhMucDichVuID == environment.InitializationNumber) {
      IsGoiSo = false;
      alert("Vui lòng chọn Dịch vụ");
    }
    if (IsGoiSo == true) {
      this.GoiSoService.IsShowLoading = true;
      this.GoiSoService.BaseParameter.SoHienTai = this.GoiSoService.FormData.SoHienTai;
      this.GoiSoService.GoiSoTiepTheoAsync().subscribe(
        res => {
          this.GoiSoService.FormData = res as GoiSo;
        },
        err => {
        },
        () => {
          this.GoiSoService.IsShowLoading = false;
        }
      );
    }
  }

}
