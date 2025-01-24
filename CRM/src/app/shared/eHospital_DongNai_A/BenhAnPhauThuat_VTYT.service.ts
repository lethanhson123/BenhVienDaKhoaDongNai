import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat_VTYT } from './BenhAnPhauThuat_VTYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuat_VTYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_VTYT_Id', 'BenhAnPhauThuat_Id', 'Duoc_Id', 'SoLuong', 'LoaiGia_Id', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'TyLeVAT', 'GiaTriVAT', 'TienTe_Id', 'TyGia', 'ChungTu_Id', 'GhiChu', 'ChungTuTongHop_Id', 'KhoSuDung_Id', 'TinhTien', 'SoTienThucTe', 'SoTienMienGiam', 'SoTienThatThu', 'SoTienConLai', 'SoTienDaThanhToan', 'NgaySuDung', 'NguonHang_Id', 'DaThanhToan_MotPhan', 'DaThanhToan_HoanTat', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech', 'SoTienDaThanhToan_ChenhLech', 'SoTienDaThanhToan_HoTroChenhLech', 'TrangThai_Xem', 'NguonGocDuLieu', 'NguoiTao_Id', 'NgayTao', 'KTC', 'SoThuTu', 'DonGiaHoTro_KTC', 'DonGiaHoTroChiTra_KTC'];

    List: BenhAnPhauThuat_VTYT[] | undefined;
    ListFilter: BenhAnPhauThuat_VTYT[] | undefined;
    FormData!: BenhAnPhauThuat_VTYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat_VTYT";
    }
}

