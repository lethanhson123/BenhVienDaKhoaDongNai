import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_DM_LoaiKhachHang } from './CSKH_DM_LoaiKhachHang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_DM_LoaiKhachHangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiKhachHang_Id', 'MaLoaiKhachHang', 'TenLoaiKhachHang', 'GhiChu', 'TuoiMin', 'TuoiMax', 'SoTien', 'TienTe_Id', 'IsThanhVien', 'AppNam', 'AppNguoi', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'IsTheVinMec', 'CoThuTien', 'DonViPhatHanh_Id', 'NhomLoaiHoiVien_Id', 'Prefixcode'];

    List: CSKH_DM_LoaiKhachHang[] | undefined;
    ListFilter: CSKH_DM_LoaiKhachHang[] | undefined;
    FormData!: CSKH_DM_LoaiKhachHang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_DM_LoaiKhachHang";
    }
}

