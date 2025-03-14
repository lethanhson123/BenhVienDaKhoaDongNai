import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_DonGiaVon } from './Duoc_DonGiaVon.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_DonGiaVonService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_DonGiaVon_ID', 'DuocKyTonKho_ID', 'Duoc_ID', 'DonGiaVon', 'Khoa', 'DienGiai', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: Duoc_DonGiaVon[] | undefined;
    ListFilter: Duoc_DonGiaVon[] | undefined;
    FormData!: Duoc_DonGiaVon;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_DonGiaVon";
    }
}

