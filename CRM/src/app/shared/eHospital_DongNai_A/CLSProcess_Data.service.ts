import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSProcess_Data } from './CLSProcess_Data.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSProcess_DataService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SPID', 'CLSYeuCau_Id', 'CLSYeuCauChiTiet_Id'];

    List: CLSProcess_Data[] | undefined;
    ListFilter: CLSProcess_Data[] | undefined;
    FormData!: CLSProcess_Data;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSProcess_Data";
    }
}

