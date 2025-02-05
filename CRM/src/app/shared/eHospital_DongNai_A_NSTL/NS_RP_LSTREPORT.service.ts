import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_LSTREPORT } from './NS_RP_LSTREPORT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_LSTREPORTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'REPORTCODE', 'REPORTTITLE', 'REPORTFILENAME', 'PACKAGENAME', 'PROCEDURENAME', 'PACKAGENAME_ORIGIN_DATA', 'TableMapping', 'REPORTTYPE', 'Sort'];

    List: NS_RP_LSTREPORT[] | undefined;
    ListFilter: NS_RP_LSTREPORT[] | undefined;
    FormData!: NS_RP_LSTREPORT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_LSTREPORT";
    }
}

