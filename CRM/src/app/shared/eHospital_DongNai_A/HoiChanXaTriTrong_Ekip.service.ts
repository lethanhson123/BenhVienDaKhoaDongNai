import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanXaTriTrong_Ekip } from './HoiChanXaTriTrong_Ekip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanXaTriTrong_EkipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanXaTriTrongEkip_Id', 'HoiChanXaTriTrong_Id', 'NhanVien_Id'];

    List: HoiChanXaTriTrong_Ekip[] | undefined;
    ListFilter: HoiChanXaTriTrong_Ekip[] | undefined;
    FormData!: HoiChanXaTriTrong_Ekip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanXaTriTrong_Ekip";
    }
}

