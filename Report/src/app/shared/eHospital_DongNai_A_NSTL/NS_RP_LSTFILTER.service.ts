import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_LSTFILTER } from './NS_RP_LSTFILTER.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_LSTFILTERService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'FILTER', 'PARAMETER', 'CAPTION', 'DEFAULTVALUE', 'CRLF', 'TYPE_DATA', 'TABLECHECK', 'PARAMETERTYPE', 'PARAMETERNAME', 'REPORTFORMULAR', 'STOREPARAMETER', 'READONLY', 'SETNAMELABEL'];

    List: NS_RP_LSTFILTER[] | undefined;
    ListFilter: NS_RP_LSTFILTER[] | undefined;
    FormData!: NS_RP_LSTFILTER;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_LSTFILTER";
    }
}

