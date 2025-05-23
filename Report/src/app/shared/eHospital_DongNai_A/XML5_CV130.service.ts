﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML5_CV130 } from './XML5_CV130.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML5_CV130Service extends BaseService{
    DisplayColumns001: string[] = ['XML5_CV130_Id', 'BenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'XacNhanChiPhi_Id', 'MA_LK', 'STT', 'DIEN_BIEN_LS', 'GIAI_DOAN_BENH', 'HOI_CHAN', 'PHAU_THUAT', 'THOI_DIEM_DBLS', 'NGUOI_THUC_HIEN', 'DU_PHONG'];

    List: XML5_CV130[] | undefined;
    ListFilter: XML5_CV130[] | undefined;
    FormData!: XML5_CV130;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML5_CV";
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

