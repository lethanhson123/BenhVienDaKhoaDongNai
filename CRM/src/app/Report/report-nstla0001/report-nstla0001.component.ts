import { Component, OnInit, ViewChild, ElementRef, AfterViewInit, OnDestroy } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets, Chart, ChartConfiguration, ChartData } from 'chart.js';
import { Color, Label, SingleDataSet, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';
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
  selector: 'app-report-nstla0001',
  templateUrl: './report-nstla0001.component.html',
  styleUrls: ['./report-nstla0001.component.css']
})
export class ReportNSTLA0001Component implements OnInit {

  Image = new Image();

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ReportService: ReportService,
  ) { }

  ngOnInit(): void {
    this.Image.src = environment.Logo100_26;
    this.ReportSearch();
  }
  ReportSearch() {
    this.ReportNSTLA0001Search();
  }
  ReportNSTLA0001Filter(TinhThanhName: string) {    
    this.ReportService.ListFilter = this.ReportService.List.filter(item => item.TinhThanhName == TinhThanhName);
    console.log(this.ReportService.ListFilter);
  }
  ReportNSTLA0001Search() {
    this.ReportService.IsShowLoading = true;
    this.ReportService.ReportNSTLA0001ToListAsync().subscribe(
      res => {
        this.ReportService.ListReportA = (res as Report[]);

        this.ReportService.List1000 = this.ReportService.ListReportA.filter(item => item.ID == 1000);
        this.ReportService.List10 = this.ReportService.ListReportA.filter(item => item.ID == 10);
        this.ReportService.List20 = this.ReportService.ListReportA.filter(item => item.ID == 20);
        this.ReportService.List50 = this.ReportService.ListReportA.filter(item => item.ID == 50);
        this.ReportService.List100 = this.ReportService.ListReportA.filter(item => item.ID == 100);
        this.ReportService.List200 = this.ReportService.ListReportA.filter(item => item.ID == 200);
        this.ReportService.List = this.ReportService.ListReportA.filter(item => item.ID < 10);
        this.ReportService.List = this.ReportService.List.sort((a, b) => (a.Code > b.Code ? 1 : -1));

        if (this.ReportService.List1000) {
          if (this.ReportService.List1000.length > 0) {
            this.ReportService.FormData.ThongKe001 = this.ReportService.List1000[0].ThongKe001;
          }
        }


        this.ReportService.List10 = this.ReportService.List10.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));
        this.ReportService.FormData.ThongKe002 = environment.InitializationNumber;
        let LabelArray10 = [];
        let DataArray10 = [];
        for (let i = 0; i < this.ReportService.List10.length; i++) {
          this.ReportService.FormData.ThongKe002 = this.ReportService.FormData.ThongKe002 + this.ReportService.List10[i].ThongKe001;
          let Report = this.ReportService.List10[i];
          LabelArray10.push(Report.Code);
          DataArray10.push(Report.ThongKe001);
        }
        this.Report0001_0001_Label = LabelArray10;
        let Label010: string = 'Bác sĩ';
        this.Report0001_0001_Data = [
          { data: DataArray10, label: Label010, stack: 'b', yAxisID: 'B', }
        ];


        this.ReportService.List20 = this.ReportService.List20.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));
        this.ReportService.FormData.ThongKe003 = environment.InitializationNumber;
        let LabelArray20 = [];
        let DataArray20 = [];
        for (let i = 0; i < this.ReportService.List20.length; i++) {
          this.ReportService.FormData.ThongKe003 = this.ReportService.FormData.ThongKe003 + this.ReportService.List20[i].ThongKe001;
          let Report = this.ReportService.List20[i];
          LabelArray20.push(Report.Code);
          DataArray20.push(Report.ThongKe001);
        }
        this.Report0001_0002_Label = LabelArray20;
        let Label020: string = 'Điều dưỡng';
        this.Report0001_0002_Data = [
          { data: DataArray20, label: Label020, stack: 'b', yAxisID: 'B', }
        ];

        this.ReportService.List50 = this.ReportService.List50.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));
        this.ReportService.FormData.ThongKe004 = environment.InitializationNumber;
        let LabelArray50 = [];
        let DataArray50 = [];
        for (let i = 0; i < this.ReportService.List50.length; i++) {
          this.ReportService.FormData.ThongKe004 = this.ReportService.FormData.ThongKe004 + this.ReportService.List50[i].ThongKe001;
          let Report = this.ReportService.List50[i];
          LabelArray50.push(Report.Code);
          DataArray50.push(Report.ThongKe001);
        }
        this.Report0001_0005_Label = LabelArray50;
        let Label050: string = 'Dược sĩ';
        this.Report0001_0005_Data = [
          { data: DataArray50, label: Label050, stack: 'b', yAxisID: 'B', }
        ];

        this.ReportService.List100 = this.ReportService.List100.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));
        let LabelArray01 = [];
        let DataArray01 = [];
        for (let i = 0; i < this.ReportService.List100.length; i++) {
          let Report = this.ReportService.List100[i];
          LabelArray01.push(Report.Code);
          DataArray01.push(Report.ThongKe001);
        }
        this.Report0002_0001_Label = LabelArray01;
        let Label001: string = 'Khoa phòng';
        this.Report0002_0001_Data = [
          { data: DataArray01, label: Label001, stack: 'a', }
        ];

        this.ReportService.List200 = this.ReportService.List200.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));
        let LabelArray02 = [];
        let DataArray02 = [];
        for (let i = 0; i < this.ReportService.List200.length; i++) {
          let Report = this.ReportService.List200[i];
          LabelArray02.push(Report.Name);
          DataArray02.push(Report.ThongKe001);
        }
        this.Report0002_0002_Label = LabelArray02;
        let Label002: string = 'Chức danh';
        this.Report0002_0002_Data = [
          { data: DataArray02, label: Label002, stack: 'a', }
        ];
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  }


  public Report0001_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    animation: {
      duration: 1,
      onComplete: function () {
        var chartInstance = this.chart,
          ctx = chartInstance.ctx;
        ctx.textAlign = 'center';
        ctx.fillStyle = "rgba(0, 0, 0, 1)";
        ctx.textBaseline = 'bottom';
        this.data.datasets.forEach(function (dataset, i) {
          var meta = chartInstance.controller.getDatasetMeta(i);
          meta.data.forEach(function (bar, index) {
            var data = dataset.data[index];
            ctx.fillText(data, bar._model.x, bar._model.y - 5);

          });
        });
      }
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          return Number(tooltipItem.yLabel).toFixed(0).replace(/./g, function (c, i, a) {
            return i > 0 && c !== "." && (a.length - i) % 3 === 0 ? "." + c : c;
          });
        }
      }
    },
    scales: {
      yAxes: [
        {
          id: 'B',
          position: 'right',
        }
      ]
    },
  };
  public Report0001_0001_Color: Color[] = [
  ]
  public Report0001_0001_Label: Label[] = [];
  public Report0001_0001_Type: ChartType = 'bar';
  public Report0001_0001_Legend = true;


  public Report0001_0001_Plugin = [
    {
      id: 'customCanvasBackgroundImage',
      beforeDraw: (chart) => {
        if (this.Image.complete) {
          const ctx = chart.ctx;
          const { top, left, width, height } = chart.chartArea;
          const x = left;
          const y = top;
          ctx.drawImage(this.Image, x, y, this.Image.width, this.Image.height);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0001_Data: ChartDataSets[] = [
  ];

  public Report0001_0002_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    animation: {
      duration: 1,
      onComplete: function () {
        var chartInstance = this.chart,
          ctx = chartInstance.ctx;
        ctx.textAlign = 'center';
        ctx.fillStyle = "rgba(0, 0, 0, 1)";
        ctx.textBaseline = 'bottom';
        this.data.datasets.forEach(function (dataset, i) {
          var meta = chartInstance.controller.getDatasetMeta(i);
          meta.data.forEach(function (bar, index) {
            var data = dataset.data[index];
            ctx.fillText(data, bar._model.x, bar._model.y - 5);

          });
        });
      }
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          return Number(tooltipItem.yLabel).toFixed(0).replace(/./g, function (c, i, a) {
            return i > 0 && c !== "." && (a.length - i) % 3 === 0 ? "." + c : c;
          });
        }
      }
    },
    scales: {
      yAxes: [
        {
          id: 'B',
          position: 'right',
        }
      ]
    },
  };
  public Report0001_0002_Color: Color[] = [
  ]
  public Report0001_0002_Label: Label[] = [];
  public Report0001_0002_Type: ChartType = 'bar';
  public Report0001_0002_Legend = true;


  public Report0001_0002_Plugin = [
    {
      id: 'customCanvasBackgroundImage',
      beforeDraw: (chart) => {
        if (this.Image.complete) {
          const ctx = chart.ctx;
          const { top, left, width, height } = chart.chartArea;
          const x = left;
          const y = top;
          ctx.drawImage(this.Image, x, y, this.Image.width, this.Image.height);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0002_Data: ChartDataSets[] = [
  ];

  public Report0001_0005_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    animation: {
      duration: 1,
      onComplete: function () {
        var chartInstance = this.chart,
          ctx = chartInstance.ctx;
        ctx.textAlign = 'center';
        ctx.fillStyle = "rgba(0, 0, 0, 1)";
        ctx.textBaseline = 'bottom';
        this.data.datasets.forEach(function (dataset, i) {
          var meta = chartInstance.controller.getDatasetMeta(i);
          meta.data.forEach(function (bar, index) {
            var data = dataset.data[index];
            ctx.fillText(data, bar._model.x, bar._model.y - 5);

          });
        });
      }
    },
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          return Number(tooltipItem.yLabel).toFixed(0).replace(/./g, function (c, i, a) {
            return i > 0 && c !== "." && (a.length - i) % 3 === 0 ? "." + c : c;
          });
        }
      }
    },
    scales: {
      yAxes: [
        {
          id: 'B',
          position: 'right',
        }
      ]
    },
  };
  public Report0001_0005_Color: Color[] = [
  ]
  public Report0001_0005_Label: Label[] = [];
  public Report0001_0005_Type: ChartType = 'bar';
  public Report0001_0005_Legend = true;


  public Report0001_0005_Plugin = [
    {
      id: 'customCanvasBackgroundImage',
      beforeDraw: (chart) => {
        if (this.Image.complete) {
          const ctx = chart.ctx;
          const { top, left, width, height } = chart.chartArea;
          const x = left;
          const y = top;
          ctx.drawImage(this.Image, x, y, this.Image.width, this.Image.height);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0005_Data: ChartDataSets[] = [
  ];

  public Report0002_0001_Option: ChartOptions = {
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
          return label + '';
        }
      }
    }
  };
  public Report0002_0001_Color: Color[] = [
  ]
  public Report0002_0001_Label: Label[] = [];
  public Report0002_0001_Type: ChartType = 'doughnut';
  public Report0002_0001_Legend = true;
  public Report0002_0001_Plugins = [];

  public Report0002_0001_Data: ChartDataSets[] = [
  ];

  public Report0002_0002_Option: ChartOptions = {
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
          return label + '';
        }
      }
    }
  };
  public Report0002_0002_Color: Color[] = [
  ]
  public Report0002_0002_Label: Label[] = [];
  public Report0002_0002_Type: ChartType = 'pie';
  public Report0002_0002_Legend = true;
  public Report0002_0002_Plugin = [];

  public Report0002_0002_Data: ChartDataSets[] = [
  ];
}
