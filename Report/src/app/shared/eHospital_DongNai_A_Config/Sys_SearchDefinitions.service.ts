import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_SearchDefinitions } from './Sys_SearchDefinitions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_SearchDefinitionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'DataGroup', 'DataGroup_Name', 'FieldName', 'AlternateFieldName', 'Description', 'Idx', 'DataType', 'Remark', 'Enabled', 'IsSearch'];

    List: Sys_SearchDefinitions[] | undefined;
    ListFilter: Sys_SearchDefinitions[] | undefined;
    FormData!: Sys_SearchDefinitions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_SearchDefinitions";
    }
}

