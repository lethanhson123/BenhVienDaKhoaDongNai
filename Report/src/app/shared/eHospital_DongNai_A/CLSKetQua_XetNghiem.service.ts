import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQua_XetNghiem } from './CLSKetQua_XetNghiem.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQua_XetNghiemService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQua_XetNghiem_Id', 'CLSKetQua_ID', 'SoPhieu', 'CLSYeuCau_ID', 'GhiChu', 'CLSYeuCauChiTiet_ID'];

    List: CLSKetQua_XetNghiem[] | undefined;
    ListFilter: CLSKetQua_XetNghiem[] | undefined;
    FormData!: CLSKetQua_XetNghiem;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQua_XetNghiem";
    }
}

