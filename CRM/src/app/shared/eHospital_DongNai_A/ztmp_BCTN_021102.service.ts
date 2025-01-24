import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_021102 } from './ztmp_BCTN_021102.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_021102Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenBenhNhan', 'CacXetNghiem', 'NgayXuatHienPhanUng', 'BC_Ngay'];

    List: ztmp_BCTN_021102[] | undefined;
    ListFilter: ztmp_BCTN_021102[] | undefined;
    FormData!: ztmp_BCTN_021102;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_021102";
    }
}

