import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_ModifySource_Server } from './Sys_ModifySource_Server.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ModifySource_ServerService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'DateUpdate', 'VersionNo', 'FileName', 'PathName', 'Size', 'ModifyDate'];

    List: Sys_ModifySource_Server[] | undefined;
    ListFilter: Sys_ModifySource_Server[] | undefined;
    FormData!: Sys_ModifySource_Server;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_ModifySource_Server";
    }
}

