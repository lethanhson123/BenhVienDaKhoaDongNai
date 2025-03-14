import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_ICD_Common } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Common.model';
import { DM_ICD_CommonService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Common.service';

@Component({
  selector: 'app-dm-icd-common',
  templateUrl: './dm-icd-common.component.html',
  styleUrls: ['./dm-icd-common.component.css']
})
export class DMICDCommonComponent implements OnInit {

  @ViewChild('DM_ICD_CommonSort') DM_ICD_CommonSort: MatSort;
  @ViewChild('DM_ICD_CommonPaginator') DM_ICD_CommonPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_ICD_CommonService: DM_ICD_CommonService,
  ) { }

  ngOnInit(): void {
    this.DM_ICD_CommonSearch();
  }

  DM_ICD_CommonSearch() {
    this.DM_ICD_CommonService.SearchAll(this.DM_ICD_CommonSort, this.DM_ICD_CommonPaginator);
  }
  DM_ICD_CommonSave(element: DM_ICD_Common) {
    this.DM_ICD_CommonService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_CommonService.ComponentSaveAll(this.DM_ICD_CommonSort, this.DM_ICD_CommonPaginator));
  }
  DM_ICD_CommonDelete(element: DM_ICD_Common) {
    this.DM_ICD_CommonService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_CommonService.ComponentDeleteAll(this.DM_ICD_CommonSort, this.DM_ICD_CommonPaginator));
  }
}