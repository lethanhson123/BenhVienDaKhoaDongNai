import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CUS_Invoices } from './CUS_Invoices.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CUS_InvoicesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Fkey', 'Serial', 'Pattern', 'No', 'CusCode', 'CusName', 'CusAddress', 'CusPhone', 'CusTaxCode', 'CusBankNo', 'Buyer', 'PaymentMethod', 'Total', 'VATRate', 'VATAmount', 'Amount', 'AmountInWords', 'Extra', 'ArisingDate', 'CreatedDate', 'IsPayed', 'IsAdjusted', 'IsReplaced', 'IsCanceled', 'Status', 'Error', 'TransID', 'FileID', 'BranchCode'];

    List: CUS_Invoices[] | undefined;
    ListFilter: CUS_Invoices[] | undefined;
    FormData!: CUS_Invoices;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CUS_Invoices";
    }
}

