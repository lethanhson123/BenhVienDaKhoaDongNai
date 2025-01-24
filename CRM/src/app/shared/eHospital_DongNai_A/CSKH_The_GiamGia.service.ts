import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_GiamGia } from './CSKH_The_GiamGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_GiamGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_GiamGia_Id', 'The_Id', 'LoaiKhachHang_Id', 'DichVu_Id', 'TyLe', 'ThoiGianMin', 'ThoiGianMax', 'TatCaDichVu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_GiamGia[] | undefined;
    ListFilter: CSKH_The_GiamGia[] | undefined;
    FormData!: CSKH_The_GiamGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_GiamGia";
    }
}

