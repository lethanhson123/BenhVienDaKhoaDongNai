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
import { ReportA0002DetailComponent } from '../report-a0002-detail/report-a0002-detail.component';

@Component({
  selector: 'app-report-a0002',
  templateUrl: './report-a0002.component.html',
  styleUrls: ['./report-a0002.component.css']
})
export class ReportA0002Component implements OnInit {

  @ViewChild('ThongKeChiTietSort') ThongKeChiTietSort: MatSort;
  @ViewChild('ThongKeChiTietPaginator') ThongKeChiTietPaginator: MatPaginator;

  Image = new Image();

  IsTongHop: boolean = false;
  IsTheoNgay: boolean = false;
  IsBangKe: boolean = false;

  constructor(
    public Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeService: ThongKeService,
    public ThongKeChiTietService: ThongKeChiTietService,

  ) { }


  ngOnInit(): void {
    this.Image.src = environment.Logo312_80;
    this.ThongKeService.BaseParameter.BatDau = new Date();
    //this.ThongKeSearch();
  }
  Show(Action: number) {
    this.IsTongHop = false;
    this.IsTheoNgay = false;
    this.IsBangKe = false;
    switch (Action) {
      case 1: {
        this.IsTongHop = true;
        break;
      }
      case 2: {
        this.IsTheoNgay = true;
        break;
      }
      case 3: {
        this.IsBangKe = true;
        break;
      }

    }
  }
  DateBatDau(value) {
    this.ThongKeService.BaseParameter.BatDau = new Date(value);
  }
  ThongKeSearch() {
    this.ThongKe001Search();
  }
  ThongKe001Search() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.BaseParameter.ParentID = 1;
    this.ThongKeService.GetByParentID_Year_Month_DayAsync().subscribe(
      res => {
        this.ThongKeService.FormData = (res as ThongKe);
        if (this.ThongKeService.FormData) {
          if (this.ThongKeService.FormData.ID > 0) {
            this.Show(1);
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

        this.ThongKeChiTietService.ListFilter = this.ThongKeChiTietService.List.filter(item => item.SortOrder > 1);
        this.ThongKeChiTietService.ListFilter = this.ThongKeChiTietService.ListFilter.sort((a, b) => (a.RowVersion > b.RowVersion ? 1 : -1));

        this.ThongKeChiTietService.List10 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 10);
        this.ThongKeChiTietService.List10 = this.ThongKeChiTietService.List10.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.DataSource = new MatTableDataSource(this.ThongKeChiTietService.List10);
        this.ThongKeChiTietService.DataSource.sort = this.ThongKeChiTietSort;
        this.ThongKeChiTietService.DataSource.paginator = this.ThongKeChiTietPaginator;

        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 100);
        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List100.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        let LabelArray10 = [];
        let DataArray10 = [];
        for (let i = 0; i < this.ThongKeChiTietService.List10.length; i++) {
          let ThongKeChiTiet = this.ThongKeChiTietService.List10[i];
          LabelArray10.push(ThongKeChiTiet.Name005);
          DataArray10.push(ThongKeChiTiet.ThongKe000);
        }
        this.Report0001_0001_Label = LabelArray10;
        let Label10: string = 'Tổng hợp';
        this.Report0001_0001_Data = [
          { data: DataArray10, label: Label10, stack: 'a', }
        ];

        this.Report0001_0002_Label = LabelArray10;
        this.Report0001_0002_Data = [
          { data: DataArray10, label: Label10, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray100 = [];
        let DataArray100 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List100[0];

        LabelArray100.push("Thứ hai (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray100.push("Thứ ba (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray100.push("Thứ tư (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray100.push("Thứ năm (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray100.push("Thứ sáu (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray100.push("Thứ bảy (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray100.push("Chủ nhật (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray100.push(this.ThongKeChiTietService.FormData.ThongKe007);

        this.Report0001_0003_Label = LabelArray100;
        let Label100: string = 'So sánh giữa ngày trong trong tuần';
        this.Report0001_0003_Data = [
          { data: DataArray100, label: Label100, stack: 'a', }
        ];

        this.Report0001_0004_Label = LabelArray100;
        this.Report0001_0004_Data = [
          { data: DataArray100, label: Label100, stack: 'b', yAxisID: 'B', }
        ];

      },
      err => {
      },
      () => {
        this.ThongKeService.IsShowLoading = false;
      }
    );
  }
  ReportA0002Add(element: ThongKeChiTiet) {
    this.ThongKeChiTietService.List01 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 1 && item.DanhMucUngDungID == element.DanhMucUngDungID);
    this.ThongKeChiTietService.List01 = this.ThongKeChiTietService.List01.sort((a, b) => (a.DanhMucUngDungID > b.DanhMucUngDungID ? 1 : -1));
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: element.ID };
    const dialog = this.Dialog.open(ReportA0002DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
    });
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
    {
      id: 'customCanvasBackgroundImage',
      beforeDraw: (chart) => {
        if (this.Image.complete) {
          const ctx = chart.ctx;
          const { top, left, width, height } = chart.chartArea;
          const x = left;
          const y = top;
          ctx.drawImage(this.Image, x, y, this.Image.width, this.Image.height);
          // const x = left + width / 2 - this.Image.width / 2;
          // const y = top + height / 2 - this.Image.height / 2;
          // ctx.drawImage(this.Image, x, y);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0002_Data: ChartDataSets[] = [
  ];

  public Report0001_0003_Option: ChartOptions = {
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
  public Report0001_0003_Color: Color[] = [
  ]
  public Report0001_0003_Label: Label[] = [];
  public Report0001_0003_Type: ChartType = 'pie';
  public Report0001_0003_Legend = true;
  public Report0001_0003_Plugin = [
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

  public Report0001_0003_Data: ChartDataSets[] = [
  ];

  public Report0001_0004_Option: ChartOptions = {
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
  public Report0001_0004_Color: Color[] = [
  ]
  public Report0001_0004_Label: Label[] = [];
  public Report0001_0004_Type: ChartType = 'bar';
  public Report0001_0004_Legend = true;


  public Report0001_0004_Plugin = [
    {
      id: 'customCanvasBackgroundImage',
      beforeDraw: (chart) => {
        if (this.Image.complete) {
          const ctx = chart.ctx;
          const { top, left, width, height } = chart.chartArea;
          const x = left;
          const y = top;
          ctx.drawImage(this.Image, x, y, this.Image.width, this.Image.height);
          // const x = left + width / 2 - this.Image.width / 2;
          // const y = top + height / 2 - this.Image.height / 2;
          // ctx.drawImage(this.Image, x, y);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0004_Data: ChartDataSets[] = [
  ];
}
