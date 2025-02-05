import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_LSTSUBREPORT } from './NS_RP_LSTSUBREPORT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_LSTSUBREPORTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'REPORTCODE', 'IDX', 'REPORTFILENAME', 'PROCEDURENAME', 'TableMapping'];

    List: NS_RP_LSTSUBREPORT[] | undefined;
    ListFilter: NS_RP_LSTSUBREPORT[] | undefined;
    FormData!: NS_RP_LSTSUBREPORT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_LSTSUBREPORT";
    }
}

