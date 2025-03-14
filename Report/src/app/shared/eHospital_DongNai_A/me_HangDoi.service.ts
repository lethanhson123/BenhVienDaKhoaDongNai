import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_HangDoi } from './me_HangDoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_HangDoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HangDoi_id', 'KhuVuc_id', 'Cua_id', 'SoTT', 'MacCapSo_id', 'ThoiGianCap', 'MacGoiSo_id', 'ThoiGianGoi', 'TiepNhan_id'];

    List: me_HangDoi[] | undefined;
    ListFilter: me_HangDoi[] | undefined;
    FormData!: me_HangDoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_HangDoi";
    }
}

