import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_DonViTinh } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViTinh.model';
import { DM_DonViTinhService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DonViTinh.service';

@Component({
  selector: 'app-dm-don-vi-tinh',
  templateUrl: './dm-don-vi-tinh.component.html',
  styleUrls: ['./dm-don-vi-tinh.component.css']
})
export class DMDonViTinhComponent implements OnInit {

  @ViewChild('DM_DonViTinhSort') DM_DonViTinhSort: MatSort;
  @ViewChild('DM_DonViTinhPaginator') DM_DonViTinhPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_DonViTinhService: DM_DonViTinhService,
  ) { }

  ngOnInit(): void {
    this.DM_DonViTinhSearch();
  }

  DM_DonViTinhSearch() {
    this.DM_DonViTinhService.SearchAll(this.DM_DonViTinhSort, this.DM_DonViTinhPaginator);
  }
  DM_DonViTinhSave(element: DM_DonViTinh) {
    this.DM_DonViTinhService.FormData = element;
    this.NotificationService.warn(this.DM_DonViTinhService.ComponentSaveAll(this.DM_DonViTinhSort, this.DM_DonViTinhPaginator));
  }
  DM_DonViTinhDelete(element: DM_DonViTinh) {
    this.DM_DonViTinhService.FormData = element;
    this.NotificationService.warn(this.DM_DonViTinhService.ComponentDeleteAll(this.DM_DonViTinhSort, this.DM_DonViTinhPaginator));
  }
}