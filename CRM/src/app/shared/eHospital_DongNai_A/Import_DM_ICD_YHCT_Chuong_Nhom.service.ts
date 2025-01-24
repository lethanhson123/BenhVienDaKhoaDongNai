import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Import_DM_ICD_YHCT_Chuong_Nhom } from './Import_DM_ICD_YHCT_Chuong_Nhom.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Import_DM_ICD_YHCT_Chuong_NhomService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MA_CHUONG', 'CHUONG'];

    List: Import_DM_ICD_YHCT_Chuong_Nhom[] | undefined;
    ListFilter: Import_DM_ICD_YHCT_Chuong_Nhom[] | undefined;
    FormData!: Import_DM_ICD_YHCT_Chuong_Nhom;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Import_DM_ICD_YHCT_Chuong_Nhom";
    }
}

