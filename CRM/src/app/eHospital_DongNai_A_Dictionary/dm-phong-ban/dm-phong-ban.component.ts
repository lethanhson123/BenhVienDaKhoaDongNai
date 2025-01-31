import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';


@Component({
  selector: 'app-dm-phong-ban',
  templateUrl: './dm-phong-ban.component.html',
  styleUrls: ['./dm-phong-ban.component.css']
})
export class DMPhongBanComponent implements OnInit {

  @ViewChild('DM_PhongBanSort') DM_PhongBanSort: MatSort;
  @ViewChild('DM_PhongBanPaginator') DM_PhongBanPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_PhongBanService: DM_PhongBanService,
  ) { }

  ngOnInit(): void {
    this.DM_PhongBanSearch();
  }

  DM_PhongBanSearch() {
    this.DM_PhongBanService.SearchAll(this.DM_PhongBanSort, this.DM_PhongBanPaginator);
  }
  DM_PhongBanSave(element: DM_PhongBan) {
    this.DM_PhongBanService.FormData = element;
    this.NotificationService.warn(this.DM_PhongBanService.ComponentSaveAll(this.DM_PhongBanSort, this.DM_PhongBanPaginator));
  }
  DM_PhongBanDelete(element: DM_PhongBan) {
    this.DM_PhongBanService.FormData = element;
    this.NotificationService.warn(this.DM_PhongBanService.ComponentDeleteAll(this.DM_PhongBanSort, this.DM_PhongBanPaginator));
  }
}