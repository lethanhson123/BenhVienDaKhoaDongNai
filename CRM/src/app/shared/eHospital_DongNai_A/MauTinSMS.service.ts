import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MauTinSMS } from './MauTinSMS.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class MauTinSMSService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MauTin_Id', 'TenMauTin', 'NoiDung', 'TinSMS_LoaiTinId', 'MaMauTin', 'LoaiLichHen_Id'];

    List: MauTinSMS[] | undefined;
    ListFilter: MauTinSMS[] | undefined;
    FormData!: MauTinSMS;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "MauTinSMS";
    }
}

