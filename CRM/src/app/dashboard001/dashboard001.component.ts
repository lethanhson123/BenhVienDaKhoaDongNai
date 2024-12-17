import { Component, OnInit, ViewChild, ElementRef, AfterViewInit, OnDestroy } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

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
  selector: 'app-dashboard001',
  templateUrl: './dashboard001.component.html',
  styleUrls: ['./dashboard001.component.css']
})
export class Dashboard001Component {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void {

  }

  map: maplibregl.Map | undefined;

  @ViewChild('map')
  private mapContainer!: ElementRef<HTMLElement>;

  ngAfterViewInit() {
    this.MapLoad(1);
  }

  ngOnDestroy() {
    this.map?.remove();
  }
  MapLoad(ID: number) {
    this.DanhMucTinhThanhToaDoService.IsShowLoading = true;
    this.DanhMucTinhThanhService.BaseParameter.ID = environment.DanhMucTinhThanhID;
    this.DanhMucTinhThanhService.GetByIDAsync().subscribe(
      res => {
        this.DanhMucTinhThanhService.FormData = (res as DanhMucTinhThanh);
        let longitude = environment.Longitude;
        let latitude = environment.Latitude;
        longitude = this.DownloadService.GetKinhDo(Number(this.DanhMucTinhThanhService.FormData.KinhDo));
        latitude = this.DownloadService.GetViDo(Number(this.DanhMucTinhThanhService.FormData.ViDo));

        this.MapInitialization(ID, longitude, latitude);

        var el = document.createElement('div');
        el.style.backgroundImage = "url(image/logo42.png)";
        el.style.width = '42px';
        el.style.height = '42px';
        let marker = new maplibregl.Marker({ element: el })
          .setLngLat([longitude, latitude])
          .addTo(this.map);

        this.DanhMucTinhThanhToaDoService.IsShowLoading = true;
        this.DanhMucTinhThanhToaDoService.BaseParameter.ParentID = this.DanhMucTinhThanhService.FormData.ID;
        this.DanhMucTinhThanhToaDoService.BaseParameter.Active = true;
        this.DanhMucTinhThanhToaDoService.GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync().subscribe(
          res => {
            this.DanhMucTinhThanhToaDoService.List = (res as DanhMucTinhThanhToaDo[]);


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
                  });
                }
              }
            }

          },
          err => {
          },
          () => {
            this.DanhMucTinhThanhToaDoService.IsShowLoading = false;
          }
        );

      },
      err => {
      },
      () => {
        this.DanhMucTinhThanhToaDoService.IsShowLoading = false;
      }
    );
  }

  MapInitialization(ID, longitude, latitude) {
    let IDDate = new Date().toISOString();
    let zoom = environment.MapZoom;

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

}
