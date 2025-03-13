import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucThongKe } from 'src/app/shared/DanhMucThongKe.model';
import { DanhMucThongKeService } from 'src/app/shared/DanhMucThongKe.service';

import { ThongKe } from 'src/app/shared//ThongKe.model';
import { ThongKeService } from 'src/app/shared//ThongKe.service';
import { ThongKeChiTiet } from 'src/app/shared/ThongKeChiTiet.model';
import { ThongKeChiTietService } from 'src/app/shared/ThongKeChiTiet.service';

@Component({
  selector: 'app-thong-ke-info',
  templateUrl: './thong-ke-info.component.html',
  styleUrls: ['./thong-ke-info.component.css']
})
export class ThongKeInfoComponent implements OnInit {

  @ViewChild('ThongKeChiTietSort') ThongKeChiTietSort: MatSort;
  @ViewChild('ThongKeChiTietPaginator') ThongKeChiTietPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucThongKeService: DanhMucThongKeService,

    public ThongKeService: ThongKeService,
    public ThongKeChiTietService: ThongKeChiTietService,

  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.ThongKeService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.ThongKeSearch();
  }
  DanhMucThongKeSearch() {
    this.DanhMucThongKeService.ComponentGetAllToListAsync(this.ThongKeService);
  }
  DateBatDau(value) {
    this.ThongKeService.FormData.BatDau = new Date(value);
  }
  DateKetThuc(value) {
    this.ThongKeService.FormData.KetThuc = new Date(value);
  }
  ThongKeSearch() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.GetByIDAsync().subscribe(
      res => {
        this.ThongKeService.FormData = res as ThongKe;
        if (this.ThongKeService.FormData.BatDau == null) {
          this.ThongKeService.FormData.BatDau = new Date();
        }
        if (this.ThongKeService.FormData.KetThuc == null) {
          this.ThongKeService.FormData.KetThuc = new Date();
        }
        this.DanhMucThongKeSearch();
        this.ThongKeChiTietSearch();
      },
      err => {
      },
      () => {
        this.ThongKeService.IsShowLoading = false;
      }
    );
  }
  ThongKeSave() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.SaveAsync().subscribe(
      res => {
        this.ThongKeService.FormData = res as ThongKe;
        this.Router.navigateByUrl(environment.ThongKeInfo + this.ThongKeService.FormData.ID);
        this.ThongKeChiTietSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThongKeService.IsShowLoading = false;
      }
    );
  }
  ThongKeChiTietSearch() {
    this.ThongKeChiTietService.BaseParameter.ParentID = this.ThongKeService.FormData.ID;
    this.ThongKeChiTietService.SearchByParentID(this.ThongKeChiTietSort, this.ThongKeChiTietPaginator, this.ThongKeService);
  }
  ThongKeChiTietSave(element: ThongKeChiTiet) {
    element.ParentID = this.ThongKeService.FormData.ID;
    this.ThongKeChiTietService.FormData = element;
    this.NotificationService.warn(this.ThongKeChiTietService.ComponentSaveByParentID(this.ThongKeChiTietSort, this.ThongKeChiTietPaginator, this.ThongKeService));
  }
  ThongKeChiTietDelete(element: ThongKeChiTiet) {
    this.ThongKeChiTietService.FormData = element;
    this.NotificationService.warn(this.ThongKeChiTietService.ComponentDeleteByParentID(this.ThongKeChiTietSort, this.ThongKeChiTietPaginator, this.ThongKeService));
  }

}