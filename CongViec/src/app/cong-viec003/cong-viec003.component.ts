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
import { CongViec003DetailComponent } from '../cong-viec003-detail/cong-viec003-detail.component';


@Component({
  selector: 'app-cong-viec003',
  templateUrl: './cong-viec003.component.html',
  styleUrls: ['./cong-viec003.component.css']
})
export class CongViec003Component implements OnInit {

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
    this.CongViecService.SearchAllNotEmpty(this.CongViecSort, this.CongViecPaginator);
  }

  CongViecAdd(element: CongViec) {
    this.CongViecService.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: 0 };
    const dialog = this.Dialog.open(CongViec003DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.CongViecSearch();
    });
  }

}