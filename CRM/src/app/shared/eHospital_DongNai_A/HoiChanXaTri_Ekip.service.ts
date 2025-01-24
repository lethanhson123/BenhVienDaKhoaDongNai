import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanXaTri_Ekip } from './HoiChanXaTri_Ekip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanXaTri_EkipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanXaTri_BacSi_Id', 'HoiChanXaTri_Id', 'NhanVien_Id', 'VaiTro_Id'];

    List: HoiChanXaTri_Ekip[] | undefined;
    ListFilter: HoiChanXaTri_Ekip[] | undefined;
    FormData!: HoiChanXaTri_Ekip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanXaTri_Ekip";
    }
}

