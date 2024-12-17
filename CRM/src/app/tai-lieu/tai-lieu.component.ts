import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TaiLieu } from 'src/app/shared/TaiLieu.model';
import { TaiLieuService } from 'src/app/shared/TaiLieu.service';

@Component({
  selector: 'app-tai-lieu',
  templateUrl: './tai-lieu.component.html',
  styleUrls: ['./tai-lieu.component.css']
})
export class TaiLieuComponent {

  @ViewChild('TaiLieuSort') TaiLieuSort: MatSort;
  @ViewChild('TaiLieuPaginator') TaiLieuPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TaiLieuService: TaiLieuService,
  ) { }

  ngOnInit(): void { 
    this.TaiLieuSearch();
  }

  TaiLieuSearch() {
    this.TaiLieuService.SearchAll(this.TaiLieuSort, this.TaiLieuPaginator);
  }
  TaiLieuSave(element: TaiLieu) {
    this.TaiLieuService.IsShowLoading = true;
    this.TaiLieuService.FormData = element;
    this.TaiLieuService.SaveAndUploadFileAsync().subscribe(
      res => {
        this.TaiLieuSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.TaiLieuService.IsShowLoading = false;
      }
    );
  }
  TaiLieuDelete(element: TaiLieu) {
    this.TaiLieuService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.TaiLieuService.ComponentDeleteAll(this.TaiLieuSort, this.TaiLieuPaginator));
  }  
  TaiLieuChangeFile(files: FileList) {
    if (files) {
      this.TaiLieuService.FileToUpload = files;
    }
  }
}
