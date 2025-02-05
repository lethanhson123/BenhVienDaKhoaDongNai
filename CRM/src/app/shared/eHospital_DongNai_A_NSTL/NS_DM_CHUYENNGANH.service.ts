import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_CHUYENNGANH } from './NS_DM_CHUYENNGANH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_CHUYENNGANHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaChuyenNganh', 'TenChuyenNganh'];

    List: NS_DM_CHUYENNGANH[] | undefined;
    ListFilter: NS_DM_CHUYENNGANH[] | undefined;
    FormData!: NS_DM_CHUYENNGANH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_CHUYENNGANH";
    }
}

