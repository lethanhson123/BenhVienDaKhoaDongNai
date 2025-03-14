import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamSucKhoe } from 'src/app/shared/KhamSucKhoe.model';
import { KhamSucKhoeService } from 'src/app/shared/KhamSucKhoe.service';
import { KhamSucKhoeKetQua } from 'src/app/shared/KhamSucKhoeKetQua.model';
import { KhamSucKhoeKetQuaService } from 'src/app/shared/KhamSucKhoeKetQua.service';

@Component({
  selector: 'app-kham-suc-khoe-info',
  templateUrl: './kham-suc-khoe-info.component.html',
  styleUrls: ['./kham-suc-khoe-info.component.css']
})
export class KhamSucKhoeInfoComponent implements OnInit {

  @ViewChild('KhamSucKhoeKetQuaSort') KhamSucKhoeKetQuaSort: MatSort;
  @ViewChild('KhamSucKhoeKetQuaPaginator') KhamSucKhoeKetQuaPaginator: MatPaginator;

  IsKhamSucKhoeKetQua: boolean = false;

  URLExcelKhamSucKhoeKetQua: string = environment.APIRootURL + environment.Download + "/KhamSucKhoeKetQua.xlsx";

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamSucKhoeService: KhamSucKhoeService,
    public KhamSucKhoeKetQuaService: KhamSucKhoeKetQuaService,
  ) { }

  ngOnInit(): void {
    this.KhamSucKhoeService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.KhamSucKhoeSearch();
  }
  DateNgayBatDau(value) {
    this.KhamSucKhoeService.FormData.NgayBatDau = new Date(value);
  }
  DateNgayKetThuc(value) {
    this.KhamSucKhoeService.FormData.NgayKetThuc = new Date(value);
  }
  KhamSucKhoeSearch() {
    this.KhamSucKhoeService.IsShowLoading = true;
    this.KhamSucKhoeService.GetByIDAsync().subscribe(
      res => {
        this.KhamSucKhoeService.FormData = res as KhamSucKhoe;
        this.KhamSucKhoeKetQuaSearch();
      },
      err => {
      },
      () => {
        this.KhamSucKhoeService.IsShowLoading = false;
      }
    );
  }
  KhamSucKhoeSave() {
    this.KhamSucKhoeService.IsShowLoading = true;
    this.KhamSucKhoeService.SaveAsync().subscribe(
      res => {
        this.KhamSucKhoeService.FormData = res as KhamSucKhoe;
        this.Router.navigateByUrl(environment.KhamSucKhoeInfo + this.KhamSucKhoeService.FormData.ID);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.KhamSucKhoeService.IsShowLoading = false;
      }
    );
  }
  KhamSucKhoeAdd() {
    this.Router.navigateByUrl(environment.KhamSucKhoeInfo + environment.InitializationNumber);
    this.KhamSucKhoeService.BaseParameter.ID = environment.InitializationNumber;
    this.KhamSucKhoeSearch();
  }
  KhamSucKhoeKetQuaSearch() {
    this.KhamSucKhoeKetQuaService.BaseParameter.ParentID = this.KhamSucKhoeService.FormData.ID;
    this.KhamSucKhoeKetQuaService.SearchByParentID(this.KhamSucKhoeKetQuaSort, this.KhamSucKhoeKetQuaPaginator, this.KhamSucKhoeService);
  }
  KhamSucKhoeKetQuaSave(element: KhamSucKhoeKetQua) {
    this.KhamSucKhoeKetQuaService.FormData = element;
    this.NotificationService.warn(this.KhamSucKhoeKetQuaService.ComponentSaveByParentID(this.KhamSucKhoeKetQuaSort, this.KhamSucKhoeKetQuaPaginator, this.KhamSucKhoeService));
  }
  KhamSucKhoeKetQuaDelete(element: KhamSucKhoeKetQua) {
    this.KhamSucKhoeKetQuaService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.KhamSucKhoeKetQuaService.ComponentDeleteByParentID(this.KhamSucKhoeKetQuaSort, this.KhamSucKhoeKetQuaPaginator, this.KhamSucKhoeService));
  }
  KhamSucKhoeKetQuaChangeFile(files: FileList) {
    if (files) {
      this.KhamSucKhoeKetQuaService.FileToUpload = files;
      if (this.KhamSucKhoeService.FormData.ID > 0) {
        this.IsKhamSucKhoeKetQua = true;
      }
    }
  }
  KhamSucKhoeKetQuaUpload() {
    this.KhamSucKhoeService.IsShowLoading = true;
    this.KhamSucKhoeKetQuaService.BaseParameter.ParentID = this.KhamSucKhoeService.FormData.ID;
    this.KhamSucKhoeKetQuaService.SaveListByExcelFileAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
        this.KhamSucKhoeKetQuaSearch();
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.KhamSucKhoeService.IsShowLoading = false;
      }
    );
  }
}
