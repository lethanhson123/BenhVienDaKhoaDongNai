import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KSK_NgoaiVien } from './CDT_KSK_NgoaiVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KSK_NgoaiVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_NgoaiVien_Id', 'KSK_TuyenDuoi_Id', 'SoCaBenhNhanKham', 'SoCaBenhNhanNam', 'SoCaBenhNhanNu', 'QuanHuyen_Id', 'TinhThanhPho_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KSK_NgoaiVien[] | undefined;
    ListFilter: CDT_KSK_NgoaiVien[] | undefined;
    FormData!: CDT_KSK_NgoaiVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KSK_NgoaiVien";
    }
}

