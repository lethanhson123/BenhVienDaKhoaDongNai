import { Injectable, ViewChild } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { Base } from 'src/app/shared/Base.model';
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
    APIURL: string = environment.APIURL;
    Controller: string = "Base";
    Headers: HttpHeaders = new HttpHeaders();


    constructor(
        public httpClient: HttpClient
    ) {
        this.FormData = {
        };
        this.BaseParameter = {
            SearchString: environment.InitializationString,
            BatDau: new Date(new Date().getFullYear(), new Date().getMonth(), 1),
            KetThuc: new Date(),
            Nam: new Date().getFullYear(),
            Thang: new Date().getMonth() + 1,
            ListID:[],
            DanhMucQuayDichVuID: environment.InitializationNumber,
            DanhMucDichVuID: environment.InitializationNumber,
        };        
        this.List = [];
        this.ListFilter = [];

        let token = localStorage.getItem(environment.Token);
        this.Headers = this.Headers.append('Authorization', 'Bearer ' + token);
    }    
    GetByIDAsync() {
        let url = this.APIURL + this.Controller + '/GetByIDAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

