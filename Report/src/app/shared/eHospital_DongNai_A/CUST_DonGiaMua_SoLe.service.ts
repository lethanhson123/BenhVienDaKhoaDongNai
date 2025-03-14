import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CUST_DonGiaMua_SoLe } from './CUST_DonGiaMua_SoLe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CUST_DonGiaMua_SoLeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SEQ', 'ChungTuChiTiet_id', 'DonGiaMua', 'NgayTao'];

    List: CUST_DonGiaMua_SoLe[] | undefined;
    ListFilter: CUST_DonGiaMua_SoLe[] | undefined;
    FormData!: CUST_DonGiaMua_SoLe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CUST_DonGiaMua_SoLe";
    }
}

