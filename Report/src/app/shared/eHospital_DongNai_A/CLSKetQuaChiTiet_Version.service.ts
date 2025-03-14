import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaChiTiet_Version } from './CLSKetQuaChiTiet_Version.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaChiTiet_VersionService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQuaChiTiet_Version_Id', 'CLSKetQua_Version_Id', 'DichVu_Id', 'DonViTinh', 'KetQua', 'KetQua2', 'MucBinhThuong', 'MucBinhThuongMin', 'MucBinhThuongMax', 'BatThuong', 'ThucHienBenNgoai'];

    List: CLSKetQuaChiTiet_Version[] | undefined;
    ListFilter: CLSKetQuaChiTiet_Version[] | undefined;
    FormData!: CLSKetQuaChiTiet_Version;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaChiTiet_Version";
    }
}

