import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanPhauThuat_Ekip } from './HoiChanPhauThuat_Ekip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanPhauThuat_EkipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanPhauThuat_BacSi_Id', 'HoiChanPhauThuat_Id', 'NhanVien_Id', 'VaiTro_Id'];

    List: HoiChanPhauThuat_Ekip[] | undefined;
    ListFilter: HoiChanPhauThuat_Ekip[] | undefined;
    FormData!: HoiChanPhauThuat_Ekip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanPhauThuat_Ekip";
    }
}

