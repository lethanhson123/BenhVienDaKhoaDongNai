import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_HistoryDefines } from './Sys_HistoryDefines.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_HistoryDefinesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HistoryDefine_Id', 'DataGroup', 'TableName', 'Insert_Enabled', 'Update_Enabled', 'Delete_Enabled', 'Description'];

    List: Sys_HistoryDefines[] | undefined;
    ListFilter: Sys_HistoryDefines[] | undefined;
    FormData!: Sys_HistoryDefines;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_HistoryDefines";
    }
}

