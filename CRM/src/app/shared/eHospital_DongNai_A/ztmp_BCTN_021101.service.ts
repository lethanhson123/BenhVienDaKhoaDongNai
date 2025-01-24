import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_021101 } from './ztmp_BCTN_021101.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_021101Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenDuocDayDu', 'HangSanXuat', 'HamLuong', 'LieuDungMotLan', 'SoLanDung', 'NgayBatDau', 'NgayKetThuc', 'HanSuDung', 'DuongDung', 'DonViTinh'];

    List: ztmp_BCTN_021101[] | undefined;
    ListFilter: ztmp_BCTN_021101[] | undefined;
    FormData!: ztmp_BCTN_021101;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_021101";
    }
}

