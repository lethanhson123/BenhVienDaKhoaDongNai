import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_040 } from './ztmp_BCTN_040.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_040Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'DiaChi', 'DoiTuong', 'SoDienThoai', 'NgayTiepNhan', 'PhongBan', 'MaYTe'];

    List: ztmp_BCTN_040[] | undefined;
    ListFilter: ztmp_BCTN_040[] | undefined;
    FormData!: ztmp_BCTN_040;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_040";
    }
}

