import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_CHUCDANH_ } from './NS_DM_CHUCDANH_.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_CHUCDANH_Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaChucDanh', 'TenChucDanh'];

    List: NS_DM_CHUCDANH_[] | undefined;
    ListFilter: NS_DM_CHUCDANH_[] | undefined;
    FormData!: NS_DM_CHUCDANH_;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_CHUCDANH_";
    }
}

