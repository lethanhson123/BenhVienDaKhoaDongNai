import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BCDP_014_TheoLo } from './BCDP_014_TheoLo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BCDP_014_TheoLoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhamVi', 'NguonDuoc', 'LoaiDuoc', 'PhanNhomDuoc', 'MaKeToan', 'Duoc_ID', 'SoLoNhap_Id', 'TenDuoc', 'NuocSanXuat', 'DonViTinh', 'SoLuongDK', 'ThanhTienDK', 'SoLuongNhap', 'ThanhTienNhap', 'SoLuongXuat', 'ThanhTienXuat'];

    List: BCDP_014_TheoLo[] | undefined;
    ListFilter: BCDP_014_TheoLo[] | undefined;
    FormData!: BCDP_014_TheoLo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BCDP_014_TheoLo";
    }
}

