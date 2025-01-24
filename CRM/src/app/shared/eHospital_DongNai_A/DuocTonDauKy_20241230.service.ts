import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonDauKy_20241230 } from './DuocTonDauKy_20241230.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonDauKy_20241230Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonDauKy_Id', 'DuocKyTonKho_Id', 'KhoDuoc_Id', 'Duoc_Id', 'SoLoNhap_Id', 'DonGiaMua', 'DonGiaVon', 'SoLuong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocTonDauKy_20241230[] | undefined;
    ListFilter: DuocTonDauKy_20241230[] | undefined;
    FormData!: DuocTonDauKy_20241230;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonDauKy_20241230";
    }
}

