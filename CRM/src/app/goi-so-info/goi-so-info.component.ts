import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

@Component({
  selector: 'app-goi-so-info',
  templateUrl: './goi-so-info.component.html',
  styleUrls: ['./goi-so-info.component.css']
})
export class GoiSoInfoComponent implements OnInit {

  @ViewChild('GoiSoChiTietSort') GoiSoChiTietSort: MatSort;
  @ViewChild('GoiSoChiTietPaginator') GoiSoChiTietPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public GoiSoService: GoiSoService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.GoiSoService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.GoiSoSearch();
  }
  DateNgayGhiNhan(value) {
    this.GoiSoService.FormData.NgayGhiNhan = new Date(value);
  }
  GoiSoSearch() {
    this.GoiSoService.GetByIDAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.GoiSoChiTietSearch();
      },
      err => {
      }
    );
  }
  GoiSoSave() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoService.SaveAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.Router.navigateByUrl(environment.GoiSoInfo + this.GoiSoService.FormData.ID);        
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  GoiSoAdd() {
    this.Router.navigateByUrl(environment.GoiSoInfo + environment.InitializationNumber);
    this.GoiSoService.BaseParameter.ID = environment.InitializationNumber;
    this.GoiSoSearch();
  }
  GoiSoChiTietSearch() {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoChiTietService.BaseParameter.ParentID = this.GoiSoService.FormData.ID;
    this.GoiSoChiTietService.GetByParentIDToListAsync().subscribe(
      res => {
        this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
        this.GoiSoChiTietService.DataSource = new MatTableDataSource(this.GoiSoChiTietService.List);
        this.GoiSoChiTietService.DataSource.sort = this.GoiSoChiTietSort;
        this.GoiSoChiTietService.DataSource.paginator = this.GoiSoChiTietPaginator;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
}
