import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_BNDangKham } from './KhamBenh_BNDangKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_BNDangKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_BNDangKham', 'BenhNhan_Id', 'PhongBan_Id', 'ThoiGian'];

    List: KhamBenh_BNDangKham[] | undefined;
    ListFilter: KhamBenh_BNDangKham[] | undefined;
    FormData!: KhamBenh_BNDangKham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_BNDangKham";
    }
}

