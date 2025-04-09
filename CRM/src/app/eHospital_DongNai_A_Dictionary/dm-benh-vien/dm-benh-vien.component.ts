import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_BenhVien } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.model';
import { DM_BenhVienService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhVien.service';

@Component({
  selector: 'app-dm-benh-vien',
  templateUrl: './dm-benh-vien.component.html',
  styleUrls: ['./dm-benh-vien.component.css']
})
export class DMBenhVienComponent implements OnInit {

  @ViewChild('DM_BenhVienSort') DM_BenhVienSort: MatSort;
  @ViewChild('DM_BenhVienPaginator') DM_BenhVienPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_BenhVienService: DM_BenhVienService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DM_BenhVienSearch();
  }
  DM_BenhVien001() {
    this.DM_BenhVienService.DisplayColumns004 = this.DM_BenhVienService.DisplayColumns001;
  }
  DM_BenhVien002() {
    this.DM_BenhVienService.DisplayColumns004 = this.DM_BenhVienService.DisplayColumns002;
  }
  DM_BenhVienSearch() {
    this.DM_BenhVienService.SearchBySearchStringAndEmptyToListAsync(this.DM_BenhVienSort, this.DM_BenhVienPaginator);
  }
  DM_BenhVienSave(element: DM_BenhVien) {
    this.DM_BenhVienService.FormData = element;
    this.NotificationService.warn(this.DM_BenhVienService.ComponentSaveSearchString(this.DM_BenhVienSort, this.DM_BenhVienPaginator));
  }
  DM_BenhVienDelete(element: DM_BenhVien) {
    this.DM_BenhVienService.FormData = element;
    this.NotificationService.warn(this.DM_BenhVienService.ComponentDeleteSearchString(this.DM_BenhVienSort, this.DM_BenhVienPaginator));
  }
}