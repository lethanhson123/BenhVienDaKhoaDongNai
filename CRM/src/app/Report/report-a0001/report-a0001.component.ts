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

import { BenhAn } from 'src/app/shared/eHospital_DongNai_A/BenhAn.model';
import { BenhAnService } from 'src/app/shared/eHospital_DongNai_A/BenhAn.service';
import { KhamBenh_ToaThuoc } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_ToaThuoc.model';
import { KhamBenh_ToaThuocService } from 'src/app/shared/eHospital_DongNai_A/KhamBenh_ToaThuoc.service';

import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';
import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { DanhMucTinhThanhToaDoService } from 'src/app/shared/DanhMucTinhThanhToaDo.service';

import * as maplibregl from 'maplibre-gl';

@Component({
  selector: 'app-report-a0001',
  templateUrl: './report-a0001.component.html',
  styleUrls: ['./report-a0001.component.css']
})
export class ReportA0001Component implements OnInit {

  @ViewChild('BenhAnSort') BenhAnSort: MatSort;
  @ViewChild('BenhAnPaginator') BenhAnPaginator: MatPaginator;

  @ViewChild('KhamBenh_ToaThuocSort') KhamBenh_ToaThuocSort: MatSort;
  @ViewChild('KhamBenh_ToaThuocPaginator') KhamBenh_ToaThuocPaginator: MatPaginator;

  Image = new Image();

  map: maplibregl.Map | undefined;

  @ViewChild('map')
  private mapContainer!: ElementRef<HTMLElement>;

  IsPopup: boolean = true;
  PopupContent: string = environment.InitializationString;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public BenhAnService: BenhAnService,
    public KhamBenh_ToaThuocService: KhamBenh_ToaThuocService,

    public ReportService: ReportService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void {
    this.Image.src = environment.Logo100_26;
    this.ReportSearch();
  }

  ngAfterViewInit() {
    this.MapLoad(0, environment.DanhMucTinhThanhID, 0);
  }

