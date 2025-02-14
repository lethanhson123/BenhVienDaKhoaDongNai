import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamBenh_VaoVien } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_VaoVien.model';
import { KhamBenh_VaoVienService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_VaoVien.service';

@Component({
  selector: 'app-kham-benh-vao-vien',
  templateUrl: './kham-benh-vao-vien.component.html',
  styleUrls: ['./kham-benh-vao-vien.component.css']
})
export class KhamBenhVaoVienComponent implements OnInit {

  @ViewChild('KhamBenh_VaoVienSort') KhamBenh_VaoVienSort: MatSort;
  @ViewChild('KhamBenh_VaoVienPaginator') KhamBenh_VaoVienPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamBenh_VaoVienService: KhamBenh_VaoVienService,

   
  ) { }

  ngOnInit(): void {
    this.KhamBenh_VaoVienService.BaseParameter.BatDau = new Date();
  }
  DateBatDau(value) {
    this.KhamBenh_VaoVienService.BaseParameter.BatDau = new Date(value);
  }
  
  KhamBenh_VaoVienSearch() {
    if (this.KhamBenh_VaoVienService.BaseParameter.IsSearchAPI == true) {
      this.KhamBenh_VaoVienService.IsShowLoading = true;
      this.KhamBenh_VaoVienService.GetByNgayKham_SearchStringToListAsync().subscribe(
        res => {
          this.KhamBenh_VaoVienService.List = (res as KhamBenh_VaoVien[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.KhamBenh_VaoVienService.RenderToListTransfer(this.KhamBenh_VaoVienSort, this.KhamBenh_VaoVienPaginator);
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      this.KhamBenh_VaoVienService.BaseParameter.SearchString = this.KhamBenh_VaoVienService.BaseParameter.SearchString.trim();
      if (this.KhamBenh_VaoVienService.DataSource) {
        this.KhamBenh_VaoVienService.DataSource.filter = this.KhamBenh_VaoVienService.BaseParameter.SearchString.toLowerCase();
      }
    }
  }
  KhamBenh_VaoVienSave(element: KhamBenh_VaoVien) {
    this.KhamBenh_VaoVienService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_VaoVienService.ComponentSaveAll(this.KhamBenh_VaoVienSort, this.KhamBenh_VaoVienPaginator));
  }
  KhamBenh_VaoVienDelete(element: KhamBenh_VaoVien) {
    this.KhamBenh_VaoVienService.FormData = element;
    this.NotificationService.warn(this.KhamBenh_VaoVienService.ComponentDeleteAll(this.KhamBenh_VaoVienSort, this.KhamBenh_VaoVienPaginator));
  }
}
