import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_TongKet_PhauThuat } from './BenhAnTongQuat_TongKet_PhauThuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_TongKet_PhauThuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'ThoiGian', 'PhuongPhap_Id', 'BacSiPhauThuat_Id', 'BacSiGayMe_Id'];

    List: BenhAnTongQuat_TongKet_PhauThuat[] | undefined;
    ListFilter: BenhAnTongQuat_TongKet_PhauThuat[] | undefined;
    FormData!: BenhAnTongQuat_TongKet_PhauThuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_TongKet_PhauThuat";
    }
}

