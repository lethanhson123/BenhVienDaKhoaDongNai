import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_DuocHu } from './DuocTonKho_DuocHu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_DuocHuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_Id', 'KhoDuoc_Id', 'Duoc_Id', 'SoLoNhap_Id', 'DonGiaMua', 'SoLuong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocTonKho_DuocHu[] | undefined;
    ListFilter: DuocTonKho_DuocHu[] | undefined;
    FormData!: DuocTonKho_DuocHu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_DuocHu";
    }
}

