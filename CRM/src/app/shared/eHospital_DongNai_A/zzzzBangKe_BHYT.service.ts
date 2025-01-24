import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBangKe_BHYT } from './zzzzBangKe_BHYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBangKe_BHYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma_lk', 'NoiDung_id', 'So_Luong', 'Don_Gia_BV', 'Don_Gia_BH', 'Thanh_Tien_BV', 'Thanh_Tien_BH', 'T_BHTT', 'T_BNCCT', 'T_KHAC', 'T_BNTT'];

    List: zzzzBangKe_BHYT[] | undefined;
    ListFilter: zzzzBangKe_BHYT[] | undefined;
    FormData!: zzzzBangKe_BHYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBangKe_BHYT";
    }
}

