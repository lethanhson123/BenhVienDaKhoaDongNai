import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_ComboDefinitions } from './Sys_ComboDefinitions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ComboDefinitionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ComboDefinition_Id', 'ComboDefinition_Code', 'Language_Id', 'Description', 'ColumnHeader', 'AddBlankItem', 'ColumnHeaderVisible', 'ProcedureName', 'DefaultValue', 'DefaultValueName', 'UseDefaultSort', 'LovEnabled', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5'];

    List: Sys_ComboDefinitions[] | undefined;
    ListFilter: Sys_ComboDefinitions[] | undefined;
    FormData!: Sys_ComboDefinitions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_ComboDefinitions";
    }
}

