import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TinSMS } from './TinSMS.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TinSMSService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TinSMS_Id', 'BenhNhan_Id', 'SoDienThoai', 'NoiDungSMS', 'ThoiGianTuDongGui', 'MauTin_Id', 'DaGui', 'ThoiGianGui', 'NguoiGui_Id', 'TinSMS_LoaiTinId', 'ThongTinId', 'ThoiGianCapNhat', 'SMSGUID'];

    List: TinSMS[] | undefined;
    ListFilter: TinSMS[] | undefined;
    FormData!: TinSMS;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TinSMS";
    }
}

