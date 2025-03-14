import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_VTYT } from './KhamBenh_VTYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_VTYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_VTYT_Id', 'KhamBenh_Id', 'Idx', 'Duoc_Id', 'SoLuong', 'LoaiGia_Id', 'TienTe_Id', 'TyGia', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'GhiChu', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'PhieuLinh_Id', 'KhoSuDung_Id', 'ChungTu_Id', 'TinhTien'];

    List: KhamBenh_VTYT[] | undefined;
    ListFilter: KhamBenh_VTYT[] | undefined;
    FormData!: KhamBenh_VTYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_VTYT";
    }
}

