import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChan_Ekip } from './HoiChan_Ekip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChan_EkipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChan_BacSi_Id', 'HoiChan_Id', 'NhanVien_Id', 'VaiTro_Id'];

    List: HoiChan_Ekip[] | undefined;
    ListFilter: HoiChan_Ekip[] | undefined;
    FormData!: HoiChan_Ekip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChan_Ekip";
    }
}

