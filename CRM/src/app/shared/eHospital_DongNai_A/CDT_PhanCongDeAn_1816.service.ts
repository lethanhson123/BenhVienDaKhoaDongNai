import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_PhanCongDeAn_1816 } from './CDT_PhanCongDeAn_1816.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_PhanCongDeAn_1816Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_PhanCong_Id', 'KeHoach_Id', 'NhanVien_Id', 'NgayThamGia', 'NgayKetThuc', 'KetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'MaNhanVien_Id', 'LoaiNhanVien', 'NhanVien_Id_TD', 'GhiChu'];

    List: CDT_PhanCongDeAn_1816[] | undefined;
    ListFilter: CDT_PhanCongDeAn_1816[] | undefined;
    FormData!: CDT_PhanCongDeAn_1816;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_PhanCongDeAn_1816";
    }
}

