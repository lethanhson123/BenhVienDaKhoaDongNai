import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ICD_Common } from './DM_ICD_Common.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ICD_CommonService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ICD_Common_Id', 'BacSi_Id', 'ICD_Id'];

    List: DM_ICD_Common[] | undefined;
    ListFilter: DM_ICD_Common[] | undefined;
    FormData!: DM_ICD_Common;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ICD_Common";
    }
}

