﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML10_CV130 } from './XML10_CV130.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML10_CV130Service extends BaseService{
    DisplayColumns001: string[] = ['XML10_CV130_Id', 'BenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'XacNhanChiPhi_Id', 'MA_LK', 'SO_SERI', 'SO_CT', 'SO_NGAY', 'DON_VI', 'CHAN_DOAN_RV', 'TU_NGAY', 'DEN_NGAY', 'MA_TTDV', 'TEN_BS', 'MA_BS', 'NGAY_CT'];

    List: XML10_CV130[] | undefined;
    ListFilter: XML10_CV130[] | undefined;
    FormData!: XML10_CV130;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML10_CV";
    }

    GetByYear_Month_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByYear_Month_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByListIDStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByListIDStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

