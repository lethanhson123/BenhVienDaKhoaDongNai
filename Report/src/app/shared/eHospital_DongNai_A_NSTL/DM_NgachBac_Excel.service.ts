import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_NgachBac_Excel } from './DM_NgachBac_Excel.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_NgachBac_ExcelService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaNV', 'Ngach', 'Ngach1', 'Bac', 'PCTN'];

    List: DM_NgachBac_Excel[] | undefined;
    ListFilter: DM_NgachBac_Excel[] | undefined;
    FormData!: DM_NgachBac_Excel;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_NgachBac_Excel";
    }
}

