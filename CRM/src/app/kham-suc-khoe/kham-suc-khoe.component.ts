import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { KhamSucKhoe } from 'src/app/shared/KhamSucKhoe.model';
import { KhamSucKhoeService } from 'src/app/shared/KhamSucKhoe.service';

@Component({
  selector: 'app-kham-suc-khoe',
  templateUrl: './kham-suc-khoe.component.html',
  styleUrls: ['./kham-suc-khoe.component.css']
})
export class KhamSucKhoeComponent implements OnInit {

  @ViewChild('KhamSucKhoeSort') KhamSucKhoeSort: MatSort;
  @ViewChild('KhamSucKhoePaginator') KhamSucKhoePaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public KhamSucKhoeService: KhamSucKhoeService,
  ) { }

  ngOnInit(): void { 
    
  }
  ngAfterViewInit() {
    this.KhamSucKhoeSearch();
  }
  KhamSucKhoeSearch() {
    this.KhamSucKhoeService.SearchAllNotEmpty(this.KhamSucKhoeSort, this.KhamSucKhoePaginator);
  }
  KhamSucKhoeSave(element: KhamSucKhoe) {
    this.KhamSucKhoeService.FormData = element;
    this.NotificationService.warn(this.KhamSucKhoeService.ComponentSaveAll(this.KhamSucKhoeSort, this.KhamSucKhoePaginator));
  }
  KhamSucKhoeDelete(element: KhamSucKhoe) {
    this.KhamSucKhoeService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.KhamSucKhoeService.ComponentDeleteAllNotEmpty(this.KhamSucKhoeSort, this.KhamSucKhoePaginator));
  }  
}