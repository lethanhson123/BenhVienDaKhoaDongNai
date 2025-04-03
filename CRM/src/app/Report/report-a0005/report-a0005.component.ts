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

import { ThongKe } from 'src/app/shared/ThongKe.model';
import { ThongKeService } from 'src/app/shared/ThongKe.service';

import { ThongKeChiTiet } from 'src/app/shared/ThongKeChiTiet.model';
import { ThongKeChiTietService } from 'src/app/shared/ThongKeChiTiet.service';

@Component({
  selector: 'app-report-a0005',
  templateUrl: './report-a0005.component.html',
  styleUrls: ['./report-a0005.component.css']
})
export class ReportA0005Component implements OnInit {

  @ViewChild('ThongKeChiTietSort') ThongKeChiTietSort: MatSort;
  @ViewChild('ThongKeChiTietPaginator') ThongKeChiTietPaginator: MatPaginator;

  Image = new Image();

  constructor(
    public Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeService: ThongKeService,
    public ThongKeChiTietService: ThongKeChiTietService,
  ) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() {
    this.Image.src = environment.Logo312_80;
    this.ThongKeService.BaseParameter.BatDau = new Date();
    this.ThongKeService.BaseParameter.ParentID = 3;
  }
  DateBatDau(value) {
    this.ThongKeService.BaseParameter.BatDau = new Date(value);
  }
  ThongKeSearch() {
    this.ThongKe001Search();
  }
  ThongKe001Search() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.GetByParentID_Year_MonthAsync().subscribe(
      res => {
        this.ThongKeService.FormData = (res as ThongKe);
        if (this.ThongKeService.FormData) {
          if (this.ThongKeService.FormData.ID > 0) {
            this.ThongKeChiTietSearch();
          }
        }
      },
      err => {
      },
      () => {
        this.ThongKeService.IsShowLoading = false;
      }
    );
  }
  ThongKeChiTietSearch() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeChiTietService.BaseParameter.ParentID = this.ThongKeService.FormData.ID;
    this.ThongKeChiTietService.GetByParentIDToListAsync().subscribe(
      res => {
        this.ThongKeChiTietService.List = (res as ThongKeChiTiet[]);

        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 100);
        this.ThongKeChiTietService.List200 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 200);
        this.ThongKeChiTietService.List300 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 300);
        this.ThongKeChiTietService.List400 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 400);

        this.ThongKeChiTietService.List01 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 12);
        this.ThongKeChiTietService.List02 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 23);
        this.ThongKeChiTietService.List03 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 34);


        this.ThongKeChiTietService.List1000 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 1000);
        this.ThongKeChiTietService.List2000 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 2000);
        this.ThongKeChiTietService.List3000 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 3000);

        this.ThongKeChiTietService.FormData1000 = this.ThongKeChiTietService.List1000[0];
        this.ThongKeChiTietService.FormData2000 = this.ThongKeChiTietService.List2000[0];
        this.ThongKeChiTietService.FormData3000 = this.ThongKeChiTietService.List3000[0];

        let ThongKe011Sum = this.ThongKeChiTietService.List1000[0].ThongKe011 + this.ThongKeChiTietService.List2000[0].ThongKe011 + this.ThongKeChiTietService.List3000[0].ThongKe011;

        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List3000[0];
        let LabelArray1 = [];
        let DataArray1 = [];
        let Label1: string = "Lượt khám " + this.ThongKeChiTietService.FormData.Year;

        LabelArray1.push("Tháng " + this.ThongKeChiTietService.FormData.Month + " (" + this.ThongKeChiTietService.FormData.ThongKe011 + " lượt khám: " + (this.ThongKeChiTietService.FormData.ThongKe011 / ThongKe011Sum * 100).toFixed(2) + "%)");
        DataArray1.push(this.ThongKeChiTietService.FormData.ThongKe011);

        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List2000[0];
        LabelArray1.push("Tháng " + this.ThongKeChiTietService.FormData.Month + " (" + this.ThongKeChiTietService.FormData.ThongKe011 + " lượt khám: " + (this.ThongKeChiTietService.FormData.ThongKe011 / ThongKe011Sum * 100).toFixed(2) + "%)");
        DataArray1.push(this.ThongKeChiTietService.FormData.ThongKe011);

        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List1000[0];
        LabelArray1.push("Tháng " + this.ThongKeChiTietService.FormData.Month + " (" + this.ThongKeChiTietService.FormData.ThongKe011 + " lượt khám: " + (this.ThongKeChiTietService.FormData.ThongKe011 / ThongKe011Sum * 100).toFixed(2) + "%)");
        DataArray1.push(this.ThongKeChiTietService.FormData.ThongKe011);

        this.Report0001_0001_Label = LabelArray1;
        this.Report0001_0001_Data = [
          { data: DataArray1, label: Label1, stack: 'a', }
        ];

        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 100);
        this.ThongKeChiTietService.List200 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 200);
        this.ThongKeChiTietService.List300 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 300);

        let LabelArray31 = [];
        let DataArray31 = [];
        let DataArray32 = [];
        let DataArray33 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List100[0];
        let Label31: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        LabelArray31.push("Lâm sàng (LS)");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe000);
        LabelArray31.push("LS và 01 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray31.push("LS và 02 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray31.push("LS và 03 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray31.push("LS và 04 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray31.push("LS và 05 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray31.push("LS và 06 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray31.push("LS và 07 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray31.push("LS và 08 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray31.push("LS và 09 CLS");
        DataArray31.push(this.ThongKeChiTietService.FormData.ThongKe009);


        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List200[0];
        let Label32: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe000);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe001);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe002);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe003);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe004);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe005);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe006);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe007);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe008);
        DataArray32.push(this.ThongKeChiTietService.FormData.ThongKe009);

        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List300[0];
        let Label33: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe000);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe001);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe002);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe003);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe004);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe005);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe006);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe007);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe008);
        DataArray33.push(this.ThongKeChiTietService.FormData.ThongKe009);

        this.Report0001_0003_Label = LabelArray31;

        this.Report0001_0003_Data = [
          { data: DataArray33, label: Label33, stack: 'c' },
          { data: DataArray32, label: Label32, stack: 'b' },
          { data: DataArray31, label: Label31, stack: 'a' },
        ];



      },
      err => {
      },
      () => {
        this.ThongKeService.IsShowLoading = false;
      }
    );
  }
  public Report0001_0001_Option: ChartOptions = {
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
  public Report0001_0001_Color: Color[] = [
  ]
  public Report0001_0001_Label: Label[] = [];
  public Report0001_0001_Type: ChartType = 'doughnut';
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
  ];

  public Report0001_0002_Data: ChartDataSets[] = [
  ];

  public Report0001_0003_Option: ChartOptions = {
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
  public Report0001_0003_Color: Color[] = [
  ]
  public Report0001_0003_Label: Label[] = [];
  public Report0001_0003_Type: ChartType = 'bar';
  public Report0001_0003_Legend = true;

  public Report0001_0003_Plugin = [
  ];

  public Report0001_0003_Data: ChartDataSets[] = [
  ];
}
