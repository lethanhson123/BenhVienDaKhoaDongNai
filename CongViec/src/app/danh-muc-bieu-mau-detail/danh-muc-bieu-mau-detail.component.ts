import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';
import { from } from 'rxjs';
import { distinct } from 'rxjs/operators';

import { DanhMucBieuMau } from 'src/app/shared/DanhMucBieuMau.model';
import { DanhMucBieuMauService } from 'src/app/shared/DanhMucBieuMau.service';

@Component({
  selector: 'app-danh-muc-bieu-mau-detail',
  templateUrl: './danh-muc-bieu-mau-detail.component.html',
  styleUrls: ['./danh-muc-bieu-mau-detail.component.css']
})
export class DanhMucBieuMauDetailComponent implements OnInit {

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DanhMucBieuMauDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,    

    public DanhMucBieuMauService: DanhMucBieuMauService,
    
  ) { }

  ngOnInit(): void {
    this.DanhMucBieuMauSearch();
  }
  Close() {
    this.DialogRef.close();
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

  
}
