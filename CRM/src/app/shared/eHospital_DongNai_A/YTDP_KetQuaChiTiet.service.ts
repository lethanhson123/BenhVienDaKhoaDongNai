import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { YTDP_KetQuaChiTiet } from './YTDP_KetQuaChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class YTDP_KetQuaChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KetQuaChiTiet_Id', 'KetQua_Id', 'YTeDuPhong_Id', 'Ngay_1', 'Ngay_2', 'Ngay_3', 'Ngay_4', 'Ngay_5', 'Ngay_6', 'Ngay_7', 'Ngay_8', 'Ngay_9', 'Ngay_10', 'Ngay_11', 'Ngay_12', 'Ngay_13', 'Ngay_14', 'Ngay_15', 'Ngay_16', 'Ngay_17', 'Ngay_18', 'Ngay_19', 'Ngay_20', 'Ngay_21', 'Ngay_22', 'Ngay_23', 'Ngay_24', 'Ngay_25', 'Ngay_26', 'Ngay_27', 'Ngay_28', 'Ngay_29', 'Ngay_30', 'Ngay_31'];

    List: YTDP_KetQuaChiTiet[] | undefined;
    ListFilter: YTDP_KetQuaChiTiet[] | undefined;
    FormData!: YTDP_KetQuaChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "YTDP_KetQuaChiTiet";
    }
}

