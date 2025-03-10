import { Component, OnInit, ViewChild, ElementRef, AfterViewInit, OnDestroy } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { DanhMucTinhThanhToaDoService } from 'src/app/shared/DanhMucTinhThanhToaDo.service';

import { UploadService } from 'src/app/shared/Upload.service';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {

  IsDanhMucTinhThanhToaDo: boolean = false;
  IsDanhMucPhongBan: boolean = false;
  IsDanhMucChucDanh: boolean = false;


  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
    public UploadService: UploadService,
  ) { }

  ngOnInit(): void {

  }
  DanhMucTinhThanhToaDoChangeFile(files: FileList) {
    if (files) {
      this.UploadService.FileToUpload = files;
      this.IsDanhMucTinhThanhToaDo = true;
    }
  }
  DanhMucPhongBanChangeFile(files: FileList) {
    if (files) {
      this.UploadService.FileToUpload = files;
      this.IsDanhMucPhongBan = true;
    }
  }
  DanhMucChucDanhChangeFile(files: FileList) {
    if (files) {
      this.UploadService.FileToUpload = files;
      this.IsDanhMucChucDanh = true;
    }
  }
  DanhMucTinhThanhToaDoSave() {
    this.UploadService.IsShowLoading = true;
    this.UploadService.PostDanhMucTinhThanhToaDo3ByJSONFileAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.UploadService.IsShowLoading = false;
      }
    );
  }
  DanhMucPhongBanSave() {
    this.UploadService.IsShowLoading = true;
    this.UploadService.PostDanhMucPhongBanByExcelFileAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.UploadService.IsShowLoading = false;
      }
    );
  }
  DanhMucChucDanhSave() {
    this.UploadService.IsShowLoading = true;
    this.UploadService.PostDanhMucChucDanhByExcelFileAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.UploadService.IsShowLoading = false;
      }
    );
  }
}
