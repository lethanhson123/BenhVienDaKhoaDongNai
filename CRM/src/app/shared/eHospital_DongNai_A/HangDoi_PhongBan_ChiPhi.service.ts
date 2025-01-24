import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HangDoi_PhongBan_ChiPhi } from './HangDoi_PhongBan_ChiPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HangDoi_PhongBan_ChiPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HangDoi_PhongBan_ChiPhi_Id', 'PhongBan_ID', 'ChiPhi', 'NgayHieuLuc', 'SoLuongCho'];

    List: HangDoi_PhongBan_ChiPhi[] | undefined;
    ListFilter: HangDoi_PhongBan_ChiPhi[] | undefined;
    FormData!: HangDoi_PhongBan_ChiPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HangDoi_PhongBan_ChiPhi";
    }
}

