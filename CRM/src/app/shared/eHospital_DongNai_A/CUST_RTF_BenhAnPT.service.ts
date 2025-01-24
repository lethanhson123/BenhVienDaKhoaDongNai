import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CUST_RTF_BenhAnPT } from './CUST_RTF_BenhAnPT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CUST_RTF_BenhAnPTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_Id', 'TrinhTuThucHien', 'TrinhTuThucHien_Convert', 'DaXuLy'];

    List: CUST_RTF_BenhAnPT[] | undefined;
    ListFilter: CUST_RTF_BenhAnPT[] | undefined;
    FormData!: CUST_RTF_BenhAnPT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CUST_RTF_BenhAnPT";
    }
}

