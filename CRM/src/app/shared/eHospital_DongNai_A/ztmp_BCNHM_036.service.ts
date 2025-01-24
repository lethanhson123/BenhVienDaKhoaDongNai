import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCNHM_036 } from './ztmp_BCNHM_036.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCNHM_036Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenKhoa', 'TenBenhNhan', 'GS', 'RH', 'LoaiSPMau', 'MaTuiMau', 'Str1', 'num1', 'num2', 'num3'];

    List: ztmp_BCNHM_036[] | undefined;
    ListFilter: ztmp_BCNHM_036[] | undefined;
    FormData!: ztmp_BCNHM_036;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCNHM_036";
    }
}

