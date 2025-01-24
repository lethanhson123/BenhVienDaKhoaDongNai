import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BienBanHoiChan_Ekip } from './BienBanHoiChan_Ekip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BienBanHoiChan_EkipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BienBanHoiChan_BacSi_Id', 'BienBanHoiChan_Id', 'NhanVien_Id', 'VaiTro_Id'];

    List: BienBanHoiChan_Ekip[] | undefined;
    ListFilter: BienBanHoiChan_Ekip[] | undefined;
    FormData!: BienBanHoiChan_Ekip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BienBanHoiChan_Ekip";
    }
}

