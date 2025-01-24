import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { YTDP_KetQua } from './YTDP_KetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class YTDP_KetQuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KetQua_Id', 'NoiKiemTra_Id', 'NoiKiemTra', 'TuNgay', 'DenNgay', 'BacSi_Id', 'TenBacSi', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: YTDP_KetQua[] | undefined;
    ListFilter: YTDP_KetQua[] | undefined;
    FormData!: YTDP_KetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "YTDP_KetQua";
    }
}