  ngOnDestroy() {
    this.map?.remove();
  }
  DateBatDau(value) {
    this.ReportService.BaseParameter.BatDau = new Date(value);
  }
  PopupOpen() {
    this.IsPopup = true;
  }
  PopupClose() {
    this.IsPopup = false;
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.BaseParameter.ParentID = environment.DanhMucTinhThanhID;
    this.DanhMucQuanHuyenService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucQuanHuyenService.List = res as DanhMucQuanHuyen[];

      },
      err => {
      }
    );
  }
  KhamBenh_ToaThuocSearch() {
    if (this.ReportService.BaseParameter.SearchString.length > 0) {
      this.ReportService.BaseParameter.SearchString = this.ReportService.BaseParameter.SearchString.trim();
      if (this.BenhAnService.DataSource) {
        this.BenhAnService.DataSource.filter = this.ReportService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.KhamBenh_ToaThuocService.BaseParameter.BatDau = this.ReportService.BaseParameter.BatDau;
      this.KhamBenh_ToaThuocService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.KhamBenh_ToaThuocService.List = (res as KhamBenh_ToaThuoc[]).sort((a, b) => (a.ThoiGianToaThuoc < b.ThoiGianToaThuoc ? 1 : -1));

          this.KhamBenh_ToaThuocService.RenderToListTransfer(this.KhamBenh_ToaThuocSort, this.KhamBenh_ToaThuocPaginator);

          let LabelArray01 = [];
          let DataArray01 = [];
          for (let i = 0; i < this.ReportService.ListFilter.length; i++) {
            let Report = this.ReportService.ListFilter[i];
            LabelArray01.push(Report.Name);
            DataArray01.push(Report.ThongKe001);
          }
          this.Report0002_0002_Label = LabelArray01;
          let Label001: string = 'Toa thuốc';
          this.Report0002_0002_Data = [
            { data: DataArray01, label: Label001, stack: 'a', }
          ];

        },
        err => {
        },
        () => {
        }
      );
    }
  }
  BenhAnSearch() {
    if (this.ReportService.BaseParameter.SearchString.length > 0) {
      this.ReportService.BaseParameter.SearchString = this.ReportService.BaseParameter.SearchString.trim();
      if (this.BenhAnService.DataSource) {
        this.BenhAnService.DataSource.filter = this.ReportService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.KhamBenh_ToaThuocService.BaseParameter.BatDau = this.ReportService.BaseParameter.BatDau;
      this.BenhAnService.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
        res => {
          this.BenhAnService.List = (res as BenhAn[]).sort((a, b) => (a.NgayTao < b.NgayTao ? 1 : -1));

          this.BenhAnService.RenderToListTransfer(this.BenhAnSort, this.BenhAnPaginator);

          let LabelArray01 = [];
          let DataArray01 = [];
          for (let i = 0; i < this.ReportService.ListTemporary.length; i++) {
            let Report = this.ReportService.ListTemporary[i];
            LabelArray01.push(Report.Name);
            DataArray01.push(Report.ThongKe001);
          }
          this.Report0002_0001_Label = LabelArray01;
          let Label001: string = 'Bệnh án';
          this.Report0002_0001_Data = [
            { data: DataArray01, label: Label001, stack: 'a', }
          ];
        },
        err => {
        },
        () => {
        }
      );
    }
  }

  ReportSearch() {
    this.DanhMucQuanHuyenSearch();
    this.KhamBenh_ToaThuocSearch();
    this.BenhAnSearch();
    this.ReportA0001Search();
  }
  ReportA0001Search() {
    this.ReportService.IsShowLoading = true;
    this.ReportService.BaseParameter.PhongBanID = environment.PhongBanIDCapCuu;
    this.ReportService.ReportA0001ToListAsync().subscribe(
      res => {
        this.ReportService.ListReportA = (res as Report[]);

        let List01 = this.ReportService.ListReportA.filter(item => item.ID == 1);
        let List02 = this.ReportService.ListReportA.filter(item => item.ID == 2);
        let List03 = this.ReportService.ListReportA.filter(item => item.ID == 3);
        let List04 = this.ReportService.ListReportA.filter(item => item.ID == 4);

        this.ReportService.FormData.ThongKe001 = environment.InitializationNumber;
        this.ReportService.FormData.ThongKe002 = environment.InitializationNumber;
        this.ReportService.FormData.ThongKe003 = environment.InitializationNumber;
        this.ReportService.FormData.ThongKe004 = environment.InitializationNumber;

        let LabelArray01 = [];
        let DataArray01 = [];
        for (let i = 0; i < List01.length; i++) {
          let Report = List01[i];
          this.ReportService.FormData.ThongKe001 = this.ReportService.FormData.ThongKe001 + Report.ThongKe001;
          LabelArray01.push(Report.Hour);
          DataArray01.push(Report.ThongKe001);
        }
        this.Report0001_0001_Label = LabelArray01;
        let Label001: string = 'Tiếp nhận';
        this.Report0001_0001_Data = [
          { data: DataArray01, label: Label001, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray02 = [];
        let DataArray02 = [];
        for (let i = 0; i < List02.length; i++) {
          let Report = List02[i];
          this.ReportService.FormData.ThongKe002 = this.ReportService.FormData.ThongKe002 + Report.ThongKe001;
          LabelArray02.push(Report.Hour);
          DataArray02.push(Report.ThongKe001);
        }
        this.Report0001_0002_Label = LabelArray02;
        let Label002: string = 'Cấp cứu';
        this.Report0001_0002_Data = [
          { data: DataArray02, label: Label002, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray03 = [];
        let DataArray03 = [];
        for (let i = 0; i < List03.length; i++) {
          let Report = List03[i];
          this.ReportService.FormData.ThongKe003 = this.ReportService.FormData.ThongKe003 + Report.ThongKe001;
          LabelArray03.push(Report.Hour);
          DataArray03.push(Report.ThongKe001);
        }
        this.Report0001_0003_Label = LabelArray03;
        let Label003: string = 'Khám bệnh';
        this.Report0001_0003_Data = [
          { data: DataArray03, label: Label003, stack: 'b', yAxisID: 'B', }
        ];

        let LabelArray04 = [];
        let DataArray04 = [];
        for (let i = 0; i < List04.length; i++) {
          let Report = List04[i];
          this.ReportService.FormData.ThongKe004 = this.ReportService.FormData.ThongKe004 + Report.ThongKe001;
          LabelArray04.push(Report.Hour);
          DataArray04.push(Report.ThongKe001);
        }
        this.Report0001_0004_Label = LabelArray04;
        let Label004: string = 'Vào viện';
        this.Report0001_0004_Data = [
          { data: DataArray04, label: Label004, stack: 'b', yAxisID: 'B', }
        ];
      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  }

  MapLoad(ID: number, ParentID: number, Action: number) {
    this.ReportService.IsShowLoading = true;
    this.DanhMucTinhThanhToaDoService.BaseParameter.ID = ID;
    this.DanhMucTinhThanhToaDoService.BaseParameter.ParentID = ParentID;
    this.DanhMucTinhThanhToaDoService.BaseParameter.Number = Action;
    this.DanhMucTinhThanhToaDoService.BaseParameter.Active = true;
    this.DanhMucTinhThanhToaDoService.GetByParentID_Active_NumberToListAsync().subscribe(
      res => {
        this.DanhMucTinhThanhToaDoService.List = (res as DanhMucTinhThanhToaDo[]);

        let Longitude = environment.Longitude;
        let Latitude = environment.Latitude;
        if (Action % 2 == 0) {
          let ListDanhMucTinhThanh = this.DanhMucTinhThanhService.List.filter(item => item.ID == ParentID);
          if (ListDanhMucTinhThanh) {
            if (ListDanhMucTinhThanh.length > 0) {
              let DanhMucTinhThanh = ListDanhMucTinhThanh[0];
              Longitude = this.DownloadService.GetKinhDo(Number(DanhMucTinhThanh.KinhDo));
              Latitude = this.DownloadService.GetViDo(Number(DanhMucTinhThanh.ViDo));
            }
          }
        }
        else {
          let ListDanhMucQuanHuyen = this.DanhMucQuanHuyenService.List.filter(item => item.ID == ParentID);
          if (ListDanhMucQuanHuyen) {
            if (ListDanhMucQuanHuyen.length > 0) {
              let DanhMucQuanHuyen = ListDanhMucQuanHuyen[0];
              Longitude = this.DownloadService.GetKinhDo(Number(DanhMucQuanHuyen.KinhDo));
              Latitude = this.DownloadService.GetViDo(Number(DanhMucQuanHuyen.ViDo));
            }
          }
        }
        this.MapInitialization(ID, Longitude, Latitude, Action);
        let ListParent = [];

        ListParent = [...new Map(this.DanhMucTinhThanhToaDoService.List.map(item =>
          [item["ParentID"], item])).values()];

        for (let i = 0; i < ListParent.length; i++) {
          let ListDanhMucTinhThanhToaDo = this.DanhMucTinhThanhToaDoService.List.filter((item: any) => item.ParentID == ListParent[i].ParentID);
          if (ListDanhMucTinhThanhToaDo) {
            if (ListDanhMucTinhThanhToaDo.length > 0) {
              let listToaDoPolygon = [];
              let listPolygon = [];
              let Name = environment.InitializationString;
              for (let j = 0; j < ListDanhMucTinhThanhToaDo.length; j++) {
                let longitudeSub1 = this.DownloadService.GetKinhDo(Number(ListDanhMucTinhThanhToaDo[j].KinhDo));
                let latitudeSub1 = this.DownloadService.GetViDo(Number(ListDanhMucTinhThanhToaDo[j].ViDo));
                listToaDoPolygon.push([longitudeSub1, latitudeSub1]);

                Name = ListDanhMucTinhThanhToaDo[j].Name;
              }
              listPolygon.push(listToaDoPolygon);
              let layerID = 'Layer_' + ListParent[i].ID;
              let sourceID = 'Source_' + ListParent[i].ID;
              this.map.on('load', () => {

                this.map.addSource(sourceID, {
                  'type': 'geojson',
                  'data': {
                    'type': 'Feature',
                    'properties': {
                      "name": Name,
                      "address": Name,
                    },
                    'geometry': {
                      'type': 'Polygon',
                      'coordinates': listPolygon,
                    }
                  }
                });

                let length = ListDanhMucTinhThanhToaDo.length + ListParent[i].ParentID + ListParent[i].ID;
                let color = this.DownloadService.GetRandomColor(length);

                this.map.addLayer({
                  'id': layerID + 'Line',
                  'type': 'line',
                  'source': sourceID,
                  'paint': {
                    'line-dasharray': [3, 1],
                    "line-color": color,
                    "line-width": environment.LineWidth,
                  }
                });

                this.map.addLayer({
                  'id': layerID,
                  'type': 'fill',
                  'source': sourceID,
                  'paint': {
                    'fill-color': color,
                    'fill-opacity': 0.2,
                  }
                });

                let DanhMucQuanHuyen = this.DanhMucQuanHuyenService.List.filter(item => item.ID == ListParent[i].ParentID);
                if (DanhMucQuanHuyen) {
                  if (DanhMucQuanHuyen.length > 0) {
                    Longitude = this.DownloadService.GetKinhDo(Number(DanhMucQuanHuyen[0].KinhDo));
                    Latitude = this.DownloadService.GetViDo(Number(DanhMucQuanHuyen[0].ViDo));

                    var el = document.createElement('div');
                    //el.innerHTML = "<h1>" + DanhMucQuanHuyen[0].Name + "</h1>";
                    el.style.backgroundImage = "url(image/logo42.png)";
                    el.style.width = '42px';
                    el.style.height = '42px';
                    let marker = new maplibregl.Marker({ element: el })
                      .setLngLat([Longitude, Latitude])
                      .addTo(this.map);

                    let popupContent = "<div style='opacity: 0.5; background-color: transparent;'>";
                    popupContent = popupContent + "<h6 style='color: #000000; text-align: center;'>Khu vực: <b>" + DanhMucQuanHuyen[0].Name + "</b></h6>";
                    popupContent = popupContent + "<table>";
                    popupContent = popupContent + "<thead>";
                    popupContent = popupContent + "<tr>";
                    popupContent = popupContent + "<th>STT</th>";
                    popupContent = popupContent + "<th>Số bệnh án</th>";
                    popupContent = popupContent + "<th>Số lưu trú</th>";
                    popupContent = popupContent + "<th>Loại bệnh án</th>";
                    popupContent = popupContent + "<th>Trạng thái</th>";
                    popupContent = popupContent + "<th>Bệnh nhân</th>";
                    popupContent = popupContent + "<th>Đối tượng</th>";
                    popupContent = popupContent + "<th>Ngày vào viện</th>";
                    popupContent = popupContent + "</tr>";
                    popupContent = popupContent + "</thead>";
                    popupContent = popupContent + "<tbody>";
                    for (let k = 0; k < 10; k++) {
                      let BenhAn = this.BenhAnService.List[k];
                      popupContent = popupContent + "<tr style='padding-top: 0px !important; padding-bottom: 0px !important;'>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + (k + 1) + "</td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'><a class='link-primary' onclick='OpenWindowByBenhAn(" + BenhAn.BenhAn_Id + ")'><b>"+ BenhAn.SoBenhAn +"</b></a></td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + BenhAn.SoLuuTru + "</td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + BenhAn.LoaiBenhAnName + "</td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + BenhAn.TrangThai + "</td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'><a class='link-primary' onclick='OpenWindowByBenhNhan(" + BenhAn.BenhNhan_Id + ")'><b>"+ BenhAn.BenhNhanName +"</b></a></td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + BenhAn.DoiTuongName + "</td>";
                      popupContent = popupContent + "<td style='padding-top: 0px !important; padding-bottom: 0px !important;'>" + BenhAn.ThoiGianVaoVien + "</td>";
                      popupContent = popupContent + "</tr>";
                    }
                    popupContent = popupContent + "</tbody>";
                    popupContent = popupContent + "</table>";
                    popupContent = popupContent + '</div>';
                    let mapSub = this.map;
                    this.map.on('click', layerID, function (e) {
                      this.map = mapSub;
                      let popup = new maplibregl.Popup({ offset: 25 })
                        .setLngLat(e.lngLat)
                        .setHTML(popupContent)
                        .setMaxWidth("1000px")
                        .addTo(this.map);
                    });

                  }
                }

              });
            }
          }
        }

      },
      err => {
      },
      () => {
        this.ReportService.IsShowLoading = false;
      }
    );
  }

  MapInitialization(ID, longitude, latitude, Action: number) {
    let IDDate = new Date().toISOString();

    let zoom = environment.MapZoom;

    if (Action % 2 == 0) {
      zoom = environment.MapZoom;
    }
    else {
      zoom = environment.MapZoom + 3;
    }
    if ((latitude > 90) || (latitude == 0)) {
      latitude = environment.Latitude;
      longitude = environment.Longitude;
    }


    if (ID == 0) {
      this.map = new maplibregl.Map({
        container: this.mapContainer.nativeElement,
        style: 'https://api.maptiler.com/maps/streets/style.json?key=' + environment.MaptilerAPIKey,
        center: [longitude, latitude],
        zoom: zoom,
        pitch: 45,
      });
    }
    if (ID == 1) {
      this.map = new maplibregl.Map({
        container: this.mapContainer.nativeElement,
        style: 'https://api.maptiler.com/maps/hybrid/style.json?key=' + environment.MaptilerAPIKey,
        center: [longitude, latitude],
        zoom: zoom,
        pitch: 45,
      });
    }

    this.map.addControl(
      new maplibregl.NavigationControl({
        visualizePitch: true,
        showZoom: true,
        showCompass: true
      })
    );
    this.map.addControl(
      new maplibregl.FullscreenControl({
      })
    );
    this.map.on('load', () => {

      // var el = document.createElement('div');
      // el.style.backgroundImage = "url(image/logo42.png)";
      // el.style.width = '42px';
      // el.style.height = '42px';
      // let marker = new maplibregl.Marker({ element: el })
      //   .setLngLat([environment.Longitude, environment.Latitude])
      //   .addTo(this.map);


      this.map.addSource("HoangSa" + IDDate, {
        "type": "image",
        "url": environment.DomainURL + "image/HoangSa01.png",
        "coordinates": [
          [111.09665858054495, 17.432475898867523],
          [113.11720985517763, 17.38420482529338],
          [112.79285037220984, 15.643938718432054],
          [110.88537855035554, 15.672592116966598],
        ]
      });
      this.map.addLayer({
        "id": "HoangSa" + IDDate,
        "source": "HoangSa" + IDDate,
        "type": "raster",
        "paint": {
          "raster-opacity": 1
        }
      });

      this.map.addSource("TruongSa" + IDDate, {
        "type": "image",
        "url": environment.DomainURL + "image/TruongSa01.png",
        "coordinates": [
          [112.32373278444106, 12.236103169381323],
          [117.4620551483049, 11.606334626304161],
          [115.59654957671216, 7.357025445897818],
          [110.62186805246108, 7.811210355974268],


        ]
      });
      this.map.addLayer({
        "id": "TruongSa" + IDDate,
        "source": "TruongSa" + IDDate,
        "type": "raster",
        "paint": {
          "raster-opacity": 1
        }
      });

    });
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
  public Report0001_0002_Plugin = [];

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
  public Report0001_0003_Plugin = [];

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
  public Report0001_0004_Plugin = [];

  public Report0001_0004_Data: ChartDataSets[] = [
  ];

  public Report0002_0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
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
      position: 'bottom'
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
