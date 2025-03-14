import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_CLSYeuCau } from './zzz_CLSYeuCau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_CLSYeuCauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_ID', 'ThoiGianKham', 'NguoiCapNhat_ID', 'BacSiKham_ID', 'BenhAn_ID', 'LuuTru_ID', 'NguoiTao_ID'];

    List: zzz_CLSYeuCau[] | undefined;
    ListFilter: zzz_CLSYeuCau[] | undefined;
    FormData!: zzz_CLSYeuCau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_CLSYeuCau";
    }
}

