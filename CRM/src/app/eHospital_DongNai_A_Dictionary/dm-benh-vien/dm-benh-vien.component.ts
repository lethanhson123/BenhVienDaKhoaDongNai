import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_BenhVien } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.model';
import { DM_BenhVienService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.service';

@Component({
  selector: 'app-dm-benh-vien',
  templateUrl: './dm-benh-vien.component.html',
  styleUrls: ['./dm-benh-vien.component.css']
})
export class DMBenhVienComponent implements OnInit {

  @ViewChild('DM_BenhVienSort') DM_BenhVienSort: MatSort;
  @ViewChild('DM_BenhVienPaginator') DM_BenhVienPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BenhVienService: DM_BenhVienService,
  ) { }

  ngOnInit(): void {
    this.DM_BenhVienSearch();
  }

  DM_BenhVienSearch() {
    this.DM_BenhVienService.GetBySearchStringAndEmptyToListAsync().subscribe(
      res => {
        this.DM_BenhVienService.List = (res as DM_BenhVien[]);
        this.DM_BenhVienService.DataSource = new MatTableDataSource(this.DM_BenhVienService.List);
        this.DM_BenhVienService.DataSource.sort = this.DM_BenhVienSort;
        this.DM_BenhVienService.DataSource.paginator = this.DM_BenhVienPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_BenhVienSave(element: DM_BenhVien) {
    this.DM_BenhVienService.FormData = element;
    this.DM_BenhVienService.IsShowLoading = true;
    this.DM_BenhVienService.FormData = element;
    this.DM_BenhVienService.SaveAsync().subscribe(
      res => {
        this.DM_BenhVienService.FormData = res as DM_BenhVien;
        this.DM_BenhVienSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_BenhVienService.IsShowLoading = false;
      }
    );
  }
  DM_BenhVienDelete(element: DM_BenhVien) {
    this.DM_BenhVienService.FormData = element;
    this.NotificationService.warn(this.DM_BenhVienService.ComponentDeleteAll(this.DM_BenhVienSort, this.DM_BenhVienPaginator));
  }
}