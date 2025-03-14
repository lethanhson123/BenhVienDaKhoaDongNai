import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_TangLanKham } from './CSKH_The_TangLanKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_TangLanKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_TangLanKham_Id', 'The_Id', 'LoaiKhachHang_Id', 'DichVu_Id', 'SoLanDuocTang', 'ThoiGianMin', 'ThoiGianMax', 'SoLanKhamQD', 'TatCaDichVu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_TangLanKham[] | undefined;
    ListFilter: CSKH_The_TangLanKham[] | undefined;
    FormData!: CSKH_The_TangLanKham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_TangLanKham";
    }
}

