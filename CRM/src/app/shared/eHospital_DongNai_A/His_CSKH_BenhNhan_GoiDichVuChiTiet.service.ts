import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_CSKH_BenhNhan_GoiDichVuChiTiet } from './His_CSKH_BenhNhan_GoiDichVuChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_CSKH_BenhNhan_GoiDichVuChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'History_id', 'BenhNhanGoiDichVuChiTiet_Id', 'BenhNhan_Id', 'GoiDichVu_Id', 'DichVu_Id', 'BenhNhanGoiDichVu_Id', 'DonGiaDichVu', 'NgayThucHien', 'ThoiGianThucHien', 'TienTe_Id', 'SoLanSuDungDichVuTieuChuan', 'SoLanSuDungDichVu', 'SoLanSuDungDichVuConLai', 'GhiChu', 'GoiDichVuChiTiet_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'Attribute6', 'Attribute7', 'Attribute8', 'Attribute9', 'Attribute10', 'SoLuong', 'LuuTruChiTiet_Id', 'QuanHe', 'DonGiaDichVuTrongGoi', 'PhanTram', 'SoLuongSauKhiChuyen', 'IsTuChoi', 'NgayTuChoi', 'ThoiGianTuChoi', 'NguoiTuChoi_Id', 'FollowUp', 'NhanVien_FollowUp_Id', 'Ngay_FollowUp', 'ThoiGian_FollowUp', 'IDChuyen'];

    List: His_CSKH_BenhNhan_GoiDichVuChiTiet[] | undefined;
    ListFilter: His_CSKH_BenhNhan_GoiDichVuChiTiet[] | undefined;
    FormData!: His_CSKH_BenhNhan_GoiDichVuChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_CSKH_BenhNhan_GoiDichVuChiTiet";
    }
}

