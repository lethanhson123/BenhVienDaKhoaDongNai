import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_TrangThietBiTuyenDuoi } from './DM_TrangThietBiTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_TrangThietBiTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThietBi_Id', 'MaThietBi', 'TenThietBi', 'TamNgung', 'TuoiTho', 'NamSanXuat', 'NhomThietBi_Id', 'PhongBan_Id', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NoiSanXuat'];

    List: DM_TrangThietBiTuyenDuoi[] | undefined;
    ListFilter: DM_TrangThietBiTuyenDuoi[] | undefined;
    FormData!: DM_TrangThietBiTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_TrangThietBiTuyenDuoi";
    }
}

