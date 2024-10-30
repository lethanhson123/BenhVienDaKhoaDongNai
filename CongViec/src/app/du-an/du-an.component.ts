import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DuAn } from 'src/app/shared/DuAn.model';
import { DuAnService } from 'src/app/shared/DuAn.service';
import { DuAnDetailComponent } from '../du-an-detail/du-an-detail.component';

@Component({
  selector: 'app-du-an',
  templateUrl: './du-an.component.html',
  styleUrls: ['./du-an.component.css']
})
export class DuAnComponent implements OnInit {

  @ViewChild('DuAnSort') DuAnSort: MatSort;
  @ViewChild('DuAnPaginator') DuAnPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DuAnService: DuAnService,



  ) { }

  ngOnInit(): void {
    this.DuAnSearch();
  }
  DateBatDau(value) {
    this.DuAnService.BaseParameter.BatDau = new Date(value);
  }
  DateKetThuc(value) {
    this.DuAnService.BaseParameter.KetThuc = new Date(value);
  }
  DuAnSearch() {
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.GetBySearchString_BatDau_KetThucToListAsync().subscribe(
      res => {
        this.DuAnService.List = (res as DuAn[]).sort((a, b) => (a.NgayBatDau < b.NgayBatDau ? 1 : -1));
        this.DuAnService.DataSource = new MatTableDataSource(this.DuAnService.List);
        this.DuAnService.DataSource.sort = this.DuAnSort;
        this.DuAnService.DataSource.paginator = this.DuAnPaginator;
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
  DuAnAdd(ID: number) {
    this.DuAnService.BaseParameter.ID = ID;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: ID };
    const dialog = this.Dialog.open(DuAnDetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.DuAnSearch();
    });
  }
  DuAnDelete(element: DuAn) {
    this.DuAnService.BaseParameter.ID = element.ID;
    this.DuAnService.IsShowLoading = true;
    this.DuAnService.RemoveAsync().subscribe(
      res => {
        this.DuAnSearch();
        this.NotificationService.warn(environment.DeleteSuccess);
      },
      err => {
        this.NotificationService.warn(environment.DeleteNotSuccess);
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }
}