import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_DSTable } from './NS_RP_DSTable.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_DSTableService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'Vietnamese', 'SapXep'];

    List: NS_RP_DSTable[] | undefined;
    ListFilter: NS_RP_DSTable[] | undefined;
    FormData!: NS_RP_DSTable;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_DSTable";
    }
}

