import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_003 } from './ztmp_BCTN_003.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_003Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoVaoVien', 'TenBenhNhan', 'DiaChiBenhNhan', 'Trai', 'Gai', 'ChanDoan1', 'TenPhongBan', 'MaGiuong', 'MaPhong', 'NgayVaoVien', 'NgayRa'];

    List: ztmp_BCTN_003[] | undefined;
    ListFilter: ztmp_BCTN_003[] | undefined;
    FormData!: ztmp_BCTN_003;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_003";
    }
}

