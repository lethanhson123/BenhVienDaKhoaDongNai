import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BHYT_RV_2019 } from './ztmp_BHYT_RV_2019.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BHYT_RV_2019Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_CT', 'MA_CSKCB', 'SO_SERI', 'MA_KHOA', 'MA_SOBHXH', 'MA_THE', 'HO_TEN', 'DIA_CHI', 'NGAY_SINH', 'DAN_TOC', 'GIOI_TINH', 'NGHE_NGHIEP', 'NGAY_VAO', 'NGAY_RA', 'TUOI_THAI', 'CHUAN_DOAN_VAO', 'PP_DIEUTRI', 'GHI_CHU', 'NGUOI_DAI_DIEN', 'MA_BS', 'NGAY_CT', 'TEN_BS', 'TEN_CHA', 'TEN_ME', 'TEKT'];

    List: ztmp_BHYT_RV_2019[] | undefined;
    ListFilter: ztmp_BHYT_RV_2019[] | undefined;
    FormData!: ztmp_BHYT_RV_2019;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BHYT_RV_2019";
    }
}

