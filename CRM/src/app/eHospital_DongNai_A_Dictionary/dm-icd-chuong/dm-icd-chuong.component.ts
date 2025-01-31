import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_ICD_Chuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Chuong.model';
import { DM_ICD_ChuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Chuong.service';

@Component({
  selector: 'app-dm-icd-chuong',
  templateUrl: './dm-icd-chuong.component.html',
  styleUrls: ['./dm-icd-chuong.component.css']
})
export class DMICDChuongComponent implements OnInit {

  @ViewChild('DM_ICD_ChuongSort') DM_ICD_ChuongSort: MatSort;
  @ViewChild('DM_ICD_ChuongPaginator') DM_ICD_ChuongPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_ICD_ChuongService: DM_ICD_ChuongService,
  ) { }

  ngOnInit(): void {
    this.DM_ICD_ChuongSearch();
  }

  DM_ICD_ChuongSearch() {
    this.DM_ICD_ChuongService.SearchAll(this.DM_ICD_ChuongSort, this.DM_ICD_ChuongPaginator);
  }
  DM_ICD_ChuongSave(element: DM_ICD_Chuong) {
    this.DM_ICD_ChuongService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_ChuongService.ComponentSaveAll(this.DM_ICD_ChuongSort, this.DM_ICD_ChuongPaginator));
  }
  DM_ICD_ChuongDelete(element: DM_ICD_Chuong) {
    this.DM_ICD_ChuongService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_ChuongService.ComponentDeleteAll(this.DM_ICD_ChuongSort, this.DM_ICD_ChuongPaginator));
  }
}