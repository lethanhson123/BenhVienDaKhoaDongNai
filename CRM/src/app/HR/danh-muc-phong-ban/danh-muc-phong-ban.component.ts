import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { DanhMucPhongBanService } from 'src/app/shared/DanhMucPhongBan.service';

@Component({
  selector: 'app-danh-muc-phong-ban',
  templateUrl: './danh-muc-phong-ban.component.html',
  styleUrls: ['./danh-muc-phong-ban.component.css']
})
export class DanhMucPhongBanComponent implements OnInit {

  @ViewChild('DanhMucPhongBanSort') DanhMucPhongBanSort: MatSort;
  @ViewChild('DanhMucPhongBanPaginator') DanhMucPhongBanPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucPhongBanService: DanhMucPhongBanService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.DanhMucPhongBanSearch();
  }
  DanhMucPhongBanSearch() {
    this.DanhMucPhongBanService.SearchAll(this.DanhMucPhongBanSort, this.DanhMucPhongBanPaginator);
  }
  DanhMucPhongBanSave(element: DanhMucPhongBan) {
    this.DanhMucPhongBanService.FormData = element;
    this.NotificationService.warn(this.DanhMucPhongBanService.ComponentSaveAll(this.DanhMucPhongBanSort, this.DanhMucPhongBanPaginator));
  }
  DanhMucPhongBanDelete(element: DanhMucPhongBan) {
    this.DanhMucPhongBanService.FormData = element;
    this.NotificationService.warn(this.DanhMucPhongBanService.ComponentDeleteAll(this.DanhMucPhongBanSort, this.DanhMucPhongBanPaginator));
  }
}