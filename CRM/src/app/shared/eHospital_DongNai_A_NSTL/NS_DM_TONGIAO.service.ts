import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TONGIAO } from './NS_DM_TONGIAO.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TONGIAOService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaTonGiao', 'TenTonGiao'];

    List: NS_DM_TONGIAO[] | undefined;
    ListFilter: NS_DM_TONGIAO[] | undefined;
    FormData!: NS_DM_TONGIAO;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TONGIAO";
    }
}

