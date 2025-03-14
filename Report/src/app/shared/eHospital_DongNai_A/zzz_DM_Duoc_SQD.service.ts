import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_DM_Duoc_SQD } from './zzz_DM_Duoc_SQD.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_DM_Duoc_SQDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_id', 'MaDuoc', 'SQD'];

    List: zzz_DM_Duoc_SQD[] | undefined;
    ListFilter: zzz_DM_Duoc_SQD[] | undefined;
    FormData!: zzz_DM_Duoc_SQD;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_DM_Duoc_SQD";
    }
}

