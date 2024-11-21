import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

@Component({
  selector: 'app-goi-so001',
  templateUrl: './goi-so001.component.html',
  styleUrls: ['./goi-so001.component.css']
})
export class GoiSo001Component implements OnInit {

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
    this.DanhMucDichVuService.BaseParameter.Active = true;
    this.DanhMucDichVuService.ComponentGetByActiveToListAsync(this.GoiSoService);
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
