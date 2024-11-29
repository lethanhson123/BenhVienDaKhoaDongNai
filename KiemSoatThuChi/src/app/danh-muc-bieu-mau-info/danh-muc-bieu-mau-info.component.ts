import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucBieuMau } from 'src/app/shared/DanhMucBieuMau.model';
import { DanhMucBieuMauService } from 'src/app/shared/DanhMucBieuMau.service';

@Component({
  selector: 'app-danh-muc-bieu-mau-info',
  templateUrl: './danh-muc-bieu-mau-info.component.html',
  styleUrls: ['./danh-muc-bieu-mau-info.component.css']
})
export class DanhMucBieuMauInfoComponent implements OnInit {

  constructor( 
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,    

    public DanhMucBieuMauService: DanhMucBieuMauService,
    
  ) { }

  ngOnInit(): void {
    this.DanhMucBieuMauService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.DanhMucBieuMauSearch();
  }
  
  
  DanhMucBieuMauSearch() {
    this.DanhMucBieuMauService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucBieuMauService.FormData = res as DanhMucBieuMau;     
      },
      err => {
      }
    );
  }
  DanhMucBieuMauChangeFile(files: FileList) {
    if (files) {
      this.DanhMucBieuMauService.FileToUpload = files;
    }
  }
  DanhMucBieuMauSave() {
    this.DanhMucBieuMauService.IsShowLoading = true;
    this.DanhMucBieuMauService.SaveAndUploadFileAsync().subscribe(
      res => {
        this.DanhMucBieuMauService.FormData = res as DanhMucBieuMau;      
        this.Router.navigateByUrl(environment.DanhMucBieuMauInfo + this.DanhMucBieuMauService.FormData.ID);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucBieuMauService.IsShowLoading = false;
      }
    );
  }
  DanhMucBieuMauAdd() {
    this.Router.navigateByUrl(environment.DanhMucBieuMauInfo + environment.InitializationNumber);
    this.DanhMucBieuMauService.BaseParameter.ID = environment.InitializationNumber;
    this.DanhMucBieuMauSearch();
  }
  
}