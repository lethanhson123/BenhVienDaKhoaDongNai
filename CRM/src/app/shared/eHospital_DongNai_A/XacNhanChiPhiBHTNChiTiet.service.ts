import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhiBHTNChiTiet } from './XacNhanChiPhiBHTNChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhiBHTNChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanChiPhiChiTiet_Id', 'XacNhanChiPhi_Id', 'GhiNhanChiTiet_Id', 'TongGiaTri', 'TyLe', 'GiaTri', 'IDRef', 'SoLuong', 'Loai_IDRef', 'NoiDung_ID', 'LoaiNoiDung', 'GiaTriGhiNhan_ChenhLech', 'GiaTriGhiNhan_HoTroChenhLech', 'GiaTriGhiNhan_CoPhan', 'LoaiGia', 'GiaTriThanhToan_ChenhLech', 'GiaTriThanhToan_HoTroChenhLech', 'GiaTriThanhToan_CoPhan', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaBHTN', 'DonGiaThanhToan'];

    List: XacNhanChiPhiBHTNChiTiet[] | undefined;
    ListFilter: XacNhanChiPhiBHTNChiTiet[] | undefined;
    FormData!: XacNhanChiPhiBHTNChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhiBHTNChiTiet";
    }
}

