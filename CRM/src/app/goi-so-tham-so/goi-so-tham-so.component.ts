import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { GoiSoThamSo } from 'src/app/shared/GoiSoThamSo.model';
import { GoiSoThamSoService } from 'src/app/shared/GoiSoThamSo.service';

@Component({
  selector: 'app-goi-so-tham-so',
  templateUrl: './goi-so-tham-so.component.html',
  styleUrls: ['./goi-so-tham-so.component.css']
})
export class GoiSoThamSoComponent {
  
  @ViewChild('GoiSoThamSoSort') GoiSoThamSoSort: MatSort;
  @ViewChild('GoiSoThamSoPaginator') GoiSoThamSoPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public GoiSoThamSoService: GoiSoThamSoService,
  ) { }

  ngOnInit(): void { 
    this.GoiSoThamSoSearch();
  }

  GoiSoThamSoSearch() {
    this.GoiSoThamSoService.SearchAll(this.GoiSoThamSoSort, this.GoiSoThamSoPaginator);
  }
  GoiSoThamSoSave(element: GoiSoThamSo) {
    this.GoiSoThamSoService.FormData = element;
    this.NotificationService.warn(this.GoiSoThamSoService.ComponentSaveAll(this.GoiSoThamSoSort, this.GoiSoThamSoPaginator));
  }
  GoiSoThamSoDelete(element: GoiSoThamSo) {
    this.GoiSoThamSoService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.GoiSoThamSoService.ComponentDeleteAll(this.GoiSoThamSoSort, this.GoiSoThamSoPaginator));
  }  
}
