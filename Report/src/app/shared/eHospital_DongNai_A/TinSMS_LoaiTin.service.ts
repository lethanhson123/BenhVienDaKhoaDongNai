import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TinSMS_LoaiTin } from './TinSMS_LoaiTin.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TinSMS_LoaiTinService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TinSMS_LoaiTinId', 'TenLoai', 'TenBang', 'GhiChu'];

    List: TinSMS_LoaiTin[] | undefined;
    ListFilter: TinSMS_LoaiTin[] | undefined;
    FormData!: TinSMS_LoaiTin;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TinSMS_LoaiTin";
    }
}

