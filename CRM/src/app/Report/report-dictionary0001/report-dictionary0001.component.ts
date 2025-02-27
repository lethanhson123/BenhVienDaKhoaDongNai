import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { Report } from 'src/app/shared/APIReport/Report.model';
import { ReportService } from 'src/app/shared/APIReport/Report.service';


@Component({
  selector: 'app-report-dictionary0001',
  templateUrl: './report-dictionary0001.component.html',
  styleUrls: ['./report-dictionary0001.component.css']
})
export class ReportDictionary0001Component implements OnInit {

  @ViewChild('ReportSort') ReportSort: MatSort;
  @ViewChild('ReportPaginator') ReportPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ReportService: ReportService,
  ) { }

  ngOnInit(): void {
  }

  ReportDictionary0001Search() {
    if (this.ReportService.BaseParameter.SearchString.length > 0) {
      this.ReportService.BaseParameter.SearchString = this.ReportService.BaseParameter.SearchString.trim();
      if (this.ReportService.DataSource) {
        this.ReportService.DataSource.filter = this.ReportService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.ReportService.IsShowLoading = true;
      this.ReportService.ReportDictionary0003ToListAsync().subscribe(
        res => {
          this.ReportService.List = (res as Report[]);
          this.ReportService.DataSource = new MatTableDataSource(this.ReportService.List);
          this.ReportService.DataSource.sort = this.ReportSort;
          this.ReportService.DataSource.paginator = this.ReportPaginator;
        },
        err => {
        },
        () => {
          this.ReportService.IsShowLoading = false;
        }
      );
    }
  }
}
