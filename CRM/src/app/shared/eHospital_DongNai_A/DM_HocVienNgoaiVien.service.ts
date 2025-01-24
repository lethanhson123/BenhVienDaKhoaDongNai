import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_HocVienNgoaiVien } from './DM_HocVienNgoaiVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_HocVienNgoaiVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HocVien_Id', 'MaHocVien', 'Ho', 'Ten', 'TenHocVien', 'TenHocVien_Ru', 'TenHocVien_En', 'TenTat', 'NgaySinh', 'GioiTinh', 'DiaChi', 'QuocTich_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'DanToc_Id', 'NgheNhiep_Id', 'CMND', 'HoChieu', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoDienThoai', 'Email', 'PhongBan_ID', 'ChucDanh_ID', 'ChucVu_ID'];

    List: DM_HocVienNgoaiVien[] | undefined;
    ListFilter: DM_HocVienNgoaiVien[] | undefined;
    FormData!: DM_HocVienNgoaiVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_HocVienNgoaiVien";
    }
}

