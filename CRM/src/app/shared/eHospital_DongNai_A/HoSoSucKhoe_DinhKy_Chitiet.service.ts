import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe_DinhKy_Chitiet } from './HoSoSucKhoe_DinhKy_Chitiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoe_DinhKy_ChitietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'HoSoSucKhoe_DinhKy_ID', 'KhamBenh_Id', 'NoiDungKham_ID', 'KetQua', 'Benh', 'ICD_ID', 'BacSiKetLuan_ID', 'XepLoai_ID', 'PhongBan_ID', 'GhiChu'];

    List: HoSoSucKhoe_DinhKy_Chitiet[] | undefined;
    ListFilter: HoSoSucKhoe_DinhKy_Chitiet[] | undefined;
    FormData!: HoSoSucKhoe_DinhKy_Chitiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe_DinhKy_Chitiet";
    }
}

