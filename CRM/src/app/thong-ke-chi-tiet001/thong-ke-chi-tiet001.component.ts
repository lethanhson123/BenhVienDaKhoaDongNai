import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { ThongKeChiTiet } from 'src/app/shared/ThongKeChiTiet.model';
import { ThongKeChiTietService } from 'src/app/shared/ThongKeChiTiet.service';

@Component({
  selector: 'app-thong-ke-chi-tiet001',
  templateUrl: './thong-ke-chi-tiet001.component.html',
  styleUrls: ['./thong-ke-chi-tiet001.component.css']
})
export class ThongKeChiTiet001Component implements OnInit {

  @ViewChild('ThongKeChiTietSort') ThongKeChiTietSort: MatSort;
  @ViewChild('ThongKeChiTietPaginator') ThongKeChiTietPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeChiTietService: ThongKeChiTietService,

  ) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() {
  }
  DateBatDau(value) {
    this.ThongKeChiTietService.BaseParameter.BatDau = new Date(value);
  }
  DateKetThuc(value) {
    this.ThongKeChiTietService.BaseParameter.KetThuc = new Date(value);
  }
  ThongKeChiTietSearch() {
    this.ThongKeChiTietService.IsShowLoading = true;
    this.ThongKeChiTietService.ReportAToaThuoc_MinhToListAsync().subscribe(
      res => {
        this.ThongKeChiTietService.List = (res as ThongKeChiTiet[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));;
        this.ThongKeChiTietService.DataSource = new MatTableDataSource(this.ThongKeChiTietService.List);
        this.ThongKeChiTietService.DataSource.sort = this.ThongKeChiTietSort;
        this.ThongKeChiTietService.DataSource.paginator = this.ThongKeChiTietPaginator;
      },
      err => {
      },
      () => {
        this.ThongKeChiTietService.IsShowLoading = false;
      }
    );
  }
  ThongKeChiTietExportExcel() {
    this.ThongKeChiTietService.IsShowLoading = true;   
    this.ThongKeChiTietService.ReportAToaThuoc_MinhToExcelAsync().subscribe(
      res => {        
        window.open(res.toString(), "_blank");        
      },
      err => {
      },
      () => {
        this.ThongKeChiTietService.IsShowLoading = false;
      }
    );
  }
}
