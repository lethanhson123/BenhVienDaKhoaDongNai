import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_ThanhVien } from './CSKH_ThanhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_ThanhVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThanhVien_Id', 'MaThanhVien', 'BenhNhan_Id', 'TamNgung', 'DaXoa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute_1', 'Attribute_2', 'Attribute_3', 'Attribute_4', 'Attribute_5', 'Attribute_6', 'NgayDangKy', 'DaThuTien', 'Id_Cu', 'NgayTaoHoiVien', 'NoiChiDinh_Id', 'BacSiChiDinh_Id', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'GiaTriMienGiam', 'GiaTriThatThu', 'GiaTriDaThanhToan'];

    List: CSKH_ThanhVien[] | undefined;
    ListFilter: CSKH_ThanhVien[] | undefined;
    FormData!: CSKH_ThanhVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_ThanhVien";
    }
}

