import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_Operators } from './Sys_Operators.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_OperatorsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Operator_Id', 'GroupCode', 'OperatorCode', 'Language_Id', 'OperatorName', 'Idx', 'SetDefaultForSystemType', 'ApplyForSystemType', 'Description', 'Enabled'];

    List: Sys_Operators[] | undefined;
    ListFilter: Sys_Operators[] | undefined;
    FormData!: Sys_Operators;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_Operators";
    }
}

