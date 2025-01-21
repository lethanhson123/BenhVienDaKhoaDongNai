import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_Menus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.model';
import { Sys_MenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.service';

@Component({
  selector: 'app-sys-menus',
  templateUrl: './sys-menus.component.html',
  styleUrls: ['./sys-menus.component.css']
})
export class SysMenusComponent implements OnInit {

  @ViewChild('Sys_MenusSort') Sys_MenusSort: MatSort;
  @ViewChild('Sys_MenusPaginator') Sys_MenusPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_MenusService: Sys_MenusService,
  ) { }

  ngOnInit(): void {    
    this.Sys_MenusSearchAll();
  }
  Sys_MenusFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_MenusService.ListFilter = this.Sys_MenusService.ListAll.filter(item => item.Menu_Name.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Menu_Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_MenusService.ListFilter = this.Sys_MenusService.ListAll;
    }
  }
  Sys_MenusSearchAll() {
    this.Sys_MenusService.GetAllToListAsync().subscribe(
      res => {
        this.Sys_MenusService.ListAll = (res as Sys_Menus[]).sort((a, b) => (a.Menu_Level > b.Menu_Level ? 1 : -1));
        this.Sys_MenusService.ListFilter = this.Sys_MenusService.ListAll;
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_MenusSearch() {
    if (this.Sys_MenusService.BaseParameter.SearchString.length > 0) {
      this.Sys_MenusService.BaseParameter.SearchString = this.Sys_MenusService.BaseParameter.SearchString.trim();
      if (this.Sys_MenusService.DataSource) {
        this.Sys_MenusService.DataSource.filter = this.Sys_MenusService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_MenusService.IsShowLoading = true;
      this.Sys_MenusService.GetByParent_IdAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_MenusService.List = (res as Sys_Menus[]).sort((a, b) => (a.Idx > b.Idx ? 1 : -1));
          this.Sys_MenusService.DataSource = new MatTableDataSource(this.Sys_MenusService.List);
          this.Sys_MenusService.DataSource.sort = this.Sys_MenusSort;
          this.Sys_MenusService.DataSource.paginator = this.Sys_MenusPaginator;
        },
        err => {
        },
        () => {
          this.Sys_MenusService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_MenusSave(element: Sys_Menus) {
    this.Sys_MenusService.IsShowLoading = true;
    this.Sys_MenusService.FormData = element;
    this.Sys_MenusService.SaveAsync().subscribe(
      res => {
        this.Sys_MenusService.FormData = res as Sys_Menus;
        this.Sys_MenusSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_MenusService.IsShowLoading = false;
      }
    );
  }
  Sys_MenusDelete(element: Sys_Menus) {
    this.Sys_MenusService.FormData = element;
    this.NotificationService.warn(this.Sys_MenusService.ComponentDeleteAll(this.Sys_MenusSort, this.Sys_MenusPaginator));
  }
}
