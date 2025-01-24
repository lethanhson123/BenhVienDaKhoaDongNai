import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Ztmp_BCTH_018_BenhAn_TongHop } from './Ztmp_BCTH_018_BenhAn_TongHop.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Ztmp_BCTH_018_BenhAn_TongHopService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_Id', 'NgayVaoVien', 'ThoiGianVaoVien', 'NgayRaVien', 'ThoiGianRaVien', 'ICD_BenhChinh', 'KetQuaDieuTri_Id', 'SoCapCuu', 'SoBenhAn', 'ThoiGianTuVong', 'NgayTiepNhan', 'ThoiGianTiepNhan', 'NamSinh', 'GioiTinh', 'DoiTuong_Id', 'KhoaVao_Id', 'KhoaRa_Id', 'NoiLap_Id', 'NgheNghiep_Id', 'BenhNhan_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'LyDoXuatVien_Id'];

    List: Ztmp_BCTH_018_BenhAn_TongHop[] | undefined;
    ListFilter: Ztmp_BCTH_018_BenhAn_TongHop[] | undefined;
    FormData!: Ztmp_BCTH_018_BenhAn_TongHop;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Ztmp_BCTH_018_BenhAn_TongHop";
    }
}

