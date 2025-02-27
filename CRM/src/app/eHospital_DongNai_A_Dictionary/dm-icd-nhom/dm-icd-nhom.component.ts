import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_ICD_Nhom } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Nhom.model';
import { DM_ICD_NhomService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Nhom.service';

import { DM_ICD_Chuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Chuong.model';
import { DM_ICD_ChuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Chuong.service';

@Component({
  selector: 'app-dm-icd-nhom',
  templateUrl: './dm-icd-nhom.component.html',
  styleUrls: ['./dm-icd-nhom.component.css']
})
export class DMICDNhomComponent implements OnInit {

  @ViewChild('DM_ICD_NhomSort') DM_ICD_NhomSort: MatSort;
  @ViewChild('DM_ICD_NhomPaginator') DM_ICD_NhomPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_ICD_NhomService: DM_ICD_NhomService,
    public DM_ICD_ChuongService: DM_ICD_ChuongService,
  ) { }

  ngOnInit(): void {
    this.DM_ICD_ChuongSearch();    
  }
  DM_ICD_ChuongSearch() {
    this.DM_ICD_ChuongService.ComponentGetAllToListAsync(this.DM_ICD_NhomService);
  }
  DM_ICD_ChuongFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_ICD_ChuongService.ListFilter = this.DM_ICD_ChuongService.List.filter(item => item.TenChuongICD.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaChuongICD.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_ICD_ChuongService.ListFilter = this.DM_ICD_ChuongService.List;
    }
  }
  DM_ICD_NhomSearch() {
    this.DM_ICD_NhomService.SearchAll(this.DM_ICD_NhomSort, this.DM_ICD_NhomPaginator);
  }
  DM_ICD_NhomSave(element: DM_ICD_Nhom) {
    this.DM_ICD_NhomService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_NhomService.ComponentSaveAll(this.DM_ICD_NhomSort, this.DM_ICD_NhomPaginator));
  }
  DM_ICD_NhomDelete(element: DM_ICD_Nhom) {
    this.DM_ICD_NhomService.FormData = element;
    this.NotificationService.warn(this.DM_ICD_NhomService.ComponentDeleteAll(this.DM_ICD_NhomSort, this.DM_ICD_NhomPaginator));
  }
}
