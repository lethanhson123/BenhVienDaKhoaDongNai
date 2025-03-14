import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ZZZ_NhanVienSOBHXH } from './ZZZ_NhanVienSOBHXH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ZZZ_NhanVienSOBHXHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_BHXH', 'HO_TEN', 'GIOI_TINH', 'MACCHN'];

    List: ZZZ_NhanVienSOBHXH[] | undefined;
    ListFilter: ZZZ_NhanVienSOBHXH[] | undefined;
    FormData!: ZZZ_NhanVienSOBHXH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ZZZ_NhanVienSOBHXH";
    }
}

