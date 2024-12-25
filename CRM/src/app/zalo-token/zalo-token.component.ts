import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ZaloToken } from 'src/app/shared/ZaloToken.model';
import { ZaloTokenService } from 'src/app/shared/ZaloToken.service';

@Component({
  selector: 'app-zalo-token',
  templateUrl: './zalo-token.component.html',
  styleUrls: ['./zalo-token.component.css']
})
export class ZaloTokenComponent implements OnInit {

  @ViewChild('ZaloTokenSort') ZaloTokenSort: MatSort;
  @ViewChild('ZaloTokenPaginator') ZaloTokenPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ZaloTokenService: ZaloTokenService,
  ) { }

  ngOnInit(): void {
    this.ZaloTokenSearch();
  }

  DateNgayGhiNhan(element: ZaloToken, value) {
    element.NgayGhiNhan = new Date(value);
  }

  ZaloTokenSearch() {
    this.ZaloTokenService.IsShowLoading = true;
    this.ZaloTokenService.GetAllAndEmptyToListAsync().subscribe(
      res => {
        this.ZaloTokenService.List = (res as any[]).sort((a, b) => (a.NgayGhiNhan < b.NgayGhiNhan ? 1 : -1));
        this.ZaloTokenService.ListFilter = this.ZaloTokenService.List.filter(item => item.ID > 0);
        this.ZaloTokenService.DataSource = new MatTableDataSource(this.ZaloTokenService.List);
        this.ZaloTokenService.DataSource.sort = this.ZaloTokenSort;
        this.ZaloTokenService.DataSource.paginator = this.ZaloTokenPaginator;
      },
      err => {
      },
      () => {
        this.ZaloTokenService.IsShowLoading = false;
      }
    );
  }
  ZaloTokenSave(element: ZaloToken) {
    this.ZaloTokenService.IsShowLoading = true;
    this.ZaloTokenService.FormData = element;
    this.ZaloTokenService.SaveAsync().subscribe(
      res => {
        this.ZaloTokenService.FormData = (res as ZaloToken);
        this.ZaloTokenSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ZaloTokenService.IsShowLoading = false;
      }
    );
  }
  ZaloTokenDelete(element: ZaloToken) {
    this.ZaloTokenService.IsShowLoading = true;
    this.ZaloTokenService.BaseParameter.ID = element.ID;
    this.ZaloTokenService.RemoveAsync().subscribe(
      res => {        
        this.ZaloTokenSearch();
        this.NotificationService.warn(environment.DeleteSuccess);
      },
      err => {
        this.NotificationService.warn(environment.DeleteNotSuccess);
      },
      () => {
        this.ZaloTokenService.IsShowLoading = false;
      }
    );
  }
}