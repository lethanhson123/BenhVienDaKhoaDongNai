import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDonVienPhi } from './HoaDonVienPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDonVienPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoaDonVienPhi_Id', 'SoChungTu', 'Ngay', 'LoaiCT', 'Loai', 'BenhAn_Id', 'LuuTru_Id', 'NoiPhatSinh_Id', 'NguoiLap_Id', 'NgayPhatSinh', 'ThoiGianPhatSinh', 'NgayTra', 'ThoiGianTra', 'NoiTra_Id', 'NguoiTra_Id', 'NoiThuTien_Id', 'NguoiThuTien_Id', 'NgayThuTien', 'ThoiGianThuTien', 'NoiHuy_Id', 'NguoiHuy_Id', 'NgayHuy', 'ThoiGianHuy', 'GiaTriHoaDon', 'GiaTriThucThu', 'LoaiTien_Id', 'TyGia', 'TyLeVAT', 'GiaTriVAT', 'HinhThucThanhToan_Id', 'DienGiai', 'TrangThai', 'DaThanhToan', 'HuyHoaDon', 'HoanTra', 'HoaDonLienQuan_Id', 'TyleMienGiam', 'GiaTriMienGiam', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BienLaiChiTiet_Id', 'Series', 'Series_Number'];

    List: HoaDonVienPhi[] | undefined;
    ListFilter: HoaDonVienPhi[] | undefined;
    FormData!: HoaDonVienPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDonVienPhi";
    }
}

