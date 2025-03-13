import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  constructor(
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
    public GoiSoService: GoiSoService,
    public ThanhVienService: ThanhVienService,
  ) { }

  ngOnInit(): void {
    document.getElementById("Code").focus();
    this.ThanhVienService.GetLogin();
    this.DanhMucDichVuSearch();
  }

  DanhMucDichVuSearch() {    
    if (this.ThanhVienService.FormDataLogin.ID > 0) {
      this.GoiSoService.IsShowLoading = true;
      this.DanhMucDichVuService.BaseParameter.ThanhVienID = this.ThanhVienService.FormDataLogin.ID;
      this.DanhMucDichVuService.BaseParameter.Active = true;
      this.DanhMucDichVuService.GetByThanhVienID_ActiveToListAsync().subscribe(
        res => {
          this.DanhMucDichVuService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));          
          this.DanhMucDichVuService.List001 = this.DanhMucDichVuService.List.filter(item => item.IsBHYT == true);
          this.DanhMucDichVuService.List002 = this.DanhMucDichVuService.List.filter(item => item.IsBHYT == false || item.IsBHYT == null);
        },
        err => {
        },
        () => {
          this.GoiSoService.IsShowLoading = false;
        }
      );
    }
    else {
      this.Router.navigate(['/' + environment.Login]);
    }
  }
  SaveByDanhMucDichVuIDAsync(DanhMucDichVuID: number) {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoService.BaseParameter.DanhMucDichVuID = DanhMucDichVuID;
    this.GoiSoService.BaseParameter.Code = this.GoiSoService.FormData.Code;
    this.GoiSoService.SaveByDanhMucDichVuID_CodeAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.GoiSoService.FormData.Code = environment.InitializationString;
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
    let CodeArray = this.GoiSoService.FormData.Code.split('|');
    if (CodeArray) {
      if (CodeArray.length > 0) {
        this.GoiSoService.FormData.Code = CodeArray[0];
      }
    }
  }
}