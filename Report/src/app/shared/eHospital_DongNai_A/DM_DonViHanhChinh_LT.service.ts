import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DonViHanhChinh_LT } from './DM_DonViHanhChinh_LT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DonViHanhChinh_LTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DonViHanhChinh_Id', 'MaDonVi', 'TenDonVi', 'CapDonVi', 'CapTren_Id', 'MaVung_Id', 'KhuVucLuuTru_Id', 'TamNgung', 'TenTat', 'TenTat_2', 'TenTat_3', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SiteCode', 'Mapping_Public_Id', 'DanhMucMoi'];

    List: DM_DonViHanhChinh_LT[] | undefined;
    ListFilter: DM_DonViHanhChinh_LT[] | undefined;
    FormData!: DM_DonViHanhChinh_LT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DonViHanhChinh_LT";
    }
}

