import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { CongViec } from 'src/app/shared/CongViec.model';
import { CongViecService } from 'src/app/shared/CongViec.service';
import { CongViecDetail001Component } from '../cong-viec-detail001/cong-viec-detail001.component';

@Component({
  selector: 'app-cong-viec001',
  templateUrl: './cong-viec001.component.html',
  styleUrls: ['./cong-viec001.component.css']
})
export class CongViec001Component implements OnInit {

  @ViewChild('CongViecSort') CongViecSort: MatSort;
  @ViewChild('CongViecPaginator') CongViecPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public CongViecService: CongViecService,



  ) { }

  ngOnInit(): void {
    this.CongViecSearch();
  }  
  CongViecSearch() {
    this.CongViecService.IsShowLoading = true;
    this.CongViecService.GetByThanhVienIDToListAsync().subscribe(
      res => {
        this.CongViecService.List = (res as CongViec[]).sort((a, b) => (a.NgayYeuCau < b.NgayYeuCau ? 1 : -1));        
        this.CongViecService.DataSource = new MatTableDataSource(this.CongViecService.List);
        this.CongViecService.DataSource.sort = this.CongViecSort;
        this.CongViecService.DataSource.paginator = this.CongViecPaginator;
      },
      err => {
      },
      () => {
        this.CongViecService.IsShowLoading = false;
      }
    );
  }
  CongViecAdd(ID: number) {
    this.CongViecService.BaseParameter.ID = ID;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: ID };
    const dialog = this.Dialog.open(CongViecDetail001Component, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.CongViecSearch();
    });
  }

}