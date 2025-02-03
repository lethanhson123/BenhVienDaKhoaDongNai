import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_BangGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BangGia.model';
import { DM_BangGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BangGia.service';
import { DM_LoaiGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.model';
import { DM_LoaiGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.service';

@Component({
  selector: 'app-dm-bang-gia',
  templateUrl: './dm-bang-gia.component.html',
  styleUrls: ['./dm-bang-gia.component.css']
})
export class DMBangGiaComponent implements OnInit {

  @ViewChild('DM_BangGiaSort') DM_BangGiaSort: MatSort;
  @ViewChild('DM_BangGiaPaginator') DM_BangGiaPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BangGiaService: DM_BangGiaService,
    public DM_LoaiGiaService: DM_LoaiGiaService,
  ) { }

  ngOnInit(): void {
    this.DM_LoaiGiaSearch();
    this.DM_BangGiaSearch();
  }
  DM_LoaiGiaSearch() {
    this.DM_LoaiGiaService.ComponentGetAllToListAsync(this.DM_BangGiaService);
  }
  DM_BangGiaSearch() {
    if (this.DM_BangGiaService.BaseParameter.SearchString.length > 0) {
      this.DM_BangGiaService.BaseParameter.SearchString = this.DM_BangGiaService.BaseParameter.SearchString.trim();
      if (this.DM_BangGiaService.DataSource) {
        this.DM_BangGiaService.DataSource.filter = this.DM_BangGiaService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_BangGiaService.IsShowLoading = true;
      this.DM_BangGiaService.GetAllToListAsync().subscribe(
        res => {
          this.DM_BangGiaService.List = (res as DM_BangGia[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));
          this.DM_BangGiaService.DataSource = new MatTableDataSource(this.DM_BangGiaService.List);
          this.DM_BangGiaService.DataSource.sort = this.DM_BangGiaSort;
          this.DM_BangGiaService.DataSource.paginator = this.DM_BangGiaPaginator;
        },
        err => {
        },
        () => {
          this.DM_BangGiaService.IsShowLoading = false;
        }
      );
    }
  }
  DM_BangGiaSave(element: DM_BangGia) {
    this.DM_BangGiaService.FormData = element;
    this.NotificationService.warn(this.DM_BangGiaService.ComponentSaveAll(this.DM_BangGiaSort, this.DM_BangGiaPaginator));
  }
  DM_BangGiaDelete(element: DM_BangGia) {
    this.DM_BangGiaService.FormData = element;
    this.NotificationService.warn(this.DM_BangGiaService.ComponentDeleteAll(this.DM_BangGiaSort, this.DM_BangGiaPaginator));
  }
}
