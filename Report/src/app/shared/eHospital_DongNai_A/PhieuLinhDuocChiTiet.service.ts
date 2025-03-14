import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuLinhDuocChiTiet } from './PhieuLinhDuocChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuLinhDuocChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChungTuChiTiet_Id', 'ChungTu_Id', 'Duoc_Id', 'SoLoNhap_Id', 'SoKiemSoat', 'SoVisa', 'DonViTinh_Id', 'SoLuongYeuCau', 'SoLuongThucTe', 'SoLuongDaXuat', 'TienTe_Id', 'TyGia', 'DonGiaMua', 'DonGiaBan', 'DonGiaVon', 'SoQuyen', 'SoHoaDonVAT', 'TyLeVAT', 'GiaTriVAT', 'MienPhi', 'LyDoMienPhi_Id', 'SoChungTuKeToan', 'SoChungTuTienMat', 'TrangThai', 'DaPhatSinhPhieuXuat', 'DaPhatSinhPhieuHoanTra', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NguonHang_Id', 'ChungTuHoanTra_Le_Id', 'SoLuongThucNhan', 'SoLuongTongHopThucTe'];

    List: PhieuLinhDuocChiTiet[] | undefined;
    ListFilter: PhieuLinhDuocChiTiet[] | undefined;
    FormData!: PhieuLinhDuocChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuLinhDuocChiTiet";
    }
}

