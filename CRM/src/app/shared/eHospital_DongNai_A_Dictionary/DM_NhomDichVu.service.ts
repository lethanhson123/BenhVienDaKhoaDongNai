import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_NhomDichVu } from './DM_NhomDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_NhomDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDichVu_Id', 'MaNhomDichVu', 'LoaiDichVu_Id', 'TenNhomDichVu', 'TenNhomDichVu_En', 'TenNhomDichVu_Ru', 'Cap', 'CapTren_Id', 'TraLoiKetQuaRieng', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'DuocCapSTT', 'SiteCode', 'Mapping_Public_Id', 'CapSoTT', 'CreateSIDForPACS'];

    List: DM_NhomDichVu[] | undefined;
    ListFilter: DM_NhomDichVu[] | undefined;
    FormData!: DM_NhomDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_NhomDichVu";
    }
    GetByLoaiDichVu_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByLoaiDichVu_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

