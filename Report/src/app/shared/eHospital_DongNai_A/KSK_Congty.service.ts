import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_Congty } from './KSK_Congty.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_CongtyService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Congty_Id', 'MaCongty', 'TenCongty', 'TenCongty_En', 'TenCongty_Ru', 'DiaChi', 'DienThoai', 'Fax', 'Email', 'MaSoThue', 'GiamDoc', 'NguoiLienHe', 'NuocNgoai', 'NhaNuoc', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'HeSo'];

    List: KSK_Congty[] | undefined;
    ListFilter: KSK_Congty[] | undefined;
    FormData!: KSK_Congty;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_Congty";
    }
}

