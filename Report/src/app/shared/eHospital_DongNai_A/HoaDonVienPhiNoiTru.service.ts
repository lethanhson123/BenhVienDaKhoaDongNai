import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDonVienPhiNoiTru } from './HoaDonVienPhiNoiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDonVienPhiNoiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoaDonNoiTru_Id', 'HoaDon_Id', 'CLSYeuCauChiTiet_Id', 'NoiTru_DichVu_Id', 'NoiTru_ToaThuoc_Id', 'NoiTru_TraThuoc_Id', 'BenhAnPhauThuat_VTYT_Id', 'NoiTru_GiuongBenh_Id', 'PhongBan_Id', 'NgayThu', 'ThoiGianThu', 'DonGiaDoanhThu', 'DonGiaThanhToan', 'TyGia', 'SoLuong', 'SoTien', 'DienGiai', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'LyDoMienGiam_Id', 'TyLeMienGiam', 'SoTienMienGiam', 'SoTienThatThu'];

    List: HoaDonVienPhiNoiTru[] | undefined;
    ListFilter: HoaDonVienPhiNoiTru[] | undefined;
    FormData!: HoaDonVienPhiNoiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDonVienPhiNoiTru";
    }
}

