import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';

@Component({
  selector: 'app-danh-muc-xa-phuong',
  templateUrl: './danh-muc-xa-phuong.component.html',
  styleUrls: ['./danh-muc-xa-phuong.component.css']
})
export class DanhMucXaPhuongComponent implements OnInit {

  @ViewChild('DanhMucXaPhuongSort') DanhMucXaPhuongSort: MatSort;
  @ViewChild('DanhMucXaPhuongPaginator') DanhMucXaPhuongPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucXaPhuongService: DanhMucXaPhuongService,
  ) { }

  ngOnInit(): void { 
    //this.DanhMucXaPhuongSearch();
  }

  DanhMucXaPhuongSearch() {
    this.DanhMucXaPhuongService.SearchAll(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator);   
  }
  DanhMucXaPhuongSave(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.FormData = element;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentSaveAll(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator));
  }
  DanhMucXaPhuongDelete(element: DanhMucXaPhuong) {
    this.DanhMucXaPhuongService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucXaPhuongService.ComponentDeleteAll(this.DanhMucXaPhuongSort, this.DanhMucXaPhuongPaginator));
  }  
}