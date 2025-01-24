import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_MienPhiLanKham } from './CSKH_The_MienPhiLanKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_MienPhiLanKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_MienPhiLanKham_Id', 'The_Id', 'LoaiKhachHang_Id', 'DichVu_Id', 'SoLan', 'ThoiGianMin', 'ThoiGianMax', 'TatCaDichVu', 'CoHen', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoLanDaSuDung'];

    List: CSKH_The_MienPhiLanKham[] | undefined;
    ListFilter: CSKH_The_MienPhiLanKham[] | undefined;
    FormData!: CSKH_The_MienPhiLanKham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_MienPhiLanKham";
    }
}

