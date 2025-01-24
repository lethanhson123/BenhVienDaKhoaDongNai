import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_PhongBan } from './me_PhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_PhongBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_id', 'SoPhong', 'TenPhongBan', 'KhuVuc_id', 'Mapping_EHOS', 'STTHienTai', 'ThoiGianTaoSo', 'NgayTao', 'NgaycapNhat'];

    List: me_PhongBan[] | undefined;
    ListFilter: me_PhongBan[] | undefined;
    FormData!: me_PhongBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_PhongBan";
    }
}

