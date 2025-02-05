import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_FORMULARS } from './NS_RP_FORMULARS.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_FORMULARSService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'REPORTCODE', 'NAME', 'CONTROLNAME', 'VALUE'];

    List: NS_RP_FORMULARS[] | undefined;
    ListFilter: NS_RP_FORMULARS[] | undefined;
    FormData!: NS_RP_FORMULARS;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_FORMULARS";
    }
}

