import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTuSoLoNhap_Delete20230518 } from './ChungTuSoLoNhap_Delete20230518.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTuSoLoNhap_Delete20230518Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoLoNhap_Id', 'SoLoNhap', 'Duoc_Id', 'NgayNhap', 'HanSuDung', 'NguonDuoc_Id', 'DonGiaMua', 'DonGiaVon', 'TienTe_Id', 'TyGia', 'Thang', 'Nam', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoKiemSoat', 'SoVisa', 'NguonHang_Id', 'DonGiaThau', 'TyLeVAT', 'DonGiaBanTruocVAT', 'DonGiaBanSauVAT', 'MaThongTu', 'MaQuyetDinh', 'SoNamHopDong'];

    List: ChungTuSoLoNhap_Delete20230518[] | undefined;
    ListFilter: ChungTuSoLoNhap_Delete20230518[] | undefined;
    FormData!: ChungTuSoLoNhap_Delete20230518;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTuSoLoNhap_Delete20230518";
    }
}

