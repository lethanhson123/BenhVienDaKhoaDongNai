import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DonViTinh } from './DM_DonViTinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DonViTinhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DonViTinh_Id', 'LoaiVatTu_Id', 'MaDonViTinh', 'TenDonViTinh', 'DonViCoBan', 'DonViCoBan_Id', 'GiaTriQuiDoi', 'TenKhongDau', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SiteCode', 'Mapping_Public_Id'];

    List: DM_DonViTinh[] | undefined;
    ListFilter: DM_DonViTinh[] | undefined;
    FormData!: DM_DonViTinh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DonViTinh";
    }
}

