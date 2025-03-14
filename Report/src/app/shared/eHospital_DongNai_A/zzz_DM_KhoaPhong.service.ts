import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_DM_KhoaPhong } from './zzz_DM_KhoaPhong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_DM_KhoaPhongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_Id', 'TenPhongBan', 'TenPhongBan_En', 'TenPhongBan_Ru', 'Loai'];

    List: zzz_DM_KhoaPhong[] | undefined;
    ListFilter: zzz_DM_KhoaPhong[] | undefined;
    FormData!: zzz_DM_KhoaPhong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_DM_KhoaPhong";
    }
}

