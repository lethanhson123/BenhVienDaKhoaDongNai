import { Injectable, ViewChild } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { Base } from './Base.model';
import { BaseParameter } from './BaseParameter.model';
@Injectable({
    providedIn: 'root'
})
export class BaseService {

    DataSource: MatTableDataSource<any>;
    DataSourceFilter: MatTableDataSource<any>;
    DisplayColumns: string[] = ['STT', 'ID', 'Name', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumns01: string[] = ['STT', 'ID', 'Name', 'Code', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumnsMobile: string[] = ['STT'];
    List: Base[] | undefined;
    ListFilter: Base[] | undefined;
    FormData!: Base;
    File: File;
    FileToUpload: FileList
    BaseParameter!: BaseParameter;
    IsShowLoading: boolean = false;
    APIURL: string = environment.APIReportURL;
    Controller: string = "Base";
    Headers: HttpHeaders = new HttpHeaders();


    ListTemporary: Base[] | undefined;
    FormTemporary!: Base;

    constructor(
        public httpClient: HttpClient
    ) {
        this.FormData = {
        };       
        this.BaseParameter = {
            SearchString: environment.InitializationString, 
            BatDau: new Date(),
            KetThuc: new Date(),         
            Year: new Date().getFullYear(),
            Month: new Date().getMonth()+1,
            Day: new Date().getDate(),
        };        
        this.List = [];
        this.ListFilter = [];        
        let token = localStorage.getItem(environment.Token);
        this.Headers = this.Headers.append('Authorization', 'Bearer ' + token);

        this.FormTemporary = {
        };
        this.ListTemporary = [];
    }  

}

