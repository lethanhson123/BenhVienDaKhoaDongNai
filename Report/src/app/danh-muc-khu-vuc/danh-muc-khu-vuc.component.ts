import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucKhuVuc } from 'src/app/shared/DanhMucKhuVuc.model';
import { DanhMucKhuVucService } from 'src/app/shared/DanhMucKhuVuc.service';

@Component({
  selector: 'app-danh-muc-khu-vuc',
  templateUrl: './danh-muc-khu-vuc.component.html',
  styleUrls: ['./danh-muc-khu-vuc.component.css']
})
export class DanhMucKhuVucComponent implements OnInit {

  @ViewChild('DanhMucKhuVucSort') DanhMucKhuVucSort: MatSort;
  @ViewChild('DanhMucKhuVucPaginator') DanhMucKhuVucPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucKhuVucService: DanhMucKhuVucService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.DanhMucKhuVucSearch();
  }
  DanhMucKhuVucSearch() {
    this.DanhMucKhuVucService.SearchAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator);
  }
  DanhMucKhuVucSave(element: DanhMucKhuVuc) {
    this.DanhMucKhuVucService.FormData = element;
    this.NotificationService.warn(this.DanhMucKhuVucService.ComponentSaveAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator));
  }
  DanhMucKhuVucDelete(element: DanhMucKhuVuc) {
    this.DanhMucKhuVucService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucKhuVucService.ComponentDeleteAll(this.DanhMucKhuVucSort, this.DanhMucKhuVucPaginator));
  }
  DanhMucKhuVucKhoiPhuc() {
    this.DanhMucKhuVucService.IsShowLoading = true;
    this.DanhMucKhuVucService.KhoiPhucAsync().subscribe(
      res => {
        this.DanhMucKhuVucService.List = (res as DanhMucKhuVuc[]);
        this.DanhMucKhuVucService.DataSource = new MatTableDataSource(this.DanhMucKhuVucService.List);
        this.DanhMucKhuVucService.DataSource.sort = this.DanhMucKhuVucSort;
        this.DanhMucKhuVucService.DataSource.paginator = this.DanhMucKhuVucPaginator;
      },
      err => {
      },
      () => {
        this.DanhMucKhuVucService.IsShowLoading = false;
      }
    );
  }
  DanhMucKhuVucSaveList() {
    this.DanhMucKhuVucService.IsShowLoading = true;
    this.DanhMucKhuVucService.ListFilter = this.DanhMucKhuVucService.List.filter(item => item.ID > 0);    
    this.DanhMucKhuVucService.SaveListAsync(this.DanhMucKhuVucService.ListFilter).subscribe(
      res => {
        this.DanhMucKhuVucSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucKhuVucService.IsShowLoading = false;
      }
    );
  }
}