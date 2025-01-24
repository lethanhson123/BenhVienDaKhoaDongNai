import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzPhongBan } from './zzzPhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzPhongBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_Id', 'TenPhongBan', 'TenPhongBan_En'];

    List: zzzPhongBan[] | undefined;
    ListFilter: zzzPhongBan[] | undefined;
    FormData!: zzzPhongBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzPhongBan";
    }
}

