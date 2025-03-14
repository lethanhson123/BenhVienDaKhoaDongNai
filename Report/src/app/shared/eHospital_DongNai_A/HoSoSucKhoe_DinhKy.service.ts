import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe_DinhKy } from './HoSoSucKhoe_DinhKy.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoe_DinhKyService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'HoSoSucKhoe_Id', 'TiepNhan_ID', 'NgayKham', 'ThiLuc', 'HuyetAp', 'ChieuCao', 'CanNang', 'VongNguc', 'Pignet', 'PhanLoaiTheLuc_Id', 'NhanXet', 'KetLuan', 'XepLoai_ID', 'BacSiKetLuan_ID', 'Loai'];

    List: HoSoSucKhoe_DinhKy[] | undefined;
    ListFilter: HoSoSucKhoe_DinhKy[] | undefined;
    FormData!: HoSoSucKhoe_DinhKy;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe_DinhKy";
    }
}

