import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LIS_Tmp_CLSKetQuaChiTiet } from './LIS_Tmp_CLSKetQuaChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LIS_Tmp_CLSKetQuaChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSYeuCau_Id', 'DichVu_Id', 'KetQua', 'BatThuong', 'ThoiGian'];

    List: LIS_Tmp_CLSKetQuaChiTiet[] | undefined;
    ListFilter: LIS_Tmp_CLSKetQuaChiTiet[] | undefined;
    FormData!: LIS_Tmp_CLSKetQuaChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LIS_Tmp_CLSKetQuaChiTiet";
    }
}

