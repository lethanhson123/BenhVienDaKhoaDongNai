import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe_TienSuBanThan } from './HoSoSucKhoe_TienSuBanThan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoe_TienSuBanThanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TienSuBanThan_Id', 'HoSoSucKhoe_Id', 'ICD_ID', 'Benh', 'NhomBenh_Id', 'NgayXacDinh', 'NamMacBenh', 'GhiChu'];

    List: HoSoSucKhoe_TienSuBanThan[] | undefined;
    ListFilter: HoSoSucKhoe_TienSuBanThan[] | undefined;
    FormData!: HoSoSucKhoe_TienSuBanThan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe_TienSuBanThan";
    }
}

