import { Component, OnInit, ViewChild, ElementRef, AfterViewInit, OnDestroy } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets, Chart, ChartConfiguration, ChartData } from 'chart.js';
import { Color, Label, SingleDataSet, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { ThongKe } from 'src/app/shared/ThongKe.model';
import { ThongKeService } from 'src/app/shared/ThongKe.service';

import { ThongKeChiTiet } from 'src/app/shared/ThongKeChiTiet.model';
import { ThongKeChiTietService } from 'src/app/shared/ThongKeChiTiet.service';
import { ReportA0002DetailComponent } from '../report-a0002-detail/report-a0002-detail.component';

@Component({
  selector: 'app-report-a0002-info',
  templateUrl: './report-a0002-info.component.html',
  styleUrls: ['./report-a0002-info.component.css']
})
export class ReportA0002InfoComponent implements OnInit {

  @ViewChild('ThongKeChiTietSort') ThongKeChiTietSort: MatSort;
  @ViewChild('ThongKeChiTietPaginator') ThongKeChiTietPaginator: MatPaginator;

  @ViewChild('ThongKeChiTietSort07') ThongKeChiTietSort07: MatSort;
  @ViewChild('ThongKeChiTietPaginator07') ThongKeChiTietPaginator07: MatPaginator;

  @ViewChild('ThongKeChiTietSort700') ThongKeChiTietSort700: MatSort;
  @ViewChild('ThongKeChiTietPaginator700') ThongKeChiTietPaginator700: MatPaginator;

  Image = new Image();

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeService: ThongKeService,
    public ThongKeChiTietService: ThongKeChiTietService,
  ) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() {
    this.ThongKeSearch();
  }
  ThongKeSearch() {
    this.ThongKeService.BaseParameter.BatDau = new Date();
    this.ThongKe001Search();
  }
  ThongKe001Search() {
    this.ThongKeService.IsShowLoading = true;
    this.ThongKeService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.ThongKeService.GetByIDAsync().subscribe(
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

        this.ThongKeChiTietService.ListFilter = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 10 || item.SortOrder == 100);
        this.ThongKeChiTietService.ListFilter = this.ThongKeChiTietService.ListFilter.sort((a, b) => (a.RowVersion > b.RowVersion ? 1 : -1));

        this.ThongKeChiTietService.List10 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 10);
        this.ThongKeChiTietService.List10 = this.ThongKeChiTietService.List10.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));


        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 100);
        this.ThongKeChiTietService.List100 = this.ThongKeChiTietService.List100.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List200 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 200);
        this.ThongKeChiTietService.List200 = this.ThongKeChiTietService.List200.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List300 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 300);
        this.ThongKeChiTietService.List300 = this.ThongKeChiTietService.List300.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List400 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 400);
        this.ThongKeChiTietService.List400 = this.ThongKeChiTietService.List400.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List600 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 600);
        this.ThongKeChiTietService.List600 = this.ThongKeChiTietService.List600.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List05 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 5 && item.DanhMucNgonNguID == environment.TinhThanhIDDongNai);
        this.ThongKeChiTietService.List05 = this.ThongKeChiTietService.List05.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));

        this.ThongKeChiTietService.List70 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 70 && item.ThongKe001 >= 100);
        this.ThongKeChiTietService.List70 = this.ThongKeChiTietService.List70.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));

        this.ThongKeChiTietService.List700 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 70);
        this.ThongKeChiTietService.List700 = this.ThongKeChiTietService.List700.sort((a, b) => (a.ThongKe001 > b.ThongKe001 ? 1 : -1));

        this.ThongKeChiTietService.List07 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 7);
        this.ThongKeChiTietService.List07 = this.ThongKeChiTietService.List07.sort((a, b) => (a.Name004 > b.Name004 ? 1 : -1));

        this.ThongKeChiTietService.List800 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 800);
        this.ThongKeChiTietService.List800 = this.ThongKeChiTietService.List800.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));

        this.ThongKeChiTietService.List900 = this.ThongKeChiTietService.List.filter(item => item.SortOrder == 900);
        this.ThongKeChiTietService.List900 = this.ThongKeChiTietService.List900.sort((a, b) => (a.ThongKe000 > b.ThongKe000 ? 1 : -1));


        this.ThongKeChiTietService.DataSource = new MatTableDataSource(this.ThongKeChiTietService.ListFilter);
        this.ThongKeChiTietService.DataSource.sort = this.ThongKeChiTietSort;
        this.ThongKeChiTietService.DataSource.paginator = this.ThongKeChiTietPaginator;


        this.ThongKeChiTietService.DataSource07 = new MatTableDataSource(this.ThongKeChiTietService.List07);
        this.ThongKeChiTietService.DataSource07.sort = this.ThongKeChiTietSort07;
        this.ThongKeChiTietService.DataSource07.paginator = this.ThongKeChiTietPaginator07;

        this.ThongKeChiTietService.DataSource700 = new MatTableDataSource(this.ThongKeChiTietService.List700);
        this.ThongKeChiTietService.DataSource700.sort = this.ThongKeChiTietSort700;
        this.ThongKeChiTietService.DataSource700.paginator = this.ThongKeChiTietPaginator700;


        let LabelArray70 = [];
        let DataArray70 = [];
        for (let i = 0; i < this.ThongKeChiTietService.List70.length; i++) {
          let ThongKeChiTiet = this.ThongKeChiTietService.List70[i];
          LabelArray70.push(ThongKeChiTiet.Name005);
          DataArray70.push(ThongKeChiTiet.ThongKe001);
        }
        this.Report0001_0011_Label = LabelArray70;
        let Label70: string = 'Nhóm ICD';
        this.Report0001_0011_Data = [
          { data: DataArray70, label: Label70, stack: 'a', }
        ];

        this.Report0001_0012_Label = LabelArray70;
        this.Report0001_0012_Data = [
          { data: DataArray70, label: Label70, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray05 = [];
        let DataArray05 = [];
        for (let i = 0; i < this.ThongKeChiTietService.List05.length; i++) {
          let ThongKeChiTiet = this.ThongKeChiTietService.List05[i];
          ThongKeChiTiet.Name002 = ThongKeChiTiet.Name002 + " (" + ThongKeChiTiet.ThongKe001 + ")";
          LabelArray05.push(ThongKeChiTiet.Name002);
          DataArray05.push(ThongKeChiTiet.ThongKe001);
        }
        this.Report0001_0009_Label = LabelArray05;
        let Label05: string = 'Khu vực Đồng Nai';
        this.Report0001_0009_Data = [
          { data: DataArray05, label: Label05, stack: 'a', }
        ];

        this.Report0001_0010_Label = LabelArray05;
        this.Report0001_0010_Data = [
          { data: DataArray05, label: Label05, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray10 = [];
        let DataArray10 = [];
        for (let i = 0; i < this.ThongKeChiTietService.List10.length; i++) {
          let ThongKeChiTiet = this.ThongKeChiTietService.List10[i];
          LabelArray10.push(ThongKeChiTiet.Name005);
          DataArray10.push(ThongKeChiTiet.ThongKe000);
        }
        this.Report0001_0001_Label = LabelArray10;
        let Label10: string = 'Phòng khám';
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
        let Label100: string = 'Ngày trong tuần';
        this.Report0001_0003_Data = [
          { data: DataArray100, label: Label100, stack: 'a', }
        ];

        this.Report0001_0004_Label = LabelArray100;
        this.Report0001_0004_Data = [
          { data: DataArray100, label: Label100, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray200 = [];
        let DataArray200 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List200[0];

        LabelArray200.push("01 (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray200.push("02 (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray200.push("03 (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray200.push("04 (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray200.push("05 (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray200.push("06 (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray200.push("07 (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray200.push("08 (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray200.push("09 (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray200.push("10 (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray200.push("11 (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe011);
        LabelArray200.push("12 (" + this.ThongKeChiTietService.FormData.ThongKe012 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe012);
        LabelArray200.push("13 (" + this.ThongKeChiTietService.FormData.ThongKe013 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe013);
        LabelArray200.push("14 (" + this.ThongKeChiTietService.FormData.ThongKe014 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe014);
        LabelArray200.push("15 (" + this.ThongKeChiTietService.FormData.ThongKe015 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe015);
        LabelArray200.push("16 (" + this.ThongKeChiTietService.FormData.ThongKe016 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe016);
        LabelArray200.push("17 (" + this.ThongKeChiTietService.FormData.ThongKe017 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe017);
        LabelArray200.push("18 (" + this.ThongKeChiTietService.FormData.ThongKe018 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe018);
        LabelArray200.push("19 (" + this.ThongKeChiTietService.FormData.ThongKe019 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe019);
        LabelArray200.push("20 (" + this.ThongKeChiTietService.FormData.ThongKe020 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe020);
        LabelArray200.push("21 (" + this.ThongKeChiTietService.FormData.ThongKe021 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe021);
        LabelArray200.push("22 (" + this.ThongKeChiTietService.FormData.ThongKe022 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe022);
        LabelArray200.push("23 (" + this.ThongKeChiTietService.FormData.ThongKe023 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe023);
        LabelArray200.push("24 (" + this.ThongKeChiTietService.FormData.ThongKe024 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe024);
        LabelArray200.push("25 (" + this.ThongKeChiTietService.FormData.ThongKe025 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe025);
        LabelArray200.push("26 (" + this.ThongKeChiTietService.FormData.ThongKe026 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe026);
        LabelArray200.push("27 (" + this.ThongKeChiTietService.FormData.ThongKe027 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe027);
        LabelArray200.push("28 (" + this.ThongKeChiTietService.FormData.ThongKe028 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe028);
        LabelArray200.push("29 (" + this.ThongKeChiTietService.FormData.ThongKe029 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe029);
        LabelArray200.push("30 (" + this.ThongKeChiTietService.FormData.ThongKe030 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe030);
        LabelArray200.push("31 (" + this.ThongKeChiTietService.FormData.ThongKe031 + ")");
        DataArray200.push(this.ThongKeChiTietService.FormData.ThongKe031);
        let Label200: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        let LabelArray300 = [];
        let DataArray300 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List300[0];

        LabelArray300.push("01 (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray300.push("02 (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray300.push("03 (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray300.push("04 (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray300.push("05 (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray300.push("06 (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray300.push("07 (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray300.push("08 (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray300.push("09 (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray300.push("10 (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray300.push("11 (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe011);
        LabelArray300.push("12 (" + this.ThongKeChiTietService.FormData.ThongKe012 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe012);
        LabelArray300.push("13 (" + this.ThongKeChiTietService.FormData.ThongKe013 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe013);
        LabelArray300.push("14 (" + this.ThongKeChiTietService.FormData.ThongKe014 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe014);
        LabelArray300.push("15 (" + this.ThongKeChiTietService.FormData.ThongKe015 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe015);
        LabelArray300.push("16 (" + this.ThongKeChiTietService.FormData.ThongKe016 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe016);
        LabelArray300.push("17 (" + this.ThongKeChiTietService.FormData.ThongKe017 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe017);
        LabelArray300.push("18 (" + this.ThongKeChiTietService.FormData.ThongKe018 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe018);
        LabelArray300.push("19 (" + this.ThongKeChiTietService.FormData.ThongKe019 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe019);
        LabelArray300.push("20 (" + this.ThongKeChiTietService.FormData.ThongKe020 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe020);
        LabelArray300.push("21 (" + this.ThongKeChiTietService.FormData.ThongKe021 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe021);
        LabelArray300.push("22 (" + this.ThongKeChiTietService.FormData.ThongKe022 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe022);
        LabelArray300.push("23 (" + this.ThongKeChiTietService.FormData.ThongKe023 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe023);
        LabelArray300.push("24 (" + this.ThongKeChiTietService.FormData.ThongKe024 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe024);
        LabelArray300.push("25 (" + this.ThongKeChiTietService.FormData.ThongKe025 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe025);
        LabelArray300.push("26 (" + this.ThongKeChiTietService.FormData.ThongKe026 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe026);
        LabelArray300.push("27 (" + this.ThongKeChiTietService.FormData.ThongKe027 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe027);
        LabelArray300.push("28 (" + this.ThongKeChiTietService.FormData.ThongKe028 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe028);
        LabelArray300.push("29 (" + this.ThongKeChiTietService.FormData.ThongKe029 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe029);
        LabelArray300.push("30 (" + this.ThongKeChiTietService.FormData.ThongKe030 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe030);
        LabelArray300.push("31 (" + this.ThongKeChiTietService.FormData.ThongKe031 + ")");
        DataArray300.push(this.ThongKeChiTietService.FormData.ThongKe031);
        let Label203: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        let LabelArray400 = [];
        let DataArray400 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List400[0];

        LabelArray400.push("01 (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray400.push("02 (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray400.push("03 (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray400.push("04 (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray400.push("05 (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray400.push("06 (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray400.push("07 (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray400.push("08 (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray400.push("09 (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray400.push("10 (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray400.push("11 (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe011);
        LabelArray400.push("12 (" + this.ThongKeChiTietService.FormData.ThongKe012 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe012);
        LabelArray400.push("13 (" + this.ThongKeChiTietService.FormData.ThongKe013 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe013);
        LabelArray400.push("14 (" + this.ThongKeChiTietService.FormData.ThongKe014 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe014);
        LabelArray400.push("15 (" + this.ThongKeChiTietService.FormData.ThongKe015 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe015);
        LabelArray400.push("16 (" + this.ThongKeChiTietService.FormData.ThongKe016 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe016);
        LabelArray400.push("17 (" + this.ThongKeChiTietService.FormData.ThongKe017 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe017);
        LabelArray400.push("18 (" + this.ThongKeChiTietService.FormData.ThongKe018 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe018);
        LabelArray400.push("19 (" + this.ThongKeChiTietService.FormData.ThongKe019 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe019);
        LabelArray400.push("20 (" + this.ThongKeChiTietService.FormData.ThongKe020 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe020);
        LabelArray400.push("21 (" + this.ThongKeChiTietService.FormData.ThongKe021 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe021);
        LabelArray400.push("22 (" + this.ThongKeChiTietService.FormData.ThongKe022 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe022);
        LabelArray400.push("23 (" + this.ThongKeChiTietService.FormData.ThongKe023 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe023);
        LabelArray400.push("24 (" + this.ThongKeChiTietService.FormData.ThongKe024 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe024);
        LabelArray400.push("25 (" + this.ThongKeChiTietService.FormData.ThongKe025 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe025);
        LabelArray400.push("26 (" + this.ThongKeChiTietService.FormData.ThongKe026 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe026);
        LabelArray400.push("27 (" + this.ThongKeChiTietService.FormData.ThongKe027 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe027);
        LabelArray400.push("28 (" + this.ThongKeChiTietService.FormData.ThongKe028 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe028);
        LabelArray400.push("29 (" + this.ThongKeChiTietService.FormData.ThongKe029 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe029);
        LabelArray400.push("30 (" + this.ThongKeChiTietService.FormData.ThongKe030 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe030);
        LabelArray400.push("31 (" + this.ThongKeChiTietService.FormData.ThongKe031 + ")");
        DataArray400.push(this.ThongKeChiTietService.FormData.ThongKe031);
        let Label204: string = 'Tháng ' + this.ThongKeChiTietService.FormData.Month + ' năm ' + this.ThongKeChiTietService.FormData.Year;

        this.Report0001_0005_Label = LabelArray200;


        this.Report0001_0005_Data = [
          { data: DataArray400, label: Label204, stack: 'a', type: 'line', fill: false, },
          { data: DataArray300, label: Label203, stack: 'a', type: 'line', fill: false },
          //{ data: DataArray200, label: Label200, stack: 'a', type: 'line', fill: false },
          { data: DataArray200, label: Label200, stack: 'a1' },
          // { data: DataArray300, label: Label203, stack: 'a2', },
          // { data: DataArray400, label: Label204, stack: 'a3', },
        ];

        let LabelArray800 = [];
        let DataArray800 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List800[0];

        LabelArray800.push("01 (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray800.push("02 (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray800.push("03 (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray800.push("04 (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray800.push("05 (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray800.push("06 (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray800.push("07 (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray800.push("08 (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray800.push("09 (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray800.push("10 (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray800.push("11 (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe011);
        LabelArray800.push("12 (" + this.ThongKeChiTietService.FormData.ThongKe012 + ")");
        DataArray800.push(this.ThongKeChiTietService.FormData.ThongKe012);

        let Label800: string = 'Năm ' + this.ThongKeChiTietService.FormData.Year;

        let LabelArray900 = [];
        let DataArray900 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List900[0];

        LabelArray900.push("01 (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray900.push("02 (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray900.push("03 (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray900.push("04 (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray900.push("05 (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray900.push("06 (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray900.push("07 (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray900.push("08 (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray900.push("09 (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray900.push("10 (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray900.push("11 (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe011);
        LabelArray900.push("12 (" + this.ThongKeChiTietService.FormData.ThongKe012 + ")");
        DataArray900.push(this.ThongKeChiTietService.FormData.ThongKe012);
        
        let Label900: string = 'Năm ' + this.ThongKeChiTietService.FormData.Year;

        this.Report0001_0015_Label = LabelArray800;


        this.Report0001_0015_Data = [
          { data: DataArray900, label: Label900, stack: 'a', type: 'line', fill: false, },          
          { data: DataArray800, label: Label800, stack: 'a'},          
        ];


        let LabelArray600 = [];
        let DataArray600 = [];
        this.ThongKeChiTietService.FormData = this.ThongKeChiTietService.List600[0];

        LabelArray600.push("Dưới 10 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe001 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe001 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe001);
        LabelArray600.push("Dưới 20 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe002 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe002 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe002);
        LabelArray600.push("Dưới 30 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe003 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe003 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe003);
        LabelArray600.push("Dưới 40 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe004 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe004 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe004);
        LabelArray600.push("Dưới 50 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe005 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe005 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe005);
        LabelArray600.push("Dưới 60 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe006 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe006 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe006);
        LabelArray600.push("Dưới 70 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe007 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe007 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe007);
        LabelArray600.push("Dưới 80 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe008 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe008 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe008);
        LabelArray600.push("Dưới 90 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe009 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe009 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe009);
        LabelArray600.push("Dưới 100 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe010 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe010 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe010);
        LabelArray600.push("Trên 100 tuổi (" + this.ThongKeChiTietService.FormData.ThongKe011 + ")" + " (" + (this.ThongKeChiTietService.FormData.ThongKe011 / this.ThongKeChiTietService.FormData.ThongKe000 * 100).toFixed(2) + " %)");
        DataArray600.push(this.ThongKeChiTietService.FormData.ThongKe011);

        let Label600: string = 'Độ tuổi';

        this.Report0001_0006_Label = LabelArray600;


        this.Report0001_0006_Data = [
          { data: DataArray600, label: Label600, stack: 'a', }
        ];

        this.Report0001_0007_Label = LabelArray600;


        this.Report0001_0007_Data = [
          { data: DataArray600, label: Label600, stack: 'a', }
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

  public Report0001_0005_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'top'
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
          // const x = left + width / 2 - this.Image.width / 2;
          // const y = top + height / 2 - this.Image.height / 2;
          // ctx.drawImage(this.Image, x, y);
        } else {
          this.Image.onload = () => chart.draw();
        }
      }
    }
  ];

  public Report0001_0005_Data: ChartDataSets[] = [
  ];

  public Report0001_0006_Option: ChartOptions = {
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
  public Report0001_0006_Color: Color[] = [
  ]
  public Report0001_0006_Label: Label[] = [];
  public Report0001_0006_Type: ChartType = 'doughnut';
  public Report0001_0006_Legend = true;
  public Report0001_0006_Plugin = [
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

  public Report0001_0006_Data: ChartDataSets[] = [
  ];

  public Report0001_0007_Option: ChartOptions = {
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
  public Report0001_0007_Color: Color[] = [
  ]
  public Report0001_0007_Label: Label[] = [];
  public Report0001_0007_Type: ChartType = 'bar';
  public Report0001_0007_Legend = true;


  public Report0001_0007_Plugin = [
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

  public Report0001_0007_Data: ChartDataSets[] = [
  ];

  public Report0001_0009_Option: ChartOptions = {
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
  public Report0001_0009_Color: Color[] = [
  ]
  public Report0001_0009_Label: Label[] = [];
  public Report0001_0009_Type: ChartType = 'doughnut';
  public Report0001_0009_Legend = true;
  public Report0001_0009_Plugin = [
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

  public Report0001_0009_Data: ChartDataSets[] = [
  ];

  public Report0001_0010_Option: ChartOptions = {
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
  public Report0001_0010_Color: Color[] = [
  ]
  public Report0001_0010_Label: Label[] = [];
  public Report0001_0010_Type: ChartType = 'bar';
  public Report0001_0010_Legend = true;


  public Report0001_0010_Plugin = [
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

  public Report0001_0010_Data: ChartDataSets[] = [
  ];

  public Report0001_0011_Option: ChartOptions = {
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
  public Report0001_0011_Color: Color[] = [
  ]
  public Report0001_0011_Label: Label[] = [];
  public Report0001_0011_Type: ChartType = 'doughnut';
  public Report0001_0011_Legend = true;
  public Report0001_0011_Plugin = [
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

  public Report0001_0011_Data: ChartDataSets[] = [
  ];

  public Report0001_0012_Option: ChartOptions = {
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
  public Report0001_0012_Color: Color[] = [
  ]
  public Report0001_0012_Label: Label[] = [];
  public Report0001_0012_Type: ChartType = 'bar';
  public Report0001_0012_Legend = true;


  public Report0001_0012_Plugin = [
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

  public Report0001_0012_Data: ChartDataSets[] = [
  ];

  public Report0001_0015_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'top'
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
  public Report0001_0015_Color: Color[] = [    
  ]
  public Report0001_0015_Label: Label[] = [];
  public Report0001_0015_Type: ChartType = 'bar';
  public Report0001_0015_Legend = true;


  public Report0001_0015_Plugin = [
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

  public Report0001_0015_Data: ChartDataSets[] = [
  ];
}
