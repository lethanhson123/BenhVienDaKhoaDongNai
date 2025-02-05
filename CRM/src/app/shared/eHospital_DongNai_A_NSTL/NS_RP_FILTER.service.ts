import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_FILTER } from './NS_RP_FILTER.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_FILTERService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'REPORTCODE', 'IDX', 'FILTER', 'DEFAULTVALUE', 'ISNOTNULL'];

    List: NS_RP_FILTER[] | undefined;
    ListFilter: NS_RP_FILTER[] | undefined;
    FormData!: NS_RP_FILTER;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_FILTER";
    }
}

