import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TRINHDOCHUYENMON_ } from './NS_DM_TRINHDOCHUYENMON_.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TRINHDOCHUYENMON_Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaTDChuyenMon', 'TenTDChuyenMon'];

    List: NS_DM_TRINHDOCHUYENMON_[] | undefined;
    ListFilter: NS_DM_TRINHDOCHUYENMON_[] | undefined;
    FormData!: NS_DM_TRINHDOCHUYENMON_;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TRINHDOCHUYENMON_";
    }
}

