import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_Configs } from './Sys_Configs.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ConfigsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Config_Id', 'Config_Code', 'Language_Id', 'Config_Type', 'Config_Data', 'Description', 'Table_Name', 'Idx', 'Parent_Id', 'User_Id', 'Group_Id', 'Attribute1', 'Attribute2', 'Attribute3'];

    List: Sys_Configs[] | undefined;
    ListFilter: Sys_Configs[] | undefined;
    FormData!: Sys_Configs;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_Configs";
    }
}

