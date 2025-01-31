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

import { DM_ICD_Nhom } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Nhom.model';
import { DM_ICD_NhomService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_ICD_Nhom.service';



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
    public DM_ICD_NhomService: DM_ICD_NhomService,
    
  ) { }

  ngOnInit(): void {
    this.DM_ICD_NhomSearch();    
  }

  DM_ICD_NhomSearch() {
    this.DM_ICD_NhomService.ComponentGetAllToListAsync(this.DM_ICDService);
  }
  DM_ICD_NhomFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_ICD_NhomService.ListFilter = this.DM_ICD_NhomService.List.filter(item => item.TenNhomICD.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaNhomICD.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_ICD_NhomService.ListFilter = this.DM_ICD_NhomService.List;
    }
  }
 
  DM_ICDSearch() {
    this.DM_ICDService.IsShowLoading = true;
    this.DM_ICDService.GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync().subscribe(
      res => {
        this.DM_ICDService.List = (res as any[]);
        this.DM_ICDService.DataSource = new MatTableDataSource(this.DM_ICDService.List);
        this.DM_ICDService.DataSource.sort = this.DM_ICDSort;
        this.DM_ICDService.DataSource.paginator = this.DM_ICDPaginator;
      },
      err => {
      },
      () => {
        this.DM_ICDService.IsShowLoading = false;
      }
    );
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