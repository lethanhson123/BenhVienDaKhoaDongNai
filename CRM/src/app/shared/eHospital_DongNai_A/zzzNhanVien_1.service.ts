import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzNhanVien_1 } from './zzzNhanVien_1.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzNhanVien_1Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_KHOA', 'TEN_KHOA', 'MA_BHXH', 'HO_TEN', 'GIOI_TINH', 'MACCHN'];

    List: zzzNhanVien_1[] | undefined;
    ListFilter: zzzNhanVien_1[] | undefined;
    FormData!: zzzNhanVien_1;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzNhanVien_1";
    }
}

