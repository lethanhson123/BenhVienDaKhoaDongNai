import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_DonDatHangChiTiet } from './Duoc_DonDatHangChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_DonDatHangChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DonDatHangChiTiet_Id', 'DonDatHang_Id', 'Duoc_Id', 'SoVisa', 'DonViTinh_Id', 'SoLuongYeuCau', 'SoLuongThucTe', 'SoLuongDaXuat', 'TienTe_Id', 'TyGia', 'DonGiaMua', 'DonGiaBan', 'DonGiaVon', 'DonGiaThanhToan', 'SoQuyen', 'SoHoaDonVAT', 'TyLeVAT', 'GiaTriVAT', 'MienPhi', 'LyDoMienPhi_Id', 'SoChungTuKeToan', 'SoChungTuTienMat', 'TrangThai', 'DaPhatSinhPhieuXuat', 'DaPhatSinhPhieuHoanTra', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: Duoc_DonDatHangChiTiet[] | undefined;
    ListFilter: Duoc_DonDatHangChiTiet[] | undefined;
    FormData!: Duoc_DonDatHangChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_DonDatHangChiTiet";
    }
}

