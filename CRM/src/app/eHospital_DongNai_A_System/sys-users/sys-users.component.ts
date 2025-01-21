import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

@Component({
  selector: 'app-sys-users',
  templateUrl: './sys-users.component.html',
  styleUrls: ['./sys-users.component.css']
})
export class SysUsersComponent implements OnInit {

  @ViewChild('Sys_UsersSort') Sys_UsersSort: MatSort;
  @ViewChild('Sys_UsersPaginator') Sys_UsersPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_UsersService: Sys_UsersService,
  ) { }

  ngOnInit(): void {
    this.Sys_UsersSearch();
  }

  Sys_UsersSearch() {
    if (this.Sys_UsersService.BaseParameter.SearchString.length > 0) {
      this.Sys_UsersService.BaseParameter.SearchString = this.Sys_UsersService.BaseParameter.SearchString.trim();
      if (this.Sys_UsersService.DataSource) {
        this.Sys_UsersService.DataSource.filter = this.Sys_UsersService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UsersService.IsShowLoading = true;
      this.Sys_UsersService.GetAllToListAsync().subscribe(
        res => {
          this.Sys_UsersService.List = (res as Sys_Users[]).sort((a, b) => (a.User_Code > b.User_Code ? 1 : -1));
          this.Sys_UsersService.DataSource = new MatTableDataSource(this.Sys_UsersService.List);
          this.Sys_UsersService.DataSource.sort = this.Sys_UsersSort;
          this.Sys_UsersService.DataSource.paginator = this.Sys_UsersPaginator;
        },
        err => {
        },
        () => {
          this.Sys_UsersService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_UsersSave(element: Sys_Users) {
    this.Sys_UsersService.FormData = element;
    this.NotificationService.warn(this.Sys_UsersService.ComponentSaveAll(this.Sys_UsersSort, this.Sys_UsersPaginator));
  }
  Sys_UsersDelete(element: Sys_Users) {
    this.Sys_UsersService.FormData = element;
    this.NotificationService.warn(this.Sys_UsersService.ComponentDeleteAll(this.Sys_UsersSort, this.Sys_UsersPaginator));
  }
}
