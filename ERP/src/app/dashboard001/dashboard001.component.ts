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

import { DuAn } from 'src/app/shared/DuAn.model';
import { DuAnService } from 'src/app/shared/DuAn.service';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { DuAnQuyetDinhService } from 'src/app/shared/DuAnQuyetDinh.service';
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { DuAnThuChiService } from 'src/app/shared/DuAnThuChi.service';

@Component({
  selector: 'app-dashboard001',
  templateUrl: './dashboard001.component.html',
  styleUrls: ['./dashboard001.component.css']
})
export class Dashboard001Component implements OnInit {

  @ViewChild('DuAnSort') DuAnSort: MatSort;
  @ViewChild('DuAnPaginator') DuAnPaginator: MatPaginator;

  @ViewChild('DuAnQuyetDinhSort') DuAnQuyetDinhSort: MatSort;
  @ViewChild('DuAnQuyetDinhPaginator') DuAnQuyetDinhPaginator: MatPaginator;

  @ViewChild('DuAnThuChiSort') DuAnThuChiSort: MatSort;
  @ViewChild('DuAnThuChiPaginator') DuAnThuChiPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ReportService: ReportService,
    public DuAnService: DuAnService,
    public DuAnQuyetDinhService: DuAnQuyetDinhService,
    public DuAnThuChiService: DuAnThuChiService,
  ) { }

  ngOnInit(): void {
    this.Search();    
  }
  interval;
  StartTimer() {
    this.interval = setInterval(() => {
      this.Search();
    }, 30000)
  }
  Search(){
    this.Report0004();
    this.Report0005();
    this.DuAnSearch();
    this.DuAnQuyetDinhSearch();    
    this.DuAnThuChiSearch();
  }

  public Report0005_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'right'
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return value + '';
        }
      }
    }
  };
  public Report0005_0001_Color: Color[] = [
  ]
  public Report0005_0001_Label: Label[] = [];
  public Report0005_0001_Type: ChartType = 'line';
  public Report0005_0001_Legend = true;
  public Report0005_0001_Plugin = [];

  public Report0005_0001_Data: ChartDataSets[] = [
  ];

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
  Report0005() {
    this.ReportService.IsShowLoading = true;    
    this.ReportService.Report0005ToListAsync().subscribe(
      res => {
        this.ReportService.List0005 = (res as Report[]);
        let LabelArray001 = [];     
        let NameArray001 = [];               
        for (let i = 0; i < this.ReportService.List0005.length; i++) {          
          let Code = LabelArray001.filter(item => item == this.ReportService.List0005[i].Code);
          if (Code) {
            if (Code.length == 0) {
              LabelArray001.push(this.ReportService.List0005[i].Code);
            }
          } 
          let NameArraySub = NameArray001.filter(item => item == this.ReportService.List0005[i].Name);
          if (NameArraySub) {
            if (NameArraySub.length == 0) {
              let Name = this.ReportService.List0005[i].Name;
              NameArray001.push(Name);
              let DataArray = this.ReportService.List0005.filter(item => item.Name == Name); 
              let GhiNo = []; 
              for (let j = 0; j < DataArray.length; j++) {                
                GhiNo.push(DataArray[j].GhiNo);
              }            
              let Data: any = {
                type: "line",
                fill: false,
                data: GhiNo,
                label: Name,
                borderColor: this.DownloadService.GetRandomColor(GhiNo.length)
              }
              this.Report0005_0001_Data.push(Data);
            }
          }       
        }
        this.Report0005_0001_Label = LabelArray001;
        this.Report0005_0001_Data.splice(0, 1)                
      },
      err => {
      },
      () => {
        this.DuAnService.IsShowLoading = false;
      }
    );
  }

  DuAnSearch() {    
    this.ReportService.IsShowLoading = true;
    this.DuAnService.GetSQLByThanhVienIDToListAsync().subscribe(
      res => {
        this.DuAnService.List = (res as DuAn[]);
        this.DuAnService.DataSource = new MatTableDataSource(this.DuAnService.List);
        this.DuAnService.DataSource.sort = this.DuAnSort;
        this.DuAnService.DataSource.paginator = this.DuAnPaginator;
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  } 
  DuAnQuyetDinhSearch() {    
    this.ReportService.IsShowLoading = true;
    this.DuAnQuyetDinhService.GetSQLByThanhVienIDToListAsync().subscribe(
      res => {
        this.DuAnQuyetDinhService.List = (res as DuAnQuyetDinh[]);
        this.DuAnQuyetDinhService.DataSource = new MatTableDataSource(this.DuAnQuyetDinhService.List);
        this.DuAnQuyetDinhService.DataSource.sort = this.DuAnQuyetDinhSort;
        this.DuAnQuyetDinhService.DataSource.paginator = this.DuAnQuyetDinhPaginator;
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  } 
  DuAnThuChiSearch() {    
    this.ReportService.IsShowLoading = true;
    this.DuAnThuChiService.GetSQLByThanhVienIDToListAsync().subscribe(
      res => {
        this.DuAnThuChiService.List = (res as DuAnThuChi[]);
        this.DuAnThuChiService.DataSource = new MatTableDataSource(this.DuAnThuChiService.List);
        this.DuAnThuChiService.DataSource.sort = this.DuAnThuChiSort;
        this.DuAnThuChiService.DataSource.paginator = this.DuAnThuChiPaginator;
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  } 
}
