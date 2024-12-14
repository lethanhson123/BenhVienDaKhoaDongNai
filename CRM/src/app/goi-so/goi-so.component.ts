import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

@Component({
  selector: 'app-goi-so',
  templateUrl: './goi-so.component.html',
  styleUrls: ['./goi-so.component.css']
})
export class GoiSoComponent implements OnInit {

  @ViewChild('GoiSoSort') GoiSoSort: MatSort;
  @ViewChild('GoiSoPaginator') GoiSoPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public GoiSoService: GoiSoService,

  ) { }

  ngOnInit(): void {
    this.GoiSoSearch();
  }
  DateKetThuc(value) {
    this.GoiSoService.BaseParameter.KetThuc = new Date(value);
  }
  GoiSoSearch() {
    this.GoiSoService.IsShowLoading = true;    
    this.GoiSoService.GetByNgayGhiNhanToListAsync().subscribe(
      res => {
        this.GoiSoService.List = (res as GoiSo[]);
        this.GoiSoService.DataSource = new MatTableDataSource(this.GoiSoService.List);
        this.GoiSoService.DataSource.sort = this.GoiSoSort;
        this.GoiSoService.DataSource.paginator = this.GoiSoPaginator;
      },
      err => {
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
  GoiSoSave(element: GoiSo) {
    this.GoiSoService.IsShowLoading = true;
    this.GoiSoService.FormData = element;
    this.GoiSoService.SaveAsync().subscribe(
      res => {
        this.GoiSoService.FormData = res as GoiSo;
        this.GoiSoSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.GoiSoService.IsShowLoading = false;
      }
    );
  }
}