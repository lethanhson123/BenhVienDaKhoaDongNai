import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_DSOperator } from './NS_RP_DSOperator.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_DSOperatorService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'OperatorCode', 'OperatorName', 'Type'];

    List: NS_RP_DSOperator[] | undefined;
    ListFilter: NS_RP_DSOperator[] | undefined;
    FormData!: NS_RP_DSOperator;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_DSOperator";
    }
}

