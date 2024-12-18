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

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent implements OnInit {

  IsDanhMucTinhThanhToaDo: boolean = false;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void {

  }
  DanhMucTinhThanhToaDoChangeFile(files: FileList) {
    if (files) {
      this.DanhMucTinhThanhToaDoService.FileToUpload = files;
      this.IsDanhMucTinhThanhToaDo = true;
    }
  }
  DanhMucTinhThanhToaDoSave() {
    this.DanhMucTinhThanhToaDoService.IsShowLoading = true;
    this.DanhMucTinhThanhToaDoService.PostDanhMucTinhThanhToaDo3ByJSONFileAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucTinhThanhToaDoService.IsShowLoading = false;
      }
    );
  }
}
