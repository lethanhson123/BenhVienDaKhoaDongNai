import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_QUANHUYEN } from './NS_DM_QUANHUYEN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_QUANHUYENService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaQuanHuyen', 'TenQuanHuyen', 'MaTinh', 'DangSuDung'];

    List: NS_DM_QUANHUYEN[] | undefined;
    ListFilter: NS_DM_QUANHUYEN[] | undefined;
    FormData!: NS_DM_QUANHUYEN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_QUANHUYEN";
    }
}

