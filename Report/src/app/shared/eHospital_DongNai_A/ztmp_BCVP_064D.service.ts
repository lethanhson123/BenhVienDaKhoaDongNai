import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCVP_064D } from './ztmp_BCVP_064D.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCVP_064DService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoHoaDonVAT', 'TenBenhNhan', 'SoVaoVien', 'NgayHoaDon', 'GiaTriHoaDon', 'GiaTriHuy', 'GiaTriHoanTra', 'GhiChu', 'HuyHoaDon', 'HoanTra', 'Loai', 'nhanvienthutien', 'Date01', 'Date02', 'NguoiThuTien'];

    List: ztmp_BCVP_064D[] | undefined;
    ListFilter: ztmp_BCVP_064D[] | undefined;
    FormData!: ztmp_BCVP_064D;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCVP_064D";
    }
}

