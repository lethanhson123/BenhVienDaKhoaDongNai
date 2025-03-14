import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { trace } from './trace.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class traceService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'RowNumber', 'EventClass', 'TextData', 'ApplicationName', 'NTUserName', 'LoginName', 'CPU', 'Reads', 'Writes', 'Duration', 'ClientProcessID', 'SPID', 'StartTime', 'EndTime', 'BinaryData'];

    List: trace[] | undefined;
    ListFilter: trace[] | undefined;
    FormData!: trace;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "trace";
    }
}

