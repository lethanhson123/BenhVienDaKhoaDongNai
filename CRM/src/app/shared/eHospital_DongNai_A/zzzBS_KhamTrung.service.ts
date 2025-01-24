import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzBS_KhamTrung } from './zzzBS_KhamTrung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzBS_KhamTrungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MA_BAC_SI', 'TEN_BAC_SI', 'NGAY_YL', 'MA_CSKCB', 'TEN_CSKCB', 'MA_TINH', 'TEN_TINH', 'MA_THE', 'HO_TEN', 'XML1_ID', 'MA_LK'];

    List: zzzBS_KhamTrung[] | undefined;
    ListFilter: zzzBS_KhamTrung[] | undefined;
    FormData!: zzzBS_KhamTrung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzBS_KhamTrung";
    }
}

