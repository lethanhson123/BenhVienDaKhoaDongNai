import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_20230725 } from './DuocTonKho_20230725.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_20230725Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_Id', 'KhoDuoc_Id', 'Duoc_Id', 'NguonNhapHang_Id', 'SoLoNhap_Id', 'DonGiaMua', 'SoLuong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocTonKho_20230725[] | undefined;
    ListFilter: DuocTonKho_20230725[] | undefined;
    FormData!: DuocTonKho_20230725;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_20230725";
    }
}

