import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_BangGia_CPH } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BangGia_CPH.model';
import { DM_BangGia_CPHService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BangGia_CPH.service';
import { DM_LoaiGia } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.model';
import { DM_LoaiGiaService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_LoaiGia.service';

@Component({
  selector: 'app-dm-bang-gia-cph',
  templateUrl: './dm-bang-gia-cph.component.html',
  styleUrls: ['./dm-bang-gia-cph.component.css']
})
export class DMBangGiaCPHComponent implements OnInit {

  @ViewChild('DM_BangGia_CPHSort') DM_BangGia_CPHSort: MatSort;
  @ViewChild('DM_BangGia_CPHPaginator') DM_BangGia_CPHPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BangGia_CPHService: DM_BangGia_CPHService,
    public DM_LoaiGiaService: DM_LoaiGiaService,
  ) { }

  ngOnInit(): void {
    this.DM_LoaiGiaSearch();
    this.DM_BangGia_CPHSearch();
  }
  DM_LoaiGiaSearch() {
    this.DM_LoaiGiaService.ComponentGetAllToListAsync(this.DM_BangGia_CPHService);
  }
  DM_BangGia_CPHSearch() {
    if (this.DM_BangGia_CPHService.BaseParameter.SearchString.length > 0) {
      this.DM_BangGia_CPHService.BaseParameter.SearchString = this.DM_BangGia_CPHService.BaseParameter.SearchString.trim();
      if (this.DM_BangGia_CPHService.DataSource) {
        this.DM_BangGia_CPHService.DataSource.filter = this.DM_BangGia_CPHService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_BangGia_CPHService.IsShowLoading = true;
      this.DM_BangGia_CPHService.GetAllToListAsync().subscribe(
        res => {
          this.DM_BangGia_CPHService.List = (res as DM_BangGia_CPH[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));
          this.DM_BangGia_CPHService.DataSource = new MatTableDataSource(this.DM_BangGia_CPHService.List);
          this.DM_BangGia_CPHService.DataSource.sort = this.DM_BangGia_CPHSort;
          this.DM_BangGia_CPHService.DataSource.paginator = this.DM_BangGia_CPHPaginator;
        },
        err => {
        },
        () => {
          this.DM_BangGia_CPHService.IsShowLoading = false;
        }
      );
    }
  }
  DM_BangGia_CPHSave(element: DM_BangGia_CPH) {
    this.DM_BangGia_CPHService.FormData = element;
    this.NotificationService.warn(this.DM_BangGia_CPHService.ComponentSaveAll(this.DM_BangGia_CPHSort, this.DM_BangGia_CPHPaginator));
  }
  DM_BangGia_CPHDelete(element: DM_BangGia_CPH) {
    this.DM_BangGia_CPHService.FormData = element;
    this.NotificationService.warn(this.DM_BangGia_CPHService.ComponentDeleteAll(this.DM_BangGia_CPHSort, this.DM_BangGia_CPHPaginator));
  }
}