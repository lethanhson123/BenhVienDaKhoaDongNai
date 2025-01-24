import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_PhacDoDieuTriDichVu_CT } from './DM_PhacDoDieuTriDichVu_CT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_PhacDoDieuTriDichVu_CTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhacDoDTDVCT_Id', 'PhacDoDT_Id', 'DichVu_Id', 'SoLuong', 'ChuKy_Id', 'GhiChu'];

    List: DM_PhacDoDieuTriDichVu_CT[] | undefined;
    ListFilter: DM_PhacDoDieuTriDichVu_CT[] | undefined;
    FormData!: DM_PhacDoDieuTriDichVu_CT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_PhacDoDieuTriDichVu_CT";
    }
}

