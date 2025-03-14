import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_PhacDoDieuTri_CT } from './DM_PhacDoDieuTri_CT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_PhacDoDieuTri_CTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhacDoDTCT_Id', 'PhacDoDT_Id', 'Duoc_Id', 'Sang', 'Trua', 'Chieu', 'Toi', 'SoLuong', 'SoNgay', 'DuongDung_Id', 'ChuKy_Id', 'GhiChu'];

    List: DM_PhacDoDieuTri_CT[] | undefined;
    ListFilter: DM_PhacDoDieuTri_CT[] | undefined;
    FormData!: DM_PhacDoDieuTri_CT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_PhacDoDieuTri_CT";
    }
}

