import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_KhuyenMaiNapTien } from './CSKH_The_KhuyenMaiNapTien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_KhuyenMaiNapTienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_QD_KhuyenMaiNapTien_Id', 'The_Id', 'LoaiKhachHang_Id', 'TyLe', 'ThoiGianMin', 'ThoiGianMax', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_KhuyenMaiNapTien[] | undefined;
    ListFilter: CSKH_The_KhuyenMaiNapTien[] | undefined;
    FormData!: CSKH_The_KhuyenMaiNapTien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_KhuyenMaiNapTien";
    }
}

