﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_DM_Duoc_20210922 } from './zzz_DM_Duoc_20210922.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_DM_Duoc_20210922Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_id', 'MaDuoc', 'TenHang', 'TenDuocDayDu', 'TenDuocDayDu_KhongDau'];

    List: zzz_DM_Duoc_20210922[] | undefined;
    ListFilter: zzz_DM_Duoc_20210922[] | undefined;
    FormData!: zzz_DM_Duoc_20210922;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_DM_Duoc_20210922";
    }
}

