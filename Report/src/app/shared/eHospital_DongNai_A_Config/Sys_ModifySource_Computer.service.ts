import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_ModifySource_Computer } from './Sys_ModifySource_Computer.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ModifySource_ComputerService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'Computer_Name', 'IP', 'Enable', 'Description'];

    List: Sys_ModifySource_Computer[] | undefined;
    ListFilter: Sys_ModifySource_Computer[] | undefined;
    FormData!: Sys_ModifySource_Computer;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_ModifySource_Computer";
    }
}

