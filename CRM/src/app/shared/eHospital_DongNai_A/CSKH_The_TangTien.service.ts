import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_TangTien } from './CSKH_The_TangTien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_TangTienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_TangTien_Id', 'The_Id', 'LoaiKhachHang_Id', 'SoTienDuocTang', 'DenKham', 'TongTienLanKham', 'SoLanKham', 'TongTienThoiGian', 'ThoiGianMin', 'ThoiGianMax', 'SoThangQD', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_TangTien[] | undefined;
    ListFilter: CSKH_The_TangTien[] | undefined;
    FormData!: CSKH_The_TangTien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_TangTien";
    }
}

