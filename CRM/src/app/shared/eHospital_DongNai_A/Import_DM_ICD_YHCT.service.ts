import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Import_DM_ICD_YHCT } from './Import_DM_ICD_YHCT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Import_DM_ICD_YHCTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_BENH', 'CHUNG_BENH', 'ICD10', 'TEN_BENH_YHHD', 'TEN_BENH', 'CHUONG'];

    List: Import_DM_ICD_YHCT[] | undefined;
    ListFilter: Import_DM_ICD_YHCT[] | undefined;
    FormData!: Import_DM_ICD_YHCT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Import_DM_ICD_YHCT";
    }
}

