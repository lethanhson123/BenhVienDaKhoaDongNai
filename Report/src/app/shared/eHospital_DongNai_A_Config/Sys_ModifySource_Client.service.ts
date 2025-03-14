import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_ModifySource_Client } from './Sys_ModifySource_Client.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ModifySource_ClientService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'DateUpdate', 'VersionNo', 'ComputerName', 'FileName', 'PathName', 'Size', 'ModifyDate'];

    List: Sys_ModifySource_Client[] | undefined;
    ListFilter: Sys_ModifySource_Client[] | undefined;
    FormData!: Sys_ModifySource_Client;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_ModifySource_Client";
    }
}

