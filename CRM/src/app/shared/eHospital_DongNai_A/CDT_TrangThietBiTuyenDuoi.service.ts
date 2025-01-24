import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_TrangThietBiTuyenDuoi } from './CDT_TrangThietBiTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_TrangThietBiTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_TrangThietBi_Id', 'ThietBi_Id', 'BenhVien_Id', 'TinhTrang_Id', 'NgayQuanLy', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'GhiChu'];

    List: CDT_TrangThietBiTuyenDuoi[] | undefined;
    ListFilter: CDT_TrangThietBiTuyenDuoi[] | undefined;
    FormData!: CDT_TrangThietBiTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_TrangThietBiTuyenDuoi";
    }
}

