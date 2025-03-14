import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaChiTiet_His } from './CLSKetQuaChiTiet_His.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaChiTiet_HisService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQuaChiTiet_Id', 'CLSKetQua_Id', 'DichVu_Id', 'DonViTinh', 'KetQua', 'KetQua2', 'MucBinhThuong', 'MucBinhThuongMin', 'MucBinhThuongMax', 'BatThuong', 'ThucHienBenNgoai', 'LanCapNhat', 'ThoiGianCapNhat', 'NguoiCapNhat_Id'];

    List: CLSKetQuaChiTiet_His[] | undefined;
    ListFilter: CLSKetQuaChiTiet_His[] | undefined;
    FormData!: CLSKetQuaChiTiet_His;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaChiTiet_His";
    }
}

