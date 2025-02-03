import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_AppPrivateSettings } from './Sys_AppPrivateSettings.model';
import { BaseService } from './Base.service';

import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

@Injectable({
    providedIn: 'root'
})
export class Sys_AppPrivateSettingsService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'Setting_Id', 'Group_Code', 'Code', 'User_Id', 'Computer', 'Value', 'Description', 'CreationDate', 'CreatedBy', 'LastUpdateDate', 'LastUpdatedBy'];
    DisplayColumns002: string[] = ['Save', 'STT', 'Setting_Id', 'Code', 'Computer', 'CreationDate', 'CreatedBy', 'LastUpdateDate', 'LastUpdatedBy'];

    List: Sys_AppPrivateSettings[] | undefined;
    ListFilter: Sys_AppPrivateSettings[] | undefined;
    FormData!: Sys_AppPrivateSettings;

    List001: Sys_AppPrivateSettings[] | undefined;
    List002: Sys_AppPrivateSettings[] | undefined;
    List003: Sys_AppPrivateSettings[] | undefined;

    DataSource001: MatTableDataSource<any>;
    DataSource002: MatTableDataSource<any>;
    DataSource003: MatTableDataSource<any>;
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_AppPrivateSettings";
    }
    GetByUser_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_IdAndCodeAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdAndCodeAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }

}

