import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_GroupCommands } from 'src/app/shared/eHospital_DongNai_A_System/Sys_GroupCommands.model';
import { Sys_GroupCommandsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_GroupCommands.service';

import { Sys_Groups } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.model';
import { Sys_GroupsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.service';
import { Sys_Menus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.model';
import { Sys_MenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.service';
import { Sys_Functions } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.model';
import { Sys_FunctionsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.service';
import { Sys_Commands } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Commands.model';
import { Sys_CommandsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Commands.service';

@Component({
  selector: 'app-sys-group-commands',
  templateUrl: './sys-group-commands.component.html',
  styleUrls: ['./sys-group-commands.component.css']
})
export class SysGroupCommandsComponent implements OnInit {

  @ViewChild('Sys_GroupCommandsSort') Sys_GroupCommandsSort: MatSort;
  @ViewChild('Sys_GroupCommandsPaginator') Sys_GroupCommandsPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_GroupCommandsService: Sys_GroupCommandsService,
    public Sys_GroupsService: Sys_GroupsService,
    public Sys_MenusService: Sys_MenusService,
    public Sys_CommandsService: Sys_CommandsService,
    public Sys_FunctionsService: Sys_FunctionsService,
  ) { }

  ngOnInit(): void {
    this.Sys_GroupsSearch();
    this.Sys_MenusSearch();
    this.Sys_CommandsSearch();
    this.Sys_FunctionsSearch();
  }
  Sys_CommandsFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_CommandsService.ListFilter = this.Sys_CommandsService.ListAll.filter(item => item.Command_Name.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_CommandsService.ListFilter = this.Sys_CommandsService.ListAll;
    }
  }
  Sys_CommandsSearch() {
    this.Sys_CommandsService.GetAllToListAsync().subscribe(
      res => {
        this.Sys_CommandsService.ListAll = (res as Sys_Commands[]).sort((a, b) => (a.Command_Name > b.Command_Name ? 1 : -1));
        this.Sys_CommandsService.ListFilter = this.Sys_CommandsService.ListAll;
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_FunctionsFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_FunctionsService.ListFilter = this.Sys_FunctionsService.ListAll.filter(item => item.Function_Name.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_FunctionsService.ListFilter = this.Sys_FunctionsService.ListAll;
    }
  }
  Sys_FunctionsSearch() {
    this.Sys_FunctionsService.GetAllToListAsync().subscribe(
      res => {
        this.Sys_FunctionsService.ListAll = (res as Sys_Functions[]).sort((a, b) => (a.Function_Name > b.Function_Name ? 1 : -1));
        this.Sys_FunctionsService.ListFilter = this.Sys_FunctionsService.ListAll;
      },
      err => {
      },
      () => {
      }
    );
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
  Sys_GroupCommandsSearch() {
    if (this.Sys_GroupCommandsService.BaseParameter.SearchString.length > 0) {
      this.Sys_GroupCommandsService.BaseParameter.SearchString = this.Sys_GroupCommandsService.BaseParameter.SearchString.trim();
      if (this.Sys_GroupCommandsService.DataSource) {
        this.Sys_GroupCommandsService.DataSource.filter = this.Sys_GroupCommandsService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_GroupCommandsService.IsShowLoading = true;
      this.Sys_GroupCommandsService.GetByGroup_IdAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_GroupCommandsService.List = (res as Sys_GroupCommands[]).sort((a, b) => (a.Menu_Id > b.Menu_Id ? 1 : -1));
          this.Sys_GroupCommandsService.DataSource = new MatTableDataSource(this.Sys_GroupCommandsService.List);
          this.Sys_GroupCommandsService.DataSource.sort = this.Sys_GroupCommandsSort;
          this.Sys_GroupCommandsService.DataSource.paginator = this.Sys_GroupCommandsPaginator;
        },
        err => {
        },
        () => {
          this.Sys_GroupCommandsService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_GroupCommandsSave(element: Sys_GroupCommands) {
    this.Sys_GroupCommandsService.IsShowLoading = true;
    this.Sys_GroupCommandsService.FormData = element;
    this.Sys_GroupCommandsService.SaveAsync().subscribe(
      res => {
        this.Sys_GroupCommandsService.FormData = res as Sys_GroupCommands;
        this.Sys_GroupCommandsSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_GroupCommandsService.IsShowLoading = false;
      }
    );
  }
  Sys_GroupCommandsDelete(element: Sys_GroupCommands) {
    this.Sys_GroupCommandsService.FormData = element;
    this.NotificationService.warn(this.Sys_GroupCommandsService.ComponentDeleteAll(this.Sys_GroupCommandsSort, this.Sys_GroupCommandsPaginator));
  }
}