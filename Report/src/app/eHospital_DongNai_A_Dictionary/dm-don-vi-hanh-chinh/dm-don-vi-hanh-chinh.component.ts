import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_DonViHanhChinh } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.model';
import { DM_DonViHanhChinhService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViHanhChinh.service';

@Component({
  selector: 'app-dm-don-vi-hanh-chinh',
  templateUrl: './dm-don-vi-hanh-chinh.component.html',
  styleUrls: ['./dm-don-vi-hanh-chinh.component.css']
})
export class DMDonViHanhChinhComponent implements OnInit {

  @ViewChild('DM_DonViHanhChinhSort') DM_DonViHanhChinhSort: MatSort;
  @ViewChild('DM_DonViHanhChinhPaginator') DM_DonViHanhChinhPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_DonViHanhChinhService: DM_DonViHanhChinhService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.DM_DonViHanhChinhSearch();
  }
  DM_DonViHanhChinhSearch() {
    this.DM_DonViHanhChinhService.SearchBySearchStringAndEmptyToListAsync(this.DM_DonViHanhChinhSort, this.DM_DonViHanhChinhPaginator);
  }
  DM_DonViHanhChinhSave(element: DM_DonViHanhChinh) {
    this.DM_DonViHanhChinhService.FormData = element;
    this.NotificationService.warn(this.DM_DonViHanhChinhService.ComponentSaveSearchString(this.DM_DonViHanhChinhSort, this.DM_DonViHanhChinhPaginator));
  }
  DM_DonViHanhChinhDelete(element: DM_DonViHanhChinh) {
    this.DM_DonViHanhChinhService.FormData = element;
    this.NotificationService.warn(this.DM_DonViHanhChinhService.ComponentDeleteSearchString(this.DM_DonViHanhChinhSort, this.DM_DonViHanhChinhPaginator));
  }
}