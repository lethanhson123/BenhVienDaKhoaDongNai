import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BenhVienTuyenDuoi } from './DM_BenhVienTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BenhVienTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhVien_Id', 'MaBenhVien', 'TenBenhVien', 'TenBenhVien_En', 'TenBenhVien_Ru', 'DiaChi', 'Hang_Id', 'Loai_Id', 'Tuyen_Id', 'CapQuanLy_Id', 'TinhThanhPho_Id', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoDienThoai', 'Email'];

    List: DM_BenhVienTuyenDuoi[] | undefined;
    ListFilter: DM_BenhVienTuyenDuoi[] | undefined;
    FormData!: DM_BenhVienTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BenhVienTuyenDuoi";
    }
}

