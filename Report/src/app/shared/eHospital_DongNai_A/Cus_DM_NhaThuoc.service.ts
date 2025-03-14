import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cus_DM_NhaThuoc } from './Cus_DM_NhaThuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cus_DM_NhaThuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhaThuoc_id', 'TenNhaThuoc', 'KhoDuoc_id', 'Khu', 'TamNgung'];

    List: Cus_DM_NhaThuoc[] | undefined;
    ListFilter: Cus_DM_NhaThuoc[] | undefined;
    FormData!: Cus_DM_NhaThuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cus_DM_NhaThuoc";
    }
}

