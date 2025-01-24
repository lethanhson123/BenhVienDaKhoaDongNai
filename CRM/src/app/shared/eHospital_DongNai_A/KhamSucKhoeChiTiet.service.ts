import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamSucKhoeChiTiet } from './KhamSucKhoeChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamSucKhoeChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamSucKhoeChiTiet_Id', 'KhamSucKhoe_Id', 'KhamBenh_Id', 'NoiDung_Id', 'ICD_Id', 'Benh', 'KetQua', 'GhiChu', 'PhongBan_Id', 'BacSi_Id'];

    List: KhamSucKhoeChiTiet[] | undefined;
    ListFilter: KhamSucKhoeChiTiet[] | undefined;
    FormData!: KhamSucKhoeChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamSucKhoeChiTiet";
    }
}

