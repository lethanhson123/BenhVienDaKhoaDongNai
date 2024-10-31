import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CongViecTapTinDinhKem } from 'src/app/shared/CongViecTapTinDinhKem.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CongViecTapTinDinhKemService extends BaseService{

    DisplayColumns001: string[] = ['Name', 'Save'];

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CongViecTapTinDinhKem";
    }
}

