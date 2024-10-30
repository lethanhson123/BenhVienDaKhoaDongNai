import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucBieuMau } from 'src/app/shared/DanhMucBieuMau.model';
import { DanhMucBieuMauService } from 'src/app/shared/DanhMucBieuMau.service';
import { DanhMucBieuMauDetailComponent } from '../danh-muc-bieu-mau-detail/danh-muc-bieu-mau-detail.component';

@Component({
  selector: 'app-danh-muc-bieu-mau',
  templateUrl: './danh-muc-bieu-mau.component.html',
  styleUrls: ['./danh-muc-bieu-mau.component.css']
})
export class DanhMucBieuMauComponent implements OnInit {

  @ViewChild('DanhMucBieuMauSort') DanhMucBieuMauSort: MatSort;
  @ViewChild('DanhMucBieuMauPaginator') DanhMucBieuMauPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucBieuMauService: DanhMucBieuMauService,



  ) { }

  ngOnInit(): void {
    this.DanhMucBieuMauSearch();
  }
  
  DanhMucBieuMauSearch() {
    this.DanhMucBieuMauService.SearchAllNotEmpty(this.DanhMucBieuMauSort, this.DanhMucBieuMauPaginator);
  }
  DanhMucBieuMauDelete(element: DanhMucBieuMau) {
    this.DanhMucBieuMauService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucBieuMauService.ComponentDeleteAllNotEmpty(this.DanhMucBieuMauSort, this.DanhMucBieuMauPaginator));
  }  
  DanhMucBieuMauAdd(ID: number) {
    this.DanhMucBieuMauService.BaseParameter.ID = ID;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: ID };
    const dialog = this.Dialog.open(DanhMucBieuMauDetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.DanhMucBieuMauSearch();
    });
  }

}