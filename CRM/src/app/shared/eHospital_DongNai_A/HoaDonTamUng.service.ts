import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDonTamUng } from './HoaDonTamUng.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDonTamUngService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoaDonTamUng_Id', 'SoChungTu', 'Ngay', 'LoaiCT', 'Loai', 'BenhAn_Id', 'NoiPhatSinh_Id', 'SoHoaDon', 'SoSeries', 'GiaTriHoaDon', 'LoaiTien_Id', 'TyGia', 'TyLeVAT', 'GiaTriVAT', 'NoiThuTien_Id', 'NguoiThuTien_Id', 'NgayThuTien', 'DienGiai', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: HoaDonTamUng[] | undefined;
    ListFilter: HoaDonTamUng[] | undefined;
    FormData!: HoaDonTamUng;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDonTamUng";
    }
}

