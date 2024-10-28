import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucBenhVien } from 'src/app/shared/DanhMucBenhVien.model';
import { DanhMucBenhVienService } from 'src/app/shared/DanhMucBenhVien.service';

@Component({
  selector: 'app-danh-muc-benh-vien',
  templateUrl: './danh-muc-benh-vien.component.html',
  styleUrls: ['./danh-muc-benh-vien.component.css']
})
export class DanhMucBenhVienComponent implements OnInit {

  @ViewChild('DanhMucBenhVienSort') DanhMucBenhVienSort: MatSort;
  @ViewChild('DanhMucBenhVienPaginator') DanhMucBenhVienPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucBenhVienService: DanhMucBenhVienService,
  ) { }

  ngOnInit(): void { 
    this.DanhMucBenhVienSearch();
  }

  DanhMucBenhVienSearch() {
    this.DanhMucBenhVienService.SearchAll(this.DanhMucBenhVienSort, this.DanhMucBenhVienPaginator);
  }
  DanhMucBenhVienSave(element: DanhMucBenhVien) {
    this.DanhMucBenhVienService.FormData = element;
    this.NotificationService.warn(this.DanhMucBenhVienService.ComponentSaveAll(this.DanhMucBenhVienSort, this.DanhMucBenhVienPaginator));
  }
  DanhMucBenhVienDelete(element: DanhMucBenhVien) {
    this.DanhMucBenhVienService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucBenhVienService.ComponentDeleteAll(this.DanhMucBenhVienSort, this.DanhMucBenhVienPaginator));
  }  
}