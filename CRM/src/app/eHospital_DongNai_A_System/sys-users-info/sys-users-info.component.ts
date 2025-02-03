import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { Sys_Menus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.model';
import { Sys_MenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Menus.service';
import { Sys_Groups } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.model';
import { Sys_GroupsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Groups.service';
import { Sys_Commands } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Commands.model';
import { Sys_CommandsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Commands.service';
import { Sys_Functions } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.model';
import { Sys_FunctionsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.service';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';
import { Sys_UserPasswordHistory } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserPasswordHistory.model';
import { Sys_UserPasswordHistoryService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserPasswordHistory.service';
import { Sys_UserMenus } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserMenus.model';
import { Sys_UserMenusService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserMenus.service';
import { Sys_UserGroups } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserGroups.model';
import { Sys_UserGroupsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserGroups.service';
import { Sys_UserCommands } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserCommands.model';
import { Sys_UserCommandsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_UserCommands.service';


import { Sys_AppPrivateSettings } from 'src/app/shared/eHospital_DongNai_A_Config/Sys_AppPrivateSettings.model';
import { Sys_AppPrivateSettingsService } from 'src/app/shared/eHospital_DongNai_A_Config/Sys_AppPrivateSettings.service';

@Component({
  selector: 'app-sys-users-info',
  templateUrl: './sys-users-info.component.html',
  styleUrls: ['./sys-users-info.component.css']
})
export class SysUsersInfoComponent implements OnInit {

  @ViewChild('Sys_UserPasswordHistorySort') Sys_UserPasswordHistorySort: MatSort;
  @ViewChild('Sys_UserPasswordHistoryPaginator') Sys_UserPasswordHistoryPaginator: MatPaginator;

  @ViewChild('Sys_UserMenusSort') Sys_UserMenusSort: MatSort;
  @ViewChild('Sys_UserMenusPaginator') Sys_UserMenusPaginator: MatPaginator;

  @ViewChild('Sys_UserCommandsSort') Sys_UserCommandsSort: MatSort;
  @ViewChild('Sys_UserCommandsPaginator') Sys_UserCommandsPaginator: MatPaginator;

  @ViewChild('Sys_UserGroupsSort') Sys_UserGroupsSort: MatSort;
  @ViewChild('Sys_UserGroupsPaginator') Sys_UserGroupsPaginator: MatPaginator;

  @ViewChild('Sys_AppPrivateSettingsSort') Sys_AppPrivateSettingsSort: MatSort;
  @ViewChild('Sys_AppPrivateSettingsPaginator') Sys_AppPrivateSettingsPaginator: MatPaginator;

  @ViewChild('Sys_AppPrivateSettingsSort001') Sys_AppPrivateSettingsSort001: MatSort;
  @ViewChild('Sys_AppPrivateSettingsPaginator001') Sys_AppPrivateSettingsPaginator001: MatPaginator;
  @ViewChild('Sys_AppPrivateSettingsSort002') Sys_AppPrivateSettingsSort002: MatSort;
  @ViewChild('Sys_AppPrivateSettingsPaginator002') Sys_AppPrivateSettingsPaginator002: MatPaginator;
  @ViewChild('Sys_AppPrivateSettingsSort003') Sys_AppPrivateSettingsSort003: MatSort;
  @ViewChild('Sys_AppPrivateSettingsPaginator003') Sys_AppPrivateSettingsPaginator003: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_MenusService: Sys_MenusService,
    public Sys_GroupsService: Sys_GroupsService,
    public Sys_CommandsService: Sys_CommandsService,
    public Sys_FunctionsService: Sys_FunctionsService,

    public Sys_UsersService: Sys_UsersService,
    public Sys_UserPasswordHistoryService: Sys_UserPasswordHistoryService,
    public Sys_UserMenusService: Sys_UserMenusService,
    public Sys_UserGroupsService: Sys_UserGroupsService,
    public Sys_UserCommandsService: Sys_UserCommandsService,
    public Sys_AppPrivateSettingsService: Sys_AppPrivateSettingsService,

  ) { }

  ngOnInit(): void {
    this.Sys_UsersService.BaseParameter.User_Id = Number(this.ActiveRouter.snapshot.params.ID);
    this.Sys_UsersSearch();
  }
  Sys_CommandsFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_CommandsService.ListFilter = this.Sys_CommandsService.ListAll.filter(item => item.Command_Name.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Command_Text.toLocaleLowerCase().indexOf(searchString) !== -1);
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
      this.Sys_FunctionsService.ListFilter = this.Sys_FunctionsService.ListAll.filter(item => item.Function_Name.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Function_Class.toLocaleLowerCase().indexOf(searchString) !== -1);
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
  Sys_AppPrivateSettingsSearch() {
    if (this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.length > 0) {
      this.Sys_AppPrivateSettingsService.BaseParameter.SearchString = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.trim();
      if (this.Sys_AppPrivateSettingsService.DataSource) {
        this.Sys_AppPrivateSettingsService.DataSource.filter = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UsersService.IsShowLoading = true;
      this.Sys_AppPrivateSettingsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
      this.Sys_AppPrivateSettingsService.GetByUser_IdAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_AppPrivateSettingsService.List = (res as Sys_AppPrivateSettings[]);
          this.Sys_AppPrivateSettingsService.DataSource = new MatTableDataSource(this.Sys_AppPrivateSettingsService.List);
          this.Sys_AppPrivateSettingsService.DataSource.sort = this.Sys_AppPrivateSettingsSort;
          this.Sys_AppPrivateSettingsService.DataSource.paginator = this.Sys_AppPrivateSettingsPaginator;
        },
        err => {
        },
        () => {
          this.Sys_UsersService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_AppPrivateSettingsSearch001() {
    if (this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.length > 0) {
      this.Sys_AppPrivateSettingsService.BaseParameter.SearchString = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.trim();
      if (this.Sys_AppPrivateSettingsService.DataSource001) {
        this.Sys_AppPrivateSettingsService.DataSource001.filter = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UsersService.IsShowLoading = true;
      this.Sys_AppPrivateSettingsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
      this.Sys_AppPrivateSettingsService.BaseParameter.Code = environment.PhongBan;
      this.Sys_AppPrivateSettingsService.GetByUser_IdAndCodeAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_AppPrivateSettingsService.List001 = (res as Sys_AppPrivateSettings[]);
          this.Sys_AppPrivateSettingsService.DataSource001 = new MatTableDataSource(this.Sys_AppPrivateSettingsService.List001);
          this.Sys_AppPrivateSettingsService.DataSource001.sort = this.Sys_AppPrivateSettingsSort001;
          this.Sys_AppPrivateSettingsService.DataSource001.paginator = this.Sys_AppPrivateSettingsPaginator001;
        },
        err => {
        },
        () => {
          this.Sys_UsersService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_AppPrivateSettingsSearch002() {
    if (this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.length > 0) {
      this.Sys_AppPrivateSettingsService.BaseParameter.SearchString = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.trim();
      if (this.Sys_AppPrivateSettingsService.DataSource002) {
        this.Sys_AppPrivateSettingsService.DataSource002.filter = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UsersService.IsShowLoading = true;
      this.Sys_AppPrivateSettingsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
      this.Sys_AppPrivateSettingsService.BaseParameter.Code = environment.KhoDuoc;
      this.Sys_AppPrivateSettingsService.GetByUser_IdAndCodeAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_AppPrivateSettingsService.List002 = (res as Sys_AppPrivateSettings[]);
          this.Sys_AppPrivateSettingsService.DataSource002 = new MatTableDataSource(this.Sys_AppPrivateSettingsService.List002);
          this.Sys_AppPrivateSettingsService.DataSource002.sort = this.Sys_AppPrivateSettingsSort002;
          this.Sys_AppPrivateSettingsService.DataSource002.paginator = this.Sys_AppPrivateSettingsPaginator002;
        },
        err => {
        },
        () => {
          this.Sys_UsersService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_AppPrivateSettingsSearch003() {
    if (this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.length > 0) {
      this.Sys_AppPrivateSettingsService.BaseParameter.SearchString = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.trim();
      if (this.Sys_AppPrivateSettingsService.DataSource003) {
        this.Sys_AppPrivateSettingsService.DataSource003.filter = this.Sys_AppPrivateSettingsService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UsersService.IsShowLoading = true;
      this.Sys_AppPrivateSettingsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
      this.Sys_AppPrivateSettingsService.BaseParameter.Code = environment.NhomCanLamSang;
      this.Sys_AppPrivateSettingsService.GetByUser_IdAndCodeAndEmptyToListAsync().subscribe(
        res => {
          this.Sys_AppPrivateSettingsService.List003 = (res as Sys_AppPrivateSettings[]);
          this.Sys_AppPrivateSettingsService.DataSource003 = new MatTableDataSource(this.Sys_AppPrivateSettingsService.List003);
          this.Sys_AppPrivateSettingsService.DataSource003.sort = this.Sys_AppPrivateSettingsSort003;
          this.Sys_AppPrivateSettingsService.DataSource003.paginator = this.Sys_AppPrivateSettingsPaginator003;
        },
        err => {
        },
        () => {
          this.Sys_UsersService.IsShowLoading = false;
        }
      );
    }
  }
  Sys_AppPrivateSettingsSave(element: Sys_AppPrivateSettings) {
    this.Sys_UsersService.IsShowLoading = true;
    element.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_AppPrivateSettingsService.FormData = element;
    this.Sys_AppPrivateSettingsService.SaveAsync().subscribe(
      res => {
        this.Sys_AppPrivateSettingsService.FormData = res as Sys_AppPrivateSettings;
        this.Sys_AppPrivateSettingsSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }
  Sys_UserCommandsSearch() {
    this.Sys_UserCommandsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserCommandsService.GetByUser_Id_SearchStringAndEmptyToListAsync().subscribe(
      res => {
        this.Sys_UserCommandsService.List = (res as Sys_UserCommands[]).sort((a, b) => (a.Menu_Id > b.Menu_Id ? 1 : -1));
        this.Sys_UserCommandsService.DataSource = new MatTableDataSource(this.Sys_UserCommandsService.List);
        this.Sys_UserCommandsService.DataSource.sort = this.Sys_UserCommandsSort;
        this.Sys_UserCommandsService.DataSource.paginator = this.Sys_UserCommandsPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_UserCommandsSave(element: Sys_UserCommands) {
    this.Sys_UserCommandsService.IsShowLoading = true;
    element.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserCommandsService.FormData = element;
    this.Sys_UserCommandsService.SaveAsync().subscribe(
      res => {
        this.Sys_UserCommandsService.FormData = res as Sys_UserCommands;
        this.Sys_UserCommandsSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }
  Sys_UserGroupsSearch() {
    this.Sys_UserGroupsService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserGroupsService.GetByUser_Id_SearchStringAndEmptyToListAsync().subscribe(
      res => {
        this.Sys_UserGroupsService.List = (res as Sys_UserGroups[]).sort((a, b) => (a.Group_Id > b.Group_Id ? 1 : -1));
        this.Sys_UserGroupsService.DataSource = new MatTableDataSource(this.Sys_UserGroupsService.List);
        this.Sys_UserGroupsService.DataSource.sort = this.Sys_UserGroupsSort;
        this.Sys_UserGroupsService.DataSource.paginator = this.Sys_UserGroupsPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_UserGroupsSave(element: Sys_UserGroups) {
    this.Sys_UsersService.IsShowLoading = true;
    element.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserGroupsService.FormData = element;
    this.Sys_UserGroupsService.SaveAsync().subscribe(
      res => {
        this.Sys_UserGroupsService.FormData = res as Sys_UserGroups;
        this.Sys_UserGroupsSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }
  Sys_UserMenusSearch() {
    this.Sys_UserMenusService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserMenusService.GetByUser_Id_SearchStringAndEmptyToListAsync().subscribe(
      res => {
        this.Sys_UserMenusService.List = (res as Sys_UserMenus[]).sort((a, b) => (a.Menu_Id > b.Menu_Id ? 1 : -1));
        this.Sys_UserMenusService.DataSource = new MatTableDataSource(this.Sys_UserMenusService.List);
        this.Sys_UserMenusService.DataSource.sort = this.Sys_UserMenusSort;
        this.Sys_UserMenusService.DataSource.paginator = this.Sys_UserMenusPaginator;
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_UserMenusSave(element: Sys_UserMenus) {
    this.Sys_UsersService.IsShowLoading = true;
    element.User_Id = this.Sys_UsersService.FormData.User_Id;
    this.Sys_UserMenusService.FormData = element;
    this.Sys_UserMenusService.SaveAsync().subscribe(
      res => {
        this.Sys_UserMenusService.FormData = res as Sys_UserMenus;
        this.Sys_UserMenusSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }
  Sys_UserPasswordHistorySearch() {
    if (this.Sys_UserPasswordHistoryService.BaseParameter.SearchString.length > 0) {
      this.Sys_UserPasswordHistoryService.BaseParameter.SearchString = this.Sys_UserPasswordHistoryService.BaseParameter.SearchString.trim();
      if (this.Sys_UserPasswordHistoryService.DataSource) {
        this.Sys_UserPasswordHistoryService.DataSource.filter = this.Sys_UserPasswordHistoryService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Sys_UserPasswordHistoryService.BaseParameter.User_Id = this.Sys_UsersService.FormData.User_Id;
      this.Sys_UserPasswordHistoryService.GetByUser_IdToListAsync().subscribe(
        res => {
          this.Sys_UserPasswordHistoryService.List = (res as Sys_UserPasswordHistory[]).sort((a, b) => (a.ChangedDate > b.ChangedDate ? 1 : -1));
          this.Sys_UserPasswordHistoryService.DataSource = new MatTableDataSource(this.Sys_UserPasswordHistoryService.List);
          this.Sys_UserPasswordHistoryService.DataSource.sort = this.Sys_UserPasswordHistorySort;
          this.Sys_UserPasswordHistoryService.DataSource.paginator = this.Sys_UserPasswordHistoryPaginator;
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  Sys_UsersSearch() {
    this.Sys_UsersService.IsShowLoading = true;
    this.Sys_UsersService.GetByUser_IdAsync().subscribe(
      res => {
        this.Sys_UsersService.FormData = res as Sys_Users;
        if (this.Sys_UsersService.FormData.User_Id == environment.InitializationNumber) {
        }
        this.Sys_MenusSearch();
        this.Sys_GroupsSearch();
        this.Sys_FunctionsSearch();
        this.Sys_CommandsSearch();

        this.Sys_UserPasswordHistorySearch();
        //this.Sys_UserMenusSearch();
        //this.Sys_UserGroupsSearch();
        //this.Sys_UserCommandsSearch();
        this.Sys_AppPrivateSettingsSearch001();
      },
      err => {
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }
  Sys_UsersSave() {
    this.Sys_UsersService.IsShowLoading = true;
    this.Sys_UsersService.SaveAsync().subscribe(
      res => {
        this.Sys_UsersService.FormData = res as Sys_Users;
        this.Router.navigateByUrl(environment.SysUsersInfo + this.Sys_UsersService.FormData.User_Id);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Sys_UsersService.IsShowLoading = false;
      }
    );
  }


}