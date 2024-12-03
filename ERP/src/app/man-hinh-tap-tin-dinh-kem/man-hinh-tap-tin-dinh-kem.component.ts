import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ManHinhTapTinDinhKem } from 'src/app/shared/ManHinhTapTinDinhKem.model';
import { ManHinhTapTinDinhKemService } from 'src/app/shared/ManHinhTapTinDinhKem.service';

@Component({
  selector: 'app-man-hinh-tap-tin-dinh-kem',
  templateUrl: './man-hinh-tap-tin-dinh-kem.component.html',
  styleUrls: ['./man-hinh-tap-tin-dinh-kem.component.css']
})
export class ManHinhTapTinDinhKemComponent implements OnInit {

  @ViewChild('ManHinhTapTinDinhKemSort') ManHinhTapTinDinhKemSort: MatSort;
  @ViewChild('ManHinhTapTinDinhKemPaginator') ManHinhTapTinDinhKemPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ManHinhTapTinDinhKemService: ManHinhTapTinDinhKemService,
  ) { }

  ngOnInit(): void { 
    this.ManHinhTapTinDinhKemSearch();
  }

  ManHinhTapTinDinhKemSearch() {
    this.ManHinhTapTinDinhKemService.SearchAll(this.ManHinhTapTinDinhKemSort, this.ManHinhTapTinDinhKemPaginator);
  }
  ManHinhTapTinDinhKemSave(element: ManHinhTapTinDinhKem) {
    this.ManHinhTapTinDinhKemService.IsShowLoading = true;
    this.ManHinhTapTinDinhKemService.FormData = element;
    this.ManHinhTapTinDinhKemService.SaveAndUploadFilesAsync().subscribe(
      res => {
        this.ManHinhTapTinDinhKemSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ManHinhTapTinDinhKemService.IsShowLoading = false;
      }
    );
  }
  ManHinhTapTinDinhKemDelete(element: ManHinhTapTinDinhKem) {
    this.ManHinhTapTinDinhKemService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ManHinhTapTinDinhKemService.ComponentDeleteAll(this.ManHinhTapTinDinhKemSort, this.ManHinhTapTinDinhKemPaginator));
  }  
  ManHinhTapTinDinhKemChangeFile(files: FileList) {
    if (files) {
      this.ManHinhTapTinDinhKemService.FileToUpload = files;
    }
  }
}