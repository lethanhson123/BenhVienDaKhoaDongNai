import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_SoLoNhap_GiaBan } from './Duoc_SoLoNhap_GiaBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_SoLoNhap_GiaBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocSoLoNhapGiaBan_id', 'SoLoNhap_id', 'Duoc_id', 'DonGiaVon', 'DonGiaBan', 'DonGia1', 'DonGia2', 'DonGia3', 'DonGia4', 'DonGia5', 'DonGia6', 'DonGia7', 'DonGia8', 'DonGia9', 'TyLeVAT', 'DonGiaBanTruocVAT', 'DonGiaBanSauVAT'];

    List: Duoc_SoLoNhap_GiaBan[] | undefined;
    ListFilter: Duoc_SoLoNhap_GiaBan[] | undefined;
    FormData!: Duoc_SoLoNhap_GiaBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_SoLoNhap_GiaBan";
    }
}

