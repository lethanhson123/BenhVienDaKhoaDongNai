import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_LoaiDichVu } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiDichVu.model';
import { DM_LoaiDichVuService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiDichVu.service';

@Component({
  selector: 'app-dm-loai-dich-vu',
  templateUrl: './dm-loai-dich-vu.component.html',
  styleUrls: ['./dm-loai-dich-vu.component.css']
})
export class DMLoaiDichVuComponent implements OnInit {

  @ViewChild('DM_LoaiDichVuSort') DM_LoaiDichVuSort: MatSort;
  @ViewChild('DM_LoaiDichVuPaginator') DM_LoaiDichVuPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_LoaiDichVuService: DM_LoaiDichVuService,
  ) { }

  ngOnInit(): void {
    this.DM_LoaiDichVuSearch();
  }

  DM_LoaiDichVuSearch() {
    this.DM_LoaiDichVuService.SearchAll(this.DM_LoaiDichVuSort, this.DM_LoaiDichVuPaginator);
  }
  DM_LoaiDichVuSave(element: DM_LoaiDichVu) {
    this.DM_LoaiDichVuService.FormData = element;
    this.NotificationService.warn(this.DM_LoaiDichVuService.ComponentSaveAll(this.DM_LoaiDichVuSort, this.DM_LoaiDichVuPaginator));
  }
  DM_LoaiDichVuDelete(element: DM_LoaiDichVu) {
    this.DM_LoaiDichVuService.FormData = element;
    this.NotificationService.warn(this.DM_LoaiDichVuService.ComponentDeleteAll(this.DM_LoaiDichVuSort, this.DM_LoaiDichVuPaginator));
  }
}