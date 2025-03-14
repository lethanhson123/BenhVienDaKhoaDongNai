import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_QUANHE } from './NS_DM_QUANHE.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_QUANHEService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaQuanHe', 'TenQuanHe'];

    List: NS_DM_QUANHE[] | undefined;
    ListFilter: NS_DM_QUANHE[] | undefined;
    FormData!: NS_DM_QUANHE;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_QUANHE";
    }
}

