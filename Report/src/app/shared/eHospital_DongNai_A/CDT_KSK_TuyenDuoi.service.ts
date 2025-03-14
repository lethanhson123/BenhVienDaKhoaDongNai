import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KSK_TuyenDuoi } from './CDT_KSK_TuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KSK_TuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_TuyenDuoi_Id', 'BenhVien_Id', 'MaDotKSK', 'TenDotKSK', 'TuNgay', 'DenNgay', 'DiaDiem', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KSK_TuyenDuoi[] | undefined;
    ListFilter: CDT_KSK_TuyenDuoi[] | undefined;
    FormData!: CDT_KSK_TuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KSK_TuyenDuoi";
    }
}

