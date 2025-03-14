import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The } from './CSKH_The.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_TheService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_Id', 'MaThe', 'MaDKThe', 'TaiKhoan_Id', 'ThanhVien_Id', 'LoaiKhachHang_Id', 'KickHoat', 'TamNgung', 'HopDong_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute_1', 'Attribute_2', 'Attribute_3', 'Attribute_4', 'Attribute_5', 'Attribute_6', 'Attribute_7', 'Attribute_8', 'Phu'];

    List: CSKH_The[] | undefined;
    ListFilter: CSKH_The[] | undefined;
    FormData!: CSKH_The;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The";
    }
}

