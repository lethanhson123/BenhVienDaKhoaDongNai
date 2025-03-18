import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucHopDong } from 'src/app/shared//DanhMucHopDong.model';
import { DanhMucHopDongService } from 'src/app/shared//DanhMucHopDong.service';

@Component({
  selector: 'app-danh-muc-hop-dong-info',
  templateUrl: './danh-muc-hop-dong-info.component.html',
  styleUrls: ['./danh-muc-hop-dong-info.component.css']
})
export class DanhMucHopDongInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucHopDongService: DanhMucHopDongService,

  ) { }

  ngOnInit(): void {    
    
  }
  ngAfterViewInit() {
    this.DanhMucHopDongSearch();
  }
  DanhMucHopDongAdd() {
    this.Router.navigateByUrl(environment.DanhMucHopDongInfo + environment.InitializationNumber);
    this.DanhMucHopDongService.BaseParameter.ID = environment.InitializationNumber;
    this.DanhMucHopDongSearch();
  }
  DanhMucHopDongSearch() {
    this.DanhMucHopDongService.IsShowLoading = true;
    this.DanhMucHopDongService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.DanhMucHopDongService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucHopDongService.FormData = res as DanhMucHopDong;
      },
      err => {
      },
      () => {
        this.DanhMucHopDongService.IsShowLoading = false;
      }
    );
  }
  DanhMucHopDongFileNameChange(files: FileList) {
    if (files) {
      this.DanhMucHopDongService.FileToUpload = files;
    }
  }
  DanhMucHopDongSave() {
    this.DanhMucHopDongService.IsShowLoading = true;
    this.DanhMucHopDongService.SaveAndUploadFileAsync().subscribe(
      res => {
        this.DanhMucHopDongService.FormData = res as DanhMucHopDong;
        this.Router.navigateByUrl(environment.DanhMucHopDongInfo + this.DanhMucHopDongService.FormData.ID);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucHopDongService.IsShowLoading = false;
      }
    );
  }
  DanhMucHopDongDelete() {
    this.DanhMucHopDongService.IsShowLoading = true;
    this.DanhMucHopDongService.BaseParameter.ID = this.DanhMucHopDongService.FormData.ID;
    this.DanhMucHopDongService.RemoveAsync().subscribe(
      res => {
        this.DanhMucHopDongAdd();
        this.NotificationService.warn(environment.DeleteSuccess);
      },
      err => {
        this.NotificationService.warn(environment.DeleteNotSuccess);
      },
      () => {
        this.DanhMucHopDongService.IsShowLoading = false;
      }
    );
  }
  DanhMucHopDongCopy() {
    this.DanhMucHopDongService.FormData.ID = environment.InitializationNumber;
    this.DanhMucHopDongSave();
  }
}
