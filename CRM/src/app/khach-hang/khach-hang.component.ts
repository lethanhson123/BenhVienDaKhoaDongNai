import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhachHang } from 'src/app/shared/KhachHang.model';
import { KhachHangService } from 'src/app/shared/KhachHang.service';

@Component({
  selector: 'app-khach-hang',
  templateUrl: './khach-hang.component.html',
  styleUrls: ['./khach-hang.component.css']
})
export class KhachHangComponent implements OnInit {

  @ViewChild('KhachHangSort') KhachHangSort: MatSort;
  @ViewChild('KhachHangPaginator') KhachHangPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhachHangService: KhachHangService,
  ) { }

  ngOnInit(): void { 
    this.KhachHangSearch();
  }

  KhachHangSearch() {
    this.KhachHangService.SearchAllNotEmpty(this.KhachHangSort, this.KhachHangPaginator);
  }
  KhachHangSave(element: KhachHang) {
    this.KhachHangService.FormData = element;
    this.NotificationService.warn(this.KhachHangService.ComponentSaveAll(this.KhachHangSort, this.KhachHangPaginator));
  }
  KhachHangDelete(element: KhachHang) {
    this.KhachHangService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.KhachHangService.ComponentDeleteAllNotEmpty(this.KhachHangSort, this.KhachHangPaginator));
  }  
}