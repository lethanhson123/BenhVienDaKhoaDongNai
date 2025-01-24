import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSGhiNhanHoaChat_VTYT } from './CLSGhiNhanHoaChat_VTYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSGhiNhanHoaChat_VTYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'CLSYeuCau_Id', 'Duoc_Id', 'SoLuong', 'LoaiGia_Id', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'TyLeVAT', 'GiaTriVAT', 'TienTe_Id', 'TyGia', 'ChungTu_Id', 'ChungTuTongHop_Id', 'GhiChu', 'KhoSuDung_Id', 'TinhTien', 'SoTienThucTe', 'SoTienMienGiam', 'SoTienThatThu', 'SoTienConLai', 'SoTienDaThanhToan', 'NgaySuDung', 'NguonHang_Id', 'QuanLyBenhPham_Id', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech', 'GiaTriDaThanhToan_ChenhLech', 'GiaTriDaThanhToan_HoTroChenhLech', 'DongChiTra', 'KhoPhatThuoc_Id'];

    List: CLSGhiNhanHoaChat_VTYT[] | undefined;
    ListFilter: CLSGhiNhanHoaChat_VTYT[] | undefined;
    FormData!: CLSGhiNhanHoaChat_VTYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSGhiNhanHoaChat_VTYT";
    }
}

