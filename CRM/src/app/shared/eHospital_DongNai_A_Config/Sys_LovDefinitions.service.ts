import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_LovDefinitions } from './Sys_LovDefinitions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_LovDefinitionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LovDefinition_Id', 'DataGroup', 'Language_Id', 'FormName', 'ControlName', 'OtherKey', 'ProcedureName', 'Enabled', 'AllowMultiResult', 'LostFocusIfOK', 'ControlNameDesc', 'ColumnHeader', 'ColumnHeaderVisible', 'Description', 'UseDefaultSort', 'LovUseSystemFunction', 'AllowFilterData', 'AllowGroupData', 'DefaultFilterColumn', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5'];

    List: Sys_LovDefinitions[] | undefined;
    ListFilter: Sys_LovDefinitions[] | undefined;
    FormData!: Sys_LovDefinitions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_LovDefinitions";
    }
}

