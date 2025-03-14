import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzNhanVien_2023_05_23 } from './zzzNhanVien_2023_05_23.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzNhanVien_2023_05_23Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_BHXH', 'HO_TEN', 'MACCHN', 'NGAYCAP_CCHN', 'NOICAP_CCHN'];

    List: zzzNhanVien_2023_05_23[] | undefined;
    ListFilter: zzzNhanVien_2023_05_23[] | undefined;
    FormData!: zzzNhanVien_2023_05_23;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzNhanVien_2023_05_23";
    }
}

