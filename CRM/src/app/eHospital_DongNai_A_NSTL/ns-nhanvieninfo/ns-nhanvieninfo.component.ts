import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL//NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL//NS_NHANVIEN.service';

@Component({
  selector: 'app-ns-nhanvieninfo',
  templateUrl: './ns-nhanvieninfo.component.html',
  styleUrls: ['./ns-nhanvieninfo.component.css']
})
export class NSNHANVIENInfoComponent implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public NS_NHANVIENService: NS_NHANVIENService,

  ) { }

  ngOnInit(): void {
    this.NS_NHANVIENService.BaseParameter.NhanVien_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.NS_NHANVIENSearch();
  }
  DateNgaySinh(value) {
    this.NS_NHANVIENService.FormData.NgaySinh = new Date(value);
  }
  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.IsShowLoading = true;
    this.NS_NHANVIENService.GetByNhanVien_IdAsync().subscribe(
      res => {
        this.NS_NHANVIENService.FormData = res as NS_NHANVIEN;
      },
      err => {
      },
      () => {
        this.NS_NHANVIENService.IsShowLoading = false;
      }
    );
  }
  NS_NHANVIENSave() {
    this.NS_NHANVIENService.IsShowLoading = true;
    this.NS_NHANVIENService.SaveAsync().subscribe(
      res => {
        this.NS_NHANVIENService.FormData = res as NS_NHANVIEN;
        this.Router.navigateByUrl(environment.NSNHANVIENInfo + this.NS_NHANVIENService.FormData.NhanVien_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.NS_NHANVIENService.IsShowLoading = false;
      }
    );
  }


}
