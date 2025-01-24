import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongTinCapCuu } from './ThongTinCapCuu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongTinCapCuuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThongTinCapCuu_Id', 'SoCapCuu', 'TiepNhan_Id', 'BenhAn_Id', 'LuuTru_Id', 'BenhNhan_Id', 'NgayCapCuu', 'ThoiGianCapCuu', 'NoiCapCuu_Id', 'BacSiCapCuu_Id', 'ChanDoanNGT', 'ICD_BenhChinh', 'ICD_BenhPhu', 'KetQuaCapCuu_Id', 'GhiChu', 'KhoaNhapVien_Id', 'NgayNhapVien', 'ThoiGianNhapVien', 'ICD_NhapVien', 'ChanDoanNhapVien', 'ChuyenVien_Id', 'NgayRaVien', 'ThoiGianRaVien', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: ThongTinCapCuu[] | undefined;
    ListFilter: ThongTinCapCuu[] | undefined;
    FormData!: ThongTinCapCuu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongTinCapCuu";
    }
}

