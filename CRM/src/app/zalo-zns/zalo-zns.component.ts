import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ZaloZNS } from 'src/app/shared/ZaloZNS.model';
import { ZaloZNSService } from 'src/app/shared/ZaloZNS.service';

@Component({
  selector: 'app-zalo-zns',
  templateUrl: './zalo-zns.component.html',
  styleUrls: ['./zalo-zns.component.css']
})
export class ZaloZNSComponent implements OnInit {

  @ViewChild('ZaloZNSSort') ZaloZNSSort: MatSort;
  @ViewChild('ZaloZNSPaginator') ZaloZNSPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ZaloZNSService: ZaloZNSService,
  ) { }

  ngOnInit(): void { 
    
  }
  ngAfterViewInit() {
    this.ZaloZNSSearch();
  }
  ZaloZNSSearch() {
    this.ZaloZNSService.SearchAll(this.ZaloZNSSort, this.ZaloZNSPaginator);
  }
  ZaloZNSSave(element: ZaloZNS) {
    this.ZaloZNSService.FormData = element;
    this.NotificationService.warn(this.ZaloZNSService.ComponentSaveAll(this.ZaloZNSSort, this.ZaloZNSPaginator));
  }
  ZaloZNSDelete(element: ZaloZNS) {
    this.ZaloZNSService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ZaloZNSService.ComponentDeleteAll(this.ZaloZNSSort, this.ZaloZNSPaginator));
  }  
}