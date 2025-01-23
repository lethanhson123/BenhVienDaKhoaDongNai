import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Sys_Functions } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.model';
import { Sys_FunctionsService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Functions.service';
import { Sys_Modules } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Modules.model';
import { Sys_ModulesService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Modules.service';

@Component({
  selector: 'app-sys-functions',
  templateUrl: './sys-functions.component.html',
  styleUrls: ['./sys-functions.component.css']
})
export class SysFunctionsComponent implements OnInit {

  @ViewChild('Sys_FunctionsSort') Sys_FunctionsSort: MatSort;
  @ViewChild('Sys_FunctionsPaginator') Sys_FunctionsPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Sys_FunctionsService: Sys_FunctionsService,
    public Sys_ModulesService: Sys_ModulesService,
  ) { }

  ngOnInit(): void {
    this.Sys_GroupsSearch();
  }
  Sys_GroupsFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.Sys_ModulesService.ListFilter = this.Sys_ModulesService.ListAll.filter(item => item.Module_Name.toLocaleLowerCase().indexOf(searchString) !== -1 || item.Module_Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.Sys_ModulesService.ListFilter = this.Sys_ModulesService.ListAll;
    }
  }
  Sys_GroupsSearch() {
    this.Sys_ModulesService.GetAllToListAsync().subscribe(
      res => {
        this.Sys_ModulesService.ListAll = (res as Sys_Modules[]).sort((a, b) => (a.Module_Name > b.Module_Name ? 1 : -1));
        this.Sys_ModulesService.ListFilter = this.Sys_ModulesService.ListAll;
        this.Sys_FunctionsSearch();
      },
      err => {
      },
      () => {
      }
    );
  }
  Sys_FunctionsSearch() {
    this.Sys_FunctionsService.SearchAll(this.Sys_FunctionsSort, this.Sys_FunctionsPaginator);
  }
  Sys_FunctionsSave(element: Sys_Functions) {
    this.Sys_FunctionsService.FormData = element;
    this.NotificationService.warn(this.Sys_FunctionsService.ComponentSaveAll(this.Sys_FunctionsSort, this.Sys_FunctionsPaginator));
  }
  Sys_FunctionsDelete(element: Sys_Functions) {
    this.Sys_FunctionsService.FormData = element;
    this.NotificationService.warn(this.Sys_FunctionsService.ComponentDeleteAll(this.Sys_FunctionsSort, this.Sys_FunctionsPaginator));
  }
}
