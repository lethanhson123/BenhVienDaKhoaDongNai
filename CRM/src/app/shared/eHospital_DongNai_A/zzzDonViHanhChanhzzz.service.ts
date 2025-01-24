import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzDonViHanhChanhzzz } from './zzzDonViHanhChanhzzz.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzDonViHanhChanhzzzService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenNhanVien', 'CMND'];

    List: zzzDonViHanhChanhzzz[] | undefined;
    ListFilter: zzzDonViHanhChanhzzz[] | undefined;
    FormData!: zzzDonViHanhChanhzzz;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzDonViHanhChanhzzz";
    }
}

