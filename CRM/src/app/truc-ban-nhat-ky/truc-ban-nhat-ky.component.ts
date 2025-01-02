import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TrucBanNhatKy } from 'src/app/shared/TrucBanNhatKy.model';
import { TrucBanNhatKyService } from 'src/app/shared/TrucBanNhatKy.service';

@Component({
  selector: 'app-truc-ban-nhat-ky',
  templateUrl: './truc-ban-nhat-ky.component.html',
  styleUrls: ['./truc-ban-nhat-ky.component.css']
})
export class TrucBanNhatKyComponent implements OnInit {

  @ViewChild('TrucBanNhatKySort') TrucBanNhatKySort: MatSort;
  @ViewChild('TrucBanNhatKyPaginator') TrucBanNhatKyPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TrucBanNhatKyService: TrucBanNhatKyService,
  ) { }

  ngOnInit(): void { 
    this.TrucBanNhatKySearch();
  }
  DateNgayGhiNhan(element: TrucBanNhatKy, value) {
    element.NgayGhiNhan = new Date(value);
  }
  TrucBanNhatKySearch() {
    this.TrucBanNhatKyService.SearchAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator);
  }
  TrucBanNhatKySave(element: TrucBanNhatKy) {
    this.TrucBanNhatKyService.FormData = element;
    this.NotificationService.warn(this.TrucBanNhatKyService.ComponentSaveAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator));
  }
  TrucBanNhatKyDelete(element: TrucBanNhatKy) {
    this.TrucBanNhatKyService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.TrucBanNhatKyService.ComponentDeleteAll(this.TrucBanNhatKySort, this.TrucBanNhatKyPaginator));
  }  
}