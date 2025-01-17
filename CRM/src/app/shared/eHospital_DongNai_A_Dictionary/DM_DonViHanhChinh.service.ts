import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DonViHanhChinh } from './DM_DonViHanhChinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DonViHanhChinhService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'DonViHanhChinh_Id', 'MaDonVi', 'TenDonVi', 'CapDonVi', 'CapTren_Id', 'MaVung_Id', 'KhuVucLuuTru_Id', 'TamNgung', 'TenTat', 'TenTat_2', 'TenTat_3', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SiteCode', 'Mapping_Public_Id', 'MaDonVi_HSSK'];

    List: DM_DonViHanhChinh[] | undefined;
    ListFilter: DM_DonViHanhChinh[] | undefined;
    FormData!: DM_DonViHanhChinh;

    ListTinhThanh: DM_DonViHanhChinh[] | undefined;
    ListQuanHuyen: DM_DonViHanhChinh[] | undefined;
    ListXaPhuong: DM_DonViHanhChinh[] | undefined;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DonViHanhChinh";
    }

    GetByCapDonViToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByCapDonViToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByCapDonViAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByCapDonViAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByCapDonVi_CapTren_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByCapDonVi_CapTren_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByCapDonVi_CapTren_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByCapDonVi_CapTren_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

