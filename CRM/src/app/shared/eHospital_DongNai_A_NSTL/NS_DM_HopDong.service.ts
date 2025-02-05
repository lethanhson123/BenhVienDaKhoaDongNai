import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_HopDong } from './NS_DM_HopDong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_HopDongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaHopDong', 'TenHopDong', 'Loai', 'HopDong_Id'];

    List: NS_DM_HopDong[] | undefined;
    ListFilter: NS_DM_HopDong[] | undefined;
    FormData!: NS_DM_HopDong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_HopDong";
    }
}

