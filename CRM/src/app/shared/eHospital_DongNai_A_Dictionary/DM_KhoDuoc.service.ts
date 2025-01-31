import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_KhoDuoc } from './DM_KhoDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_KhoDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhoDuoc_Id', 'MaKho', 'TenKho', 'PhongBan_Id', 'LoaiKho_Id', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'QLNguon', 'KhoDuoc', 'KhoTaiSan', 'KhoNHM', 'KhoVPP', 'KhoTTB', 'ChuyenKhoa_Id', 'CostCenter_Id', 'SiteCode', 'Mapping_Public_Id'];

    List: DM_KhoDuoc[] | undefined;
    ListFilter: DM_KhoDuoc[] | undefined;
    FormData!: DM_KhoDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_KhoDuoc";
    }
    GetByPhongBan_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByPhongBan_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

