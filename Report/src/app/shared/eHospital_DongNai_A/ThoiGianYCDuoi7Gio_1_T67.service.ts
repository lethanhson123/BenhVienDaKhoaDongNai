import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThoiGianYCDuoi7Gio_1_T67 } from './ThoiGianYCDuoi7Gio_1_T67.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThoiGianYCDuoi7Gio_1_T67Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoTiepNhan', 'TenDichVu', 'CLSYeuCau_Id', 'NoiYeuCau', 'SoVaoVien', 'SoPhieuYeuCau', 'NamYeuCau', 'ThangYeuCau', 'ThoiGianYeuCau', 'ChanDoan', 'KhamBenh_Id', 'ThoiGianKham'];

    List: ThoiGianYCDuoi7Gio_1_T67[] | undefined;
    ListFilter: ThoiGianYCDuoi7Gio_1_T67[] | undefined;
    FormData!: ThoiGianYCDuoi7Gio_1_T67;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThoiGianYCDuoi7Gio_1_T67";
    }
}

