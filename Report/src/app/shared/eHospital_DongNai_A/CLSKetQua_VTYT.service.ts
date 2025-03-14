import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQua_VTYT } from './CLSKetQua_VTYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQua_VTYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQua_VTYT_Id', 'CLSKetQua_Id', 'Duoc_Id', 'SoLuong', 'LoaiGia_Id', 'DonGiaPhaiThu', 'DonGia', 'TyLeVAT', 'GiaTriVAT', 'TienTe_Id', 'TyGia', 'ChungTu_Id', 'GhiChu', 'ChungTuTongHop_Id', 'KhoSuDung_Id', 'TinhTien', 'NgaySuDung', 'ThoiGianSuDung', 'NguonHang_Id', 'PhieuLinh_Id'];

    List: CLSKetQua_VTYT[] | undefined;
    ListFilter: CLSKetQua_VTYT[] | undefined;
    FormData!: CLSKetQua_VTYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQua_VTYT";
    }
}

