﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_AppSettings } from './Sys_AppSettings.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_AppSettingsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Setting_Id', 'Code', 'Language_Id', 'Value', 'Description', 'Locked', 'SystemEditOnly', 'CreationDate', 'CreatedBy', 'LastUpdateDate', 'LastUpdatedBy'];
    DisplayColumns002: string[] = ['Save', 'STT', 'Setting_Id', 'Code', 'Language_Id', 'Value', 'Description'];
    List: Sys_AppSettings[] | undefined;
    ListFilter: Sys_AppSettings[] | undefined;
    FormData!: Sys_AppSettings;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_AppSettings";
    }
    KhoiPhucAsync() {
        let url = this.APIURL + this.Controller + '/KhoiPhucAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

