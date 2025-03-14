import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { cus_HDDT_ChiTiet } from './cus_HDDT_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class cus_HDDT_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'IDCT', 'VienPhiNoiTruChiTiet_Id', 'VienPhiNoiTru_Id', 'NgayTao_trg'];

    List: cus_HDDT_ChiTiet[] | undefined;
    ListFilter: cus_HDDT_ChiTiet[] | undefined;
    FormData!: cus_HDDT_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "cus_HDDT_ChiTiet";
    }
}

