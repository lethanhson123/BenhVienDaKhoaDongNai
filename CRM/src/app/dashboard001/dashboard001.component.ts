import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { ChartOptions, ChartType, ChartDataSets, Chart, ChartConfiguration, ChartData } from 'chart.js';
import { Color, Label, SingleDataSet, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { Report } from 'src/app/shared/Report.model';
import { ReportService } from 'src/app/shared/Report.service';

@Component({
  selector: 'app-dashboard001',
  templateUrl: './dashboard001.component.html',
  styleUrls: ['./dashboard001.component.css']
})
export class Dashboard001Component implements OnInit {

  constructor(
    public ReportService: ReportService,
  ) { }

  ngOnInit(): void {
    this.Report0004();
  }
  Report0004() {
    this.ReportService.IsShowLoading = true;    
    this.ReportService.Report0004ToAsync().subscribe(
      res => {
        this.ReportService.FormData = (res as Report);
        
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  }
}
