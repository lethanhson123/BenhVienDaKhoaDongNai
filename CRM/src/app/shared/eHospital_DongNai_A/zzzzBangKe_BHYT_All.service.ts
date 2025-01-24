import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBangKe_BHYT_All } from './zzzzBangKe_BHYT_All.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBangKe_BHYT_AllService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma_lk', 'NoiDung_id', 'So_Luong', 'Don_Gia_BV', 'Don_Gia_BH', 'Thanh_Tien_BV', 'Thanh_Tien_BH', 'T_BHTT', 'T_BNCCT', 'T_KHAC', 'T_BNTT', 'Loai_IDRef'];

    List: zzzzBangKe_BHYT_All[] | undefined;
    ListFilter: zzzzBangKe_BHYT_All[] | undefined;
    FormData!: zzzzBangKe_BHYT_All;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBangKe_BHYT_All";
    }
}

