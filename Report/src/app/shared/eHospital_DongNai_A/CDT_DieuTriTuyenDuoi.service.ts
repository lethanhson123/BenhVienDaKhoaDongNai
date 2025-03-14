import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_DieuTriTuyenDuoi } from './CDT_DieuTriTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_DieuTriTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_DieuTri_Id', 'BenhVien_Id', 'ThoiGianKham', 'SoCaKham', 'SoCaICD', 'SoCaNgoaiTru', 'SoCaNoiTru', 'SoCaChuyenVien', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'MaICD', 'SoCaPhauThuat', 'SoCaThuThuat', 'SoCaTuVong', 'GhiChu'];

    List: CDT_DieuTriTuyenDuoi[] | undefined;
    ListFilter: CDT_DieuTriTuyenDuoi[] | undefined;
    FormData!: CDT_DieuTriTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_DieuTriTuyenDuoi";
    }
}

