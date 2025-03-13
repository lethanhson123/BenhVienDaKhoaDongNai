import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucMauSac } from 'src/app/shared/DanhMucMauSac.model';
import { DanhMucMauSacService } from 'src/app/shared/DanhMucMauSac.service';

@Component({
  selector: 'app-danh-muc-mau-sac',
  templateUrl: './danh-muc-mau-sac.component.html',
  styleUrls: ['./danh-muc-mau-sac.component.css']
})
export class DanhMucMauSacComponent implements OnInit {

  @ViewChild('DanhMucMauSacSort') DanhMucMauSacSort: MatSort;
  @ViewChild('DanhMucMauSacPaginator') DanhMucMauSacPaginator: MatPaginator;

  constructor(    
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucMauSacService: DanhMucMauSacService,
  ) { }

  ngOnInit(): void { 
    
  }
  ngAfterViewInit() {
    this.DanhMucMauSacSearch();
  }
  DanhMucMauSacSearch() {
    this.DanhMucMauSacService.SearchAll(this.DanhMucMauSacSort, this.DanhMucMauSacPaginator);
  }
  DanhMucMauSacSave(element: DanhMucMauSac) {
    this.DanhMucMauSacService.FormData = element;
    this.NotificationService.warn(this.DanhMucMauSacService.ComponentSaveAll(this.DanhMucMauSacSort, this.DanhMucMauSacPaginator));
  }
  DanhMucMauSacDelete(element: DanhMucMauSac) {
    this.DanhMucMauSacService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucMauSacService.ComponentDeleteAll(this.DanhMucMauSacSort, this.DanhMucMauSacPaginator));
  }  
  DanhMucMauSacSaveList() {
    this.DanhMucMauSacService.IsShowLoading = true;
    this.DanhMucMauSacService.ListFilter = this.DanhMucMauSacService.List.filter(item => item.ID > 0);    
    this.DanhMucMauSacService.SaveListAsync(this.DanhMucMauSacService.ListFilter).subscribe(
      res => {
        this.DanhMucMauSacSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DanhMucMauSacService.IsShowLoading = false;
      }
    );
  }
}