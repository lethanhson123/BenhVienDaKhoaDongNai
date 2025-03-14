import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_KiemKe } from './Duoc_KiemKe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_KiemKeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocKiemKe_Id', 'DuocKyKiemke_Id', 'KhoDuoc_Id', 'Duoc_Id', 'SoLoNhap_Id', 'DonGiaMua', 'DonGiaVon', 'SoLuong', 'TenDuoc', 'DVT', 'SoKiemSoat', 'NuocSX', 'Thanhtien', 'SoThucTe', 'Thua', 'Thieu', 'HongVo', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: Duoc_KiemKe[] | undefined;
    ListFilter: Duoc_KiemKe[] | undefined;
    FormData!: Duoc_KiemKe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_KiemKe";
    }
}

