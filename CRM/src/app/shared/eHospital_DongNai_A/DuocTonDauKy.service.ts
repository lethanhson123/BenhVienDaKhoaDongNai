import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonDauKy } from './DuocTonDauKy.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonDauKyService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonDauKy_Id', 'DuocKyTonKho_Id', 'KhoDuoc_Id', 'Duoc_Id', 'SoLoNhap_Id', 'DonGiaMua', 'DonGiaVon', 'SoLuong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocTonDauKy[] | undefined;
    ListFilter: DuocTonDauKy[] | undefined;
    FormData!: DuocTonDauKy;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonDauKy";
    }
}

