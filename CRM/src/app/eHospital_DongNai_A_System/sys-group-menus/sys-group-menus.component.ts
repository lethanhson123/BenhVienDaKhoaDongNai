import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_GroupMenus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_GroupMenus.model';
import { Sys_GroupMenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_GroupMenus.service';
import { Sys_Groups } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.model';
import { Sys_GroupsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.service';
import { Sys_Menus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.model';
import { Sys_MenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.service';

@Component({
  selector: 'app-sys-group-menus',
  templateUrl: './sys-group-menus.component.html',
  styleUrls: ['./sys-group-menus.component.css']
})
export class SysGroupMenusComponent implements OnInit {

  @ViewChild('Sys_GroupMenusSort') Sys_GroupMenusSort: MatSort;
  @ViewChild('Sys_GroupMenusPaginator') Sys_GroupMenusPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_GroupMenusService: Sys_GroupMenusService,
    public Sys_GroupsService: Sys_GroupsService,
    public Sys_MenusService: Sys_MenusService,
  ) { }

  ngOnInit(): void {
    this.Sys_GroupsSearch();
    this.Sys_MenusSearch();
  }
  Sys_GroupsFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_GroupsService.ListFilter = this.Sys_GroupsService.ListAll.filter(item => item.Group_Name.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Group_Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_GroupsService.ListFilter = this.Sys_GroupsService.ListAll;
    }
  }
  Sys_GroupsSearch() {
    this.Sys_GroupsService.GetAllToListAsync().subscribe(
      res => {
        this.Sys_GroupsService.ListAll = (res as Sys_Groups[]).sort((a, b) => (a.Group_Name > b.Group_Name ? 1 : -1));
        this.Sys_GroupsService.ListFilter = this.Sys_GroupsService.ListAll;
      },
      err => {
      },
      () => {
      }
    );
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
  Sys_MenusSearch() {
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
  Sys_GroupMenusSearch() {
    if (this.Sys_GroupMenusService.BaseParameter.SearchString.length > 0) {
      this.Sys_GroupMenusService.BaseParameter.SearchString = this.Sys_GroupMenusService.BaseParameter.SearchString.trim();
      if (this.Sys_GroupMenusService.DataSource) {
        this.Sys_GroupMenusService.DataSource.filter = this.Sys_GroupMenusService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_GroupMenusService.IsShowLoading = true;
      this.Sys_GroupMenusService.GetByGroup_IdAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_GroupMenusService.List = (res as Sys_GroupMenus[]).sort((a, b) => (a.Menu_Id > b.Menu_Id ? 1 : -1));
          this.Sys_GroupMenusService.DataSource = new MatTableDataSource(this.Sys_GroupMenusService.List);
          this.Sys_GroupMenusService.DataSource.sort = this.Sys_GroupMenusSort;
          this.Sys_GroupMenusService.DataSource.paginator = this.Sys_GroupMenusPaginator;
        },
        err => {
        },
        () => {
          this.Sys_GroupMenusService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_GroupMenusSave(element: Sys_GroupMenus) {
    this.Sys_GroupMenusService.IsShowLoading = true;
    this.Sys_GroupMenusService.FormData = element;
    this.Sys_GroupMenusService.SaveAsync().subscribe(
      res => {
        this.Sys_GroupMenusService.FormData = res as Sys_GroupMenus;
        this.Sys_GroupMenusSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_GroupMenusService.IsShowLoading = false;
      }
    );
  }
  Sys_GroupMenusDelete(element: Sys_GroupMenus) {
    this.Sys_GroupMenusService.FormData = element;
    this.NotificationService.warn(this.Sys_GroupMenusService.ComponentDeleteAll(this.Sys_GroupMenusSort, this.Sys_GroupMenusPaginator));
  }
}
