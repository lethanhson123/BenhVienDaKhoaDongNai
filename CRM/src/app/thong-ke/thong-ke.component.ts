import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { ThongKe } from 'src/app/shared/ThongKe.model';
import { ThongKeService } from 'src/app/shared/ThongKe.service';

@Component({
  selector: 'app-thong-ke',
  templateUrl: './thong-ke.component.html',
  styleUrls: ['./thong-ke.component.css']
})
export class ThongKeComponent implements OnInit {

  @ViewChild('ThongKeSort') ThongKeSort: MatSort;
  @ViewChild('ThongKePaginator') ThongKePaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeService: ThongKeService,
  ) { }

  ngOnInit(): void {
    this.ThongKeSearch();
  }

  ThongKeSearch() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.GetAllToListAsync().subscribe(
      res => {
        this.ThongKeService.List = (res as any[]).sort((a, b) => (a.BatDau < b.BatDau ? 1 : -1));
        this.ThongKeService.ListFilter = this.ThongKeService.List.filter(item => item.ID > 0);
        this.ThongKeService.DataSource = new MatTableDataSource(this.ThongKeService.List);
        this.ThongKeService.DataSource.sort = this.ThongKeSort;
        this.ThongKeService.DataSource.paginator = this.ThongKePaginator;
      },
      err => {
      },
      () => {
        this.ThongKeService.IsShowLoading = false; 
      }
    );
  }
  ThongKeSave(element: ThongKe) {
    this.ThongKeService.FormData = element;
    this.NotificationService.warn(this.ThongKeService.ComponentSaveAll(this.ThongKeSort, this.ThongKePaginator));
  }
  ThongKeDelete(element: ThongKe) {
    if (confirm(environment.DeleteConfirm)) {
      this.ThongKeService.IsShowLoading = true;
      this.ThongKeService.BaseParameter.ID = element.ID;
      this.ThongKeService.RemoveAsync().subscribe(
        res => {
          this.ThongKeSearch();
          this.NotificationService.warn(environment.DeleteSuccess);
        },
        err => {
          this.NotificationService.warn(environment.DeleteNotSuccess);
        },
        () => {
          this.ThongKeService.IsShowLoading = false;
        }
      );
    }
  }
}