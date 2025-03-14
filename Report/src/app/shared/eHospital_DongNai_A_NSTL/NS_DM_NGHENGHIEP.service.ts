import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_NGHENGHIEP } from './NS_DM_NGHENGHIEP.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_NGHENGHIEPService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNgheNghiep', 'TenNgheNghiep'];

    List: NS_DM_NGHENGHIEP[] | undefined;
    ListFilter: NS_DM_NGHENGHIEP[] | undefined;
    FormData!: NS_DM_NGHENGHIEP;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_NGHENGHIEP";
    }
}

