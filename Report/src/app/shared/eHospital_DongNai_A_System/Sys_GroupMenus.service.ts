﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_GroupMenus } from './Sys_GroupMenus.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_GroupMenusService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Group_Id', 'Menu_Id'];

    List: Sys_GroupMenus[] | undefined;
    ListFilter: Sys_GroupMenus[] | undefined;
    FormData!: Sys_GroupMenus;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_GroupMenus";
    }
    GetByGroup_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByGroup_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

