import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTuSoLoNhap } from './ChungTuSoLoNhap.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTuSoLoNhapService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoLoNhap_Id', 'SoLoNhap', 'Duoc_Id', 'NgayNhap', 'HanSuDung', 'NguonDuoc_Id', 'DonGiaMua', 'DonGiaVon', 'TienTe_Id', 'TyGia', 'Thang', 'Nam', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoKiemSoat', 'SoVisa', 'NguonHang_Id', 'DonGiaThau', 'TyLeVAT', 'DonGiaBanTruocVAT', 'DonGiaBanSauVAT', 'MaThongTu', 'MaQuyetDinh', 'SoNamHopDong'];

    List: ChungTuSoLoNhap[] | undefined;
    ListFilter: ChungTuSoLoNhap[] | undefined;
    FormData!: ChungTuSoLoNhap;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTuSoLoNhap";
    }
}

