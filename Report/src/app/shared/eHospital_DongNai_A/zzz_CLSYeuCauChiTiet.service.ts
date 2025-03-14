import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_CLSYeuCauChiTiet } from './zzz_CLSYeuCauChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_CLSYeuCauChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'YeuCauChiTiet_id', 'CLSYeuCau_id', 'TenDichVu'];

    List: zzz_CLSYeuCauChiTiet[] | undefined;
    ListFilter: zzz_CLSYeuCauChiTiet[] | undefined;
    FormData!: zzz_CLSYeuCauChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_CLSYeuCauChiTiet";
    }
}

