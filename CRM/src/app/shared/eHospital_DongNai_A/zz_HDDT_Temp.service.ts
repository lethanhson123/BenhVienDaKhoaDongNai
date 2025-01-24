import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zz_HDDT_Temp } from './zz_HDDT_Temp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zz_HDDT_TempService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'Fkey', 'CusCode', 'CusName', 'CusAddress', 'CusPhone', 'CusTaxCode', 'CusBankNo', 'Buyer', 'PaymentMethod', 'Total', 'VATRate', 'VATAmount', 'Amount', 'AmountInWords', 'Extra', 'ArisingDate', 'CreatedDate', 'IsPayed', 'IsAdjusted', 'IsReplaced', 'IsCanceled', 'Status', 'Error', 'BranchCode', 'Status2', 'Synchronized', 'SyncCreateDate'];

    List: zz_HDDT_Temp[] | undefined;
    ListFilter: zz_HDDT_Temp[] | undefined;
    FormData!: zz_HDDT_Temp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zz_HDDT_Temp";
    }
}

