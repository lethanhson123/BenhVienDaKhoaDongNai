import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_VTYT_Mod_20210922_1000 } from './zzz_VTYT_Mod_20210922_1000.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_VTYT_Mod_20210922_1000Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaDuoc', 'TenCu', 'TenDung', 'TenDuocDayDu', 'KhongDau', 'KhongDau2', 'STT'];

    List: zzz_VTYT_Mod_20210922_1000[] | undefined;
    ListFilter: zzz_VTYT_Mod_20210922_1000[] | undefined;
    FormData!: zzz_VTYT_Mod_20210922_1000;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_VTYT_Mod_20210922_1000";
    }
}

