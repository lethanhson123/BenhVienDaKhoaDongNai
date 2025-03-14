import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DichVu_DonGia } from './DM_DichVu_DonGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DichVu_DonGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DichVu_DonGia_Id', 'BangGia_Id', 'DichVu_Id', 'LoaiGia_Id', 'TienTe_Id', 'DonGia', 'DonGiaThapNhat', 'DonGiaCaoNhat', 'TyLeVAT', 'GiaTriVAT', 'TrangThai', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];
    DisplayColumns002: string[] = ['Save', 'STT', 'DichVu_DonGia_Id', 'DichVu_Id', 'DichVuName', 'LoaiGia_Id', 'TienTe_Id', 'DonGia', 'DonGiaThapNhat', 'DonGiaCaoNhat', 'TyLeVAT', 'GiaTriVAT', 'TrangThai', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_DichVu_DonGia[] | undefined;
    ListFilter: DM_DichVu_DonGia[] | undefined;
    FormData!: DM_DichVu_DonGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DichVu_DonGia";
    }
    GetByBangGia_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByBangGia_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByBangGia_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByBangGia_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

