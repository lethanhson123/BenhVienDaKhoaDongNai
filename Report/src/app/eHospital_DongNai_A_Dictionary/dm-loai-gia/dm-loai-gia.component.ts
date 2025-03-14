import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_LoaiGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.model';
import { DM_LoaiGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.service';

@Component({
  selector: 'app-dm-loai-gia',
  templateUrl: './dm-loai-gia.component.html',
  styleUrls: ['./dm-loai-gia.component.css']
})
export class DMLoaiGiaComponent implements OnInit {

  @ViewChild('DM_LoaiGiaSort') DM_LoaiGiaSort: MatSort;
  @ViewChild('DM_LoaiGiaPaginator') DM_LoaiGiaPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_LoaiGiaService: DM_LoaiGiaService,
  ) { }

  ngOnInit(): void {
    this.DM_LoaiGiaSearch();
  }

  DM_LoaiGiaSearch() {
    this.DM_LoaiGiaService.SearchAll(this.DM_LoaiGiaSort, this.DM_LoaiGiaPaginator);
  }
  DM_LoaiGiaSave(element: DM_LoaiGia) {
    this.DM_LoaiGiaService.FormData = element;
    this.NotificationService.warn(this.DM_LoaiGiaService.ComponentSaveAll(this.DM_LoaiGiaSort, this.DM_LoaiGiaPaginator));
  }
  DM_LoaiGiaDelete(element: DM_LoaiGia) {
    this.DM_LoaiGiaService.FormData = element;
    this.NotificationService.warn(this.DM_LoaiGiaService.ComponentDeleteAll(this.DM_LoaiGiaSort, this.DM_LoaiGiaPaginator));
  }
}
