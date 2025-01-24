import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCDP_003 } from './ztmp_BCDP_003.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCDP_003Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'TenKho', 'DauKy', 'TongLuongNhap', 'TongLuongXuat'];

    List: ztmp_BCDP_003[] | undefined;
    ListFilter: ztmp_BCDP_003[] | undefined;
    FormData!: ztmp_BCDP_003;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCDP_003";
    }
}

