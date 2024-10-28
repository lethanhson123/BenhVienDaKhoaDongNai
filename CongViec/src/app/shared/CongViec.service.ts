import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CongViec } from 'src/app/shared/CongViec.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CongViecService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'NgayYeuCau', 'Name', 'ThanhVienYeuCauName', 'ThanhVienGiaiQuyetName', 'DanhMucTinhTrangName', 'Save'];
        
    List: CongViec[] | undefined;
    ListFilter: CongViec[] | undefined;
    FormData!: CongViec;
    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CongViec";
    }
}

