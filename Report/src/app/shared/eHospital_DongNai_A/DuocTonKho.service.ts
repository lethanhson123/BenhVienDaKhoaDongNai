import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho } from './DuocTonKho.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKhoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_Id', 'KhoDuoc_Id', 'Duoc_Id', 'NguonNhapHang_Id', 'SoLoNhap_Id', 'DonGiaMua', 'SoLuong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocTonKho[] | undefined;
    ListFilter: DuocTonKho[] | undefined;
    FormData!: DuocTonKho;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho";
    }
}

