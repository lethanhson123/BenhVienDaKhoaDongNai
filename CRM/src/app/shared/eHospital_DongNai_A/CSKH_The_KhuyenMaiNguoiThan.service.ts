import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_KhuyenMaiNguoiThan } from './CSKH_The_KhuyenMaiNguoiThan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_KhuyenMaiNguoiThanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_QD_KhuyenMaiNguoiThan_Id', 'The_Id', 'LoaiKhachHang_Id', 'DichVu_Id', 'TyLe', 'SoTien', 'TatCaDichVu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_KhuyenMaiNguoiThan[] | undefined;
    ListFilter: CSKH_The_KhuyenMaiNguoiThan[] | undefined;
    FormData!: CSKH_The_KhuyenMaiNguoiThan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_KhuyenMaiNguoiThan";
    }
}

