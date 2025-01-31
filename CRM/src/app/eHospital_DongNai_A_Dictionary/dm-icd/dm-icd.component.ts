import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_ICD } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.model';
import { DM_ICDService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD.service';

@Component({
  selector: 'app-dm-icd',
  templateUrl: './dm-icd.component.html',
  styleUrls: ['./dm-icd.component.css']
})
export class DMICDComponent implements OnInit {

  @ViewChild('DM_ICDSort') DM_ICDSort: MatSort;
  @ViewChild('DM_ICDPaginator') DM_ICDPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_ICDService: DM_ICDService,
  ) { }

  ngOnInit(): void {
    //this.DM_ICDSearch();
  }

  DM_ICDSearch() {
    this.DM_ICDService.SearchAll(this.DM_ICDSort, this.DM_ICDPaginator);
  }
  DM_ICDSave(element: DM_ICD) {
    this.DM_ICDService.FormData = element;
    this.NotificationService.warn(this.DM_ICDService.ComponentSaveAll(this.DM_ICDSort, this.DM_ICDPaginator));
  }
  DM_ICDDelete(element: DM_ICD) {
    this.DM_ICDService.FormData = element;
    this.NotificationService.warn(this.DM_ICDService.ComponentDeleteAll(this.DM_ICDSort, this.DM_ICDPaginator));
  }
}