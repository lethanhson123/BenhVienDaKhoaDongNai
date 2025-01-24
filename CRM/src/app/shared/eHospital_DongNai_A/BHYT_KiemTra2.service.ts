import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BHYT_KiemTra2 } from './BHYT_KiemTra2.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BHYT_KiemTra2Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HO_TEN', 'MA_THE', 'NGAY_VAO', 'NGAY_RA', 'MA_BENH', 'NGAY_YL'];

    List: BHYT_KiemTra2[] | undefined;
    ListFilter: BHYT_KiemTra2[] | undefined;
    FormData!: BHYT_KiemTra2;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BHYT_KiemTra2";
    }
}

