import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CUST_DM_NhaThuocDungChung } from './CUST_DM_NhaThuocDungChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CUST_DM_NhaThuocDungChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_id', 'MaDuoc', 'TenHang', 'MaQuanLyDuoc'];

    List: CUST_DM_NhaThuocDungChung[] | undefined;
    ListFilter: CUST_DM_NhaThuocDungChung[] | undefined;
    FormData!: CUST_DM_NhaThuocDungChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CUST_DM_NhaThuocDungChung";
    }
}

