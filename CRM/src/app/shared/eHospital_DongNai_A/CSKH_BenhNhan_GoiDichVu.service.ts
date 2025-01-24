import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_BenhNhan_GoiDichVu } from './CSKH_BenhNhan_GoiDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_BenhNhan_GoiDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhanGoiDichVu_Id', 'BenhNhan_Id', 'GoiDichVu_Id', 'TienTe_Id', 'GiaTriGoiDichVu', 'NgayDangKy', 'ThoiGianDangKy', 'NgayHetHan', 'NoiDangKy', 'DaThuTien', 'TamNgung', 'HuyGoiDV', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'Attribute6', 'Attribute7', 'Attribute8', 'Attribute9', 'Attribute10', 'GiaTriThucThu', 'GiaTriMienGiamThe', 'The_Id', 'LoaiKhachHang_Id', 'GiaTriMienGiam', 'GiaTriThatThu', 'GiaTriDaThanhToan', 'DaThanhToan_MotPhan', 'DaThanhToan_HoanTat', 'DuocPhepThucHien', 'TiepNhan_ID', 'BenhAn_ID', 'NguoiChiDinh_Id', 'BenhNhanGoiDichVuChuyen_Id', 'NhanVienChuyen_Id', 'GiaTriGoiSauKhiChuyen', 'TongGiaTriDichVu', 'Khoa', 'NgayKhoa', 'ThoiGianKhoa', 'NguoiKhoa_Id', 'LyDoKhoa', 'isActive', 'NgayKichHoat', 'VAT_ID', 'Vip_Id', 'DonGiaVIP', 'DonGiaVIPChiTra', 'TyLeVip', 'TapDoan_Id', 'DonGiaTapDoan', 'DonGiaTapDoanChiTra', 'TyLeTapDoan', 'xacnhanhotrobaohiem_id', 'xacnhanhotrobaohiemchitiet_id', 'dongiabaohiemhotro', 'ThanhTienBaoHiemHoTro', 'NguoiHuyKhoa_Id', 'ThoiGianHuyKhoa'];

    List: CSKH_BenhNhan_GoiDichVu[] | undefined;
    ListFilter: CSKH_BenhNhan_GoiDichVu[] | undefined;
    FormData!: CSKH_BenhNhan_GoiDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_BenhNhan_GoiDichVu";
    }
}

