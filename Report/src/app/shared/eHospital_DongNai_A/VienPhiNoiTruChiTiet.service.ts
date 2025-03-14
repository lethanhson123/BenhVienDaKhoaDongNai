import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { VienPhiNoiTruChiTiet } from './VienPhiNoiTruChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class VienPhiNoiTruChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'VienPhiNoiTruChiTiet_Id', 'VienPhiNoiTru_Id', 'IDRef', 'Loai_IDRef', 'PhongBan_Id', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'SoLuong', 'GiaTriHoaDon', 'TyLeMienGiam', 'GiaTriMienGiam', 'TyLeThatThu', 'GiaTriThatThu', 'TyGia', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'CLSYeuCauChiTiet_Id', 'NoiTru_ToaThuoc_Id', 'NoiTru_TraThuoc_Id', 'BenhAnPhauThuat_VTYT_Id', 'NoiTru_GiuongBenh_Id', 'CLSGhiNhanHoaChat_Id', 'NoiDung_Id', 'LoaiNoiDung', 'DoiTuong_Id', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech', 'GiaTriHoaDon_ChenhLech', 'GiaTriMienGiam_ChenhLech', 'GiaTriThatThu_ChenhLech', 'GiaTriHoaDon_HoTroChenhLech', 'GiaTriMienGiam_HoTroChenhLech', 'GiaTriThatThu_HoTroChenhLech', 'DonGiaCoPhan', 'GiaTriHoaDon_CoPhan', 'GiaTriMienGiam_CoPhan', 'GiaTriThatThu_CoPhan', 'SiteCode', 'TenNoiPhatSinh', 'TenLoaiGia', 'NoiDungChiTiet', 'NgayPhatSinh', 'GiaTriGhiNhan_ChenhLech', 'GiaTriGhiNhan_HoTroChenhLech', 'GiaTriGhiNhan_CoPhan', 'MaNhom', 'TenNhom', 'MaLoai', 'TenLoai', 'LoaiVatTu'];

    List: VienPhiNoiTruChiTiet[] | undefined;
    ListFilter: VienPhiNoiTruChiTiet[] | undefined;
    FormData!: VienPhiNoiTruChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "VienPhiNoiTruChiTiet";
    }
}

