import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DM_PhongBan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.model';
import { DM_PhongBanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_PhongBan.service';

@Component({
  selector: 'app-dm-phong-ban-thong-ke',
  templateUrl: './dm-phong-ban-thong-ke.component.html',
  styleUrls: ['./dm-phong-ban-thong-ke.component.css']
})
export class DMPhongBanThongKeComponent implements OnInit {

  @ViewChild('DM_PhongBanSort') DM_PhongBanSort: MatSort;
  @ViewChild('DM_PhongBanPaginator') DM_PhongBanPaginator: MatPaginator;

  IsAll: boolean = false;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DM_PhongBanService: DM_PhongBanService,
  ) { }

  ngOnInit(): void {

  }
  ngAfterViewInit() {
    this.DM_PhongBanSearch();
  }
  DM_PhongBanSearch() {    
    if (this.DM_PhongBanService.BaseParameter.SearchString.length > 0) {
      this.DM_PhongBanService.BaseParameter.SearchString = this.DM_PhongBanService.BaseParameter.SearchString.trim();
      if (this.DM_PhongBanService.DataSource) {
        this.DM_PhongBanService.DataSource.filter = this.DM_PhongBanService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DM_PhongBanService.IsShowLoading = true;
      this.DM_PhongBanService.GetAllToListAsync().subscribe(
        res => {
          this.DM_PhongBanService.List = (res as DM_PhongBan[]);
          if (this.IsAll == true) {
            this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List;
          }
          else {
            this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.List.filter(item => item.CostCenTer_Id > 0 || item.ChuyenKhoa_Id > 0);
          }
          this.DM_PhongBanService.ListFilter = this.DM_PhongBanService.ListFilter.sort((a, b) => (a.ChuyenKhoa_Id > b.ChuyenKhoa_Id ? 1 : -1));
          this.DM_PhongBanService.DataSource = new MatTableDataSource(this.DM_PhongBanService.ListFilter);
          this.DM_PhongBanService.DataSource.sort = this.DM_PhongBanSort;
          this.DM_PhongBanService.DataSource.paginator = this.DM_PhongBanPaginator;
        },
        err => {
        },
        () => {
          this.DM_PhongBanService.IsShowLoading = false;
        }
      );
    }
  }
  DM_PhongBanSave(element: DM_PhongBan) {
    this.DM_PhongBanService.IsShowLoading = true;
    this.DM_PhongBanService.FormData = element;
    this.DM_PhongBanService.SaveAsync().subscribe(
      res => {
        this.DM_PhongBanSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.DM_PhongBanService.IsShowLoading = false;
      }
    );
  }
}