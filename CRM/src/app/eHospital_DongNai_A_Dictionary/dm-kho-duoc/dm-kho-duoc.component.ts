import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_KhoDuoc } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.model';
import { DM_KhoDuocService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.service';

import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

@Component({
  selector: 'app-dm-kho-duoc',
  templateUrl: './dm-kho-duoc.component.html',
  styleUrls: ['./dm-kho-duoc.component.css']
})
export class DMKhoDuocComponent implements OnInit {

  @ViewChild('DM_KhoDuocSort') DM_KhoDuocSort: MatSort;
  @ViewChild('DM_KhoDuocPaginator') DM_KhoDuocPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_KhoDuocService: DM_KhoDuocService,

    public DM_PhongBanService: DM_PhongBanService,
    public Lst_DictionaryService: Lst_DictionaryService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DM_NhomDichVuSearch();
    this.Lst_DictionarySearch();
  }
  Lst_DictionarySearch() {
    this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDLoaiKho;
    this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
      res => {
        this.Lst_DictionaryService.List = (res as any[]);
      },
      err => {
      },
      () => {
      }
    );
  }
  DM_NhomDichVuSearch() {
    this.DM_PhongBanService.ComponentGetAllToListAsync(this.DM_KhoDuocService);
  }
  DM_PhongBanFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List.filter(item => item.TenPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1 || item.MaPhongBan.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List;
    }
  }

  DM_KhoDuocSearch() {
    if (this.DM_KhoDuocService.BaseParameter.SearchString.length > 0) {
      this.DM_KhoDuocService.BaseParameter.SearchString = this.DM_KhoDuocService.BaseParameter.SearchString.trim();
      if (this.DM_KhoDuocService.DataSource) {
        this.DM_KhoDuocService.DataSource.filter = this.DM_KhoDuocService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_KhoDuocService.IsShowLoading = true;
      this.DM_KhoDuocService.GetByPhongBan_IdAndEmptyToListAsync().subscribe(
        res => {
          this.DM_KhoDuocService.List = (res as any[]);          
          this.DM_KhoDuocService.DataSource = new MatTableDataSource(this.DM_KhoDuocService.List);
          this.DM_KhoDuocService.DataSource.sort = this.DM_KhoDuocSort;
          this.DM_KhoDuocService.DataSource.paginator = this.DM_KhoDuocPaginator;
        },
        err => {
        },
        () => {
          this.DM_KhoDuocService.IsShowLoading = false;
        }
      );
    }
  }
  DM_KhoDuocSave(element: DM_KhoDuoc) {
    this.DM_KhoDuocService.FormData = element;
    this.NotificationService.warn(this.DM_KhoDuocService.ComponentSaveAll(this.DM_KhoDuocSort, this.DM_KhoDuocPaginator));
  }
  DM_KhoDuocDelete(element: DM_KhoDuoc) {
    this.DM_KhoDuocService.FormData = element;
    this.NotificationService.warn(this.DM_KhoDuocService.ComponentDeleteAll(this.DM_KhoDuocSort, this.DM_KhoDuocPaginator));
  }
}