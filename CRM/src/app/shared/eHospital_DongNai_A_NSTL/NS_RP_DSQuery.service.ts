import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_DSQuery } from './NS_RP_DSQuery.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_DSQueryService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'Clause'];

    List: NS_RP_DSQuery[] | undefined;
    ListFilter: NS_RP_DSQuery[] | undefined;
    FormData!: NS_RP_DSQuery;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_DSQuery";
    }
}

