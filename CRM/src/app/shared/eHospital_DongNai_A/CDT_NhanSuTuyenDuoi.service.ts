import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_NhanSuTuyenDuoi } from './CDT_NhanSuTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_NhanSuTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhanVien_Id', 'BenhVien_Id', 'MaNhanVien', 'Ho', 'Ten', 'TenNhanVien', 'TenNhanVien_Ru', 'TenNhanVien_En', 'TenTat', 'NgaySinh', 'NamSinh', 'GioiTinh', 'DiaChi', 'PhongBan_Id', 'DonViCongTac_Id', 'ChucDanh_Id', 'ChucVu_Id', 'TrinhDoChuyenMon_Id', 'QuocTich_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'DanToc_Id', 'NgheNhiep_Id', 'CMND', 'HoChieu', 'TrucTiepSX', 'TiepXucDocHai', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'MaDonVi', 'NgayVao', 'MaNhanVienNSTL', 'SoDienThoai', 'Email'];

    List: CDT_NhanSuTuyenDuoi[] | undefined;
    ListFilter: CDT_NhanSuTuyenDuoi[] | undefined;
    FormData!: CDT_NhanSuTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_NhanSuTuyenDuoi";
    }
}

