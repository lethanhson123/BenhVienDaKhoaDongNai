import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

@Component({
  selector: 'app-thanh-vien001',
  templateUrl: './thanh-vien001.component.html',
  styleUrls: ['./thanh-vien001.component.css']
})
export class ThanhVien001Component implements OnInit {

  @ViewChild('ThanhVienSort') ThanhVienSort: MatSort;
  @ViewChild('ThanhVienPaginator') ThanhVienPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThanhVienService: ThanhVienService,
  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.ThanhVienSearch();
  }
  ThanhVienSearch() {
    this.ThanhVienService.SearchAllNotEmpty(this.ThanhVienSort, this.ThanhVienPaginator);
  }
  ThanhVienDelete(element: ThanhVien) {
    this.ThanhVienService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ThanhVienService.ComponentDeleteAllNotEmpty(this.ThanhVienSort, this.ThanhVienPaginator));
  }

}