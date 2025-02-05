import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_NHOM } from './NS_DM_NHOM.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_NHOMService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNhom', 'TenNhom', 'MaPhongBan'];

    List: NS_DM_NHOM[] | undefined;
    ListFilter: NS_DM_NHOM[] | undefined;
    FormData!: NS_DM_NHOM;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_NHOM";
    }
}

