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

import { NhanVien_User_Mapping } from 'src/app/shared/eHospital_DongNai_A_Dictionary/NhanVien_User_Mapping.model';
import { NhanVien_User_MappingService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/NhanVien_User_Mapping.service';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

@Component({
  selector: 'app-ns-nhanvieninfo',
  templateUrl: './ns-nhanvieninfo.component.html',
  styleUrls: ['./ns-nhanvieninfo.component.css']
})
export class NSNHANVIENInfoComponent implements OnInit {

  @ViewChild('NhanVien_User_MappingSort') NhanVien_User_MappingSort: MatSort;
  @ViewChild('NhanVien_User_MappingPaginator') NhanVien_User_MappingPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public NS_NHANVIENService: NS_NHANVIENService,
    public NhanVien_User_MappingService: NhanVien_User_MappingService,
    public Sys_UsersService: Sys_UsersService,
  ) { }

  ngOnInit(): void {
    this.NS_NHANVIENService.BaseParameter.NhanVien_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.NS_NHANVIENSearch();
  }
  DateNgaySinh(value) {
    this.NS_NHANVIENService.FormData.NgaySinh = new Date(value);
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
  }
  Sys_UsersFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_UsersService.ListFilter = this.Sys_UsersService.List.filter(item => item.User_Id.toString().toLocaleLowerCase().indexOf(searchString) !== -1 || item.User_Code.toLocaleLowerCase().indexOf(searchString) !== -1 || item.User_Name.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_UsersService.ListFilter = this.Sys_UsersService.List;
    }
  }
  NS_NHANVIENSearch() {
    this.NS_NHANVIENService.IsShowLoading = true;
    this.NS_NHANVIENService.GetByNhanVien_IdAsync().subscribe(
      res => {
        this.NS_NHANVIENService.FormData = res as NS_NHANVIEN;
        this.Sys_UsersSearch();
        this.NhanVien_User_MappingSearch();
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
  NhanVien_User_MappingSearch() {
    this.NhanVien_User_MappingService.BaseParameter.NhanVien_Id = this.NS_NHANVIENService.FormData.NhanVien_Id;
    this.NhanVien_User_MappingService.GetByNhanVien_IdAndEmptyToListAsync().subscribe(
      res => {
        this.NhanVien_User_MappingService.List = (res as NhanVien_User_Mapping[]).sort((a, b) => (a.User_Id > b.User_Id ? 1 : -1));
        this.NhanVien_User_MappingService.DataSource = new MatTableDataSource(this.NhanVien_User_MappingService.List);
        this.NhanVien_User_MappingService.DataSource.sort = this.NhanVien_User_MappingSort;
        this.NhanVien_User_MappingService.DataSource.paginator = this.NhanVien_User_MappingPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  NhanVien_User_MappingSave(element: NhanVien_User_Mapping) {
    this.NS_NHANVIENService.IsShowLoading = true;
    element.NhanVien_Id = this.NS_NHANVIENService.FormData.NhanVien_Id;
    this.NhanVien_User_MappingService.FormData = element;
    this.NhanVien_User_MappingService.SaveAsync().subscribe(
      res => {
        this.NhanVien_User_MappingService.FormData = res as NhanVien_User_Mapping;
        this.NhanVien_User_MappingSearch();
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
