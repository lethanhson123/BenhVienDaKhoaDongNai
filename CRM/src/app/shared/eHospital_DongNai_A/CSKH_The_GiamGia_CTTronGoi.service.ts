import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_GiamGia_CTTronGoi } from './CSKH_The_GiamGia_CTTronGoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_GiamGia_CTTronGoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_GiamGia_CTTronGoi_Id', 'The_Id', 'LoaiKhachHang_Id', 'TyLe', 'CTTronGoi_Id', 'ThoiGianMin', 'ThoiGianMax', 'TatCaChuongTrinh', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_GiamGia_CTTronGoi[] | undefined;
    ListFilter: CSKH_The_GiamGia_CTTronGoi[] | undefined;
    FormData!: CSKH_The_GiamGia_CTTronGoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_GiamGia_CTTronGoi";
    }
}

