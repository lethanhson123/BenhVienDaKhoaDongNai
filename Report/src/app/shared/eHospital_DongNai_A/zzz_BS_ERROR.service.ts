import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_BS_ERROR } from './zzz_BS_ERROR.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_BS_ERRORService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoVaoVien', 'TenBenhNhan', 'LoaiKCB', 'NgayVao', 'NgayRa'];

    List: zzz_BS_ERROR[] | undefined;
    ListFilter: zzz_BS_ERROR[] | undefined;
    FormData!: zzz_BS_ERROR;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_BS_ERROR";
    }
}

