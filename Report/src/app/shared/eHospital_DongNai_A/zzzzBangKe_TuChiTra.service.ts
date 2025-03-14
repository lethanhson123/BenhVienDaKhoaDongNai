import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBangKe_TuChiTra } from './zzzzBangKe_TuChiTra.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBangKe_TuChiTraService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma_lk', 'NoiDung_id', 'So_Luong', 'Don_Gia_BV', 'Don_Gia_BH', 'Thanh_Tien_BV', 'Thanh_Tien_BH', 'T_BHTT', 'T_BNCCT', 'T_KHAC', 'T_BNTT'];

    List: zzzzBangKe_TuChiTra[] | undefined;
    ListFilter: zzzzBangKe_TuChiTra[] | undefined;
    FormData!: zzzzBangKe_TuChiTra;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBangKe_TuChiTra";
    }
}

