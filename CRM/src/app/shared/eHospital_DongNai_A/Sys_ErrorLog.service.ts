import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_ErrorLog } from './Sys_ErrorLog.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ErrorLogService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ErrorLogID', 'ErrorTime', 'UserName', 'ErrorNumber', 'ErrorSeverity', 'ErrorState', 'ErrorProcedure', 'ErrorLine', 'ErrorMessage'];

    List: Sys_ErrorLog[] | undefined;
    ListFilter: Sys_ErrorLog[] | undefined;
    FormData!: Sys_ErrorLog;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_ErrorLog";
    }
}

