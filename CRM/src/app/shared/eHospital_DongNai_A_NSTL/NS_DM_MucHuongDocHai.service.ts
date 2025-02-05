import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_MucHuongDocHai } from './NS_DM_MucHuongDocHai.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_MucHuongDocHaiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaMucHuongDocHai', 'DonGiaHuong', 'GhiChu'];

    List: NS_DM_MucHuongDocHai[] | undefined;
    ListFilter: NS_DM_MucHuongDocHai[] | undefined;
    FormData!: NS_DM_MucHuongDocHai;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_MucHuongDocHai";
    }
}

