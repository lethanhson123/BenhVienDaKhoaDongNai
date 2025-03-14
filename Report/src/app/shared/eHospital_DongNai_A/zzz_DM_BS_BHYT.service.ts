import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_DM_BS_BHYT } from './zzz_DM_BS_BHYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_DM_BS_BHYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_KHOA', 'MANHANVIEN', 'TEN_NHANVIEN', 'CHUCDANH', 'MACCHN', 'NGAYCAP_CCHN', 'MA_BHXH'];

    List: zzz_DM_BS_BHYT[] | undefined;
    ListFilter: zzz_DM_BS_BHYT[] | undefined;
    FormData!: zzz_DM_BS_BHYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_DM_BS_BHYT";
    }
}

