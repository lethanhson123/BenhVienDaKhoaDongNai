import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DatabaseLog } from './DatabaseLog.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DatabaseLogService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DatabaseLogID', 'PostTime', 'DatabaseUser', 'Event', 'Schema', 'Object', 'TSQL', 'XmlEvent'];

    List: DatabaseLog[] | undefined;
    ListFilter: DatabaseLog[] | undefined;
    FormData!: DatabaseLog;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DatabaseLog";
    }
}

