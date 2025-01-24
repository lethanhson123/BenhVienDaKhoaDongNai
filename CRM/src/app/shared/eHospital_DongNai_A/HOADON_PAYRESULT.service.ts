import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HOADON_PAYRESULT } from './HOADON_PAYRESULT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HOADON_PAYRESULTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HOADON_PAYRESULT_ID', 'SOHOADON', 'TRANSACTION_ID', 'TRANS_CONFIRM', 'NGAYGIO_REQUEST', 'NGAYGIO_CONFIRM', 'BANK_TRX_ID', 'TIENTE_ID', 'GIATRIHOADON', 'RESPONSECODE', 'MTI', 'REFUND_ID', 'SOTHE', 'MESSAGE', 'MESSAGE_RESPONSE', 'LAST_RESPONSECODE', 'PROCESSINGCODE', 'NGAY_CONFIRM', 'LOAIHOADON', 'RESPONSECODE_VTB', 'SOTIEN_VTB'];

    List: HOADON_PAYRESULT[] | undefined;
    ListFilter: HOADON_PAYRESULT[] | undefined;
    FormData!: HOADON_PAYRESULT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HOADON_PAYRESULT";
    }
}

