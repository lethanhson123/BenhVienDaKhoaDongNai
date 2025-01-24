import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaKhangSinhDo_His } from './CLSKetQuaKhangSinhDo_His.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaKhangSinhDo_HisService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KetQuaKhangSinhDo_Id', 'CLSKetQua_Id', 'KhangSinhDo_Id', 'NhomKhangSinhDo_Id', 'TenNguonXetNghiem', 'KetQua', 'KhangSinhDo', 'LanCapNhat', 'ThoiGianCapNhat', 'NguoiCapNhat_Id', 'InstrMIC', 'FinalSIR', 'Rules'];

    List: CLSKetQuaKhangSinhDo_His[] | undefined;
    ListFilter: CLSKetQuaKhangSinhDo_His[] | undefined;
    FormData!: CLSKetQuaKhangSinhDo_His;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaKhangSinhDo_His";
    }
}

