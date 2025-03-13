import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ManHinhThongBao } from 'src/app/shared/ManHinhThongBao.model';
import { ManHinhThongBaoService } from 'src/app/shared/ManHinhThongBao.service';

@Component({
  selector: 'app-man-hinh-thong-bao',
  templateUrl: './man-hinh-thong-bao.component.html',
  styleUrls: ['./man-hinh-thong-bao.component.css']
})
export class ManHinhThongBaoComponent implements OnInit {

  @ViewChild('ManHinhThongBaoSort') ManHinhThongBaoSort: MatSort;
  @ViewChild('ManHinhThongBaoPaginator') ManHinhThongBaoPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ManHinhThongBaoService: ManHinhThongBaoService,
  ) { }

  ngOnInit(): void { 
   
  }
  ngAfterViewInit() {
    this.ManHinhThongBaoSearch();
  }
  ManHinhThongBaoSearch() {
    this.ManHinhThongBaoService.SearchAll(this.ManHinhThongBaoSort, this.ManHinhThongBaoPaginator);
  }
  ManHinhThongBaoSave(element: ManHinhThongBao) {
    this.ManHinhThongBaoService.FormData = element;
    this.NotificationService.warn(this.ManHinhThongBaoService.ComponentSaveAll(this.ManHinhThongBaoSort, this.ManHinhThongBaoPaginator));
  }
  ManHinhThongBaoDelete(element: ManHinhThongBao) {
    this.ManHinhThongBaoService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ManHinhThongBaoService.ComponentDeleteAll(this.ManHinhThongBaoSort, this.ManHinhThongBaoPaginator));
  }  
}