import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { KhachHang } from 'src/app/shared/KhachHang.model';
import { KhachHangService } from 'src/app/shared/KhachHang.service';

@Component({
  selector: 'app-full',
  templateUrl: './full.component.html',
  styleUrls: ['./full.component.css']
})
export class FullComponent implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
    public GoiSoService: GoiSoService,
    public KhachHangService: KhachHangService,
  ) { }

  ngOnInit(): void {
    document.getElementById("Code").focus();
    this.DanhMucDichVuSearch();
  }

  DanhMucDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucDichVuService.BaseParameter.ParentID = environment.AG;
    this.DanhMucDichVuService.BaseParameter.Active = true;
    this.DanhMucDichVuService.GetByParentIDAndActiveToListAsync().subscribe(
      res => {
        this.DanhMucDichVuService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucDichVuService.List001 = this.DanhMucDichVuService.List.filter(item => item.IsBHYT == true);
        this.DanhMucDichVuService.List002 = this.DanhMucDichVuService.List.filter(item => item.IsBHYT == false);
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  SaveByDanhMucDichVuIDAsync(DanhMucDichVuID: number) {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoService.BaseParameter.DanhMucDichVuID = DanhMucDichVuID;
    this.GoiSoService.BaseParameter.Code = this.GoiSoService.FormData.Code;
    this.GoiSoService.BaseParameter.Display = this.GoiSoService.FormData.Display;
    this.GoiSoService.SaveByDanhMucDichVuID_Code_DisplayAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.GoiSoService.FormData.Code = environment.InitializationString;
        this.GoiSoService.FormData.Display = environment.InitializationString;
        this.NotificationService.OpenWindowByURLMin(this.GoiSoService.FormData.FileName);
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
    document.getElementById("Code").focus();
  }
  GoiSoChiTietCodeChange() {    
    this.GoiSoService.IsShowLoading = true;        
    this.GoiSoService.FormData.Display = environment.InitializationString;
    this.KhachHangService.BaseParameter.SearchString = this.GoiSoService.FormData.Code;
    this.KhachHangService.GetBySearchStringToAsync().subscribe(
      res => {
        this.KhachHangService.FormData = res as KhachHang;        
        this.GoiSoService.FormData.Display = this.KhachHangService.FormData.DienThoai;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
    document.getElementById("Code").focus();
  }
}