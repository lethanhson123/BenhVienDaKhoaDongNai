import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

@Component({
  selector: 'app-g',
  templateUrl: './g.component.html',
  styleUrls: ['./g.component.css']
})
export class GComponent implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucDichVuService: DanhMucDichVuService,
    public GoiSoService: GoiSoService,
  ) { }

  ngOnInit(): void {
    this.DanhMucDichVuSearch();
  }

  DanhMucDichVuSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.DanhMucDichVuService.BaseParameter.ParentID = environment.G;
    this.DanhMucDichVuService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucDichVuService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucDichVuService.ListFilter = this.DanhMucDichVuService.List;
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
    this.GoiSoService.SaveByDanhMucDichVuIDAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;   
        this.NotificationService.OpenWindowByURLMin(this.GoiSoService.FormData.FileName);    
      },
      err => {        
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
}