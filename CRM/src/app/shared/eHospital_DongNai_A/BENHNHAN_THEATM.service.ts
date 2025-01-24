import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BENHNHAN_THEATM } from './BENHNHAN_THEATM.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BENHNHAN_THEATMService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BENHNHAN_THEATM_ID', 'MAYTE', 'CMND', 'SOTHEATM', 'LOAITHE_ID', 'NGUOITAO_ID', 'NGAYTAO', 'NGUOICAPNHAT_ID', 'NGAYCAPNHAT', 'ACTIVE', 'TENCHUTHE', 'MENHGIATHE_ID', 'BENHNHAN_ID', 'SOVAOVIEN2', 'NGAYPHATHANHTHE', 'SODIENTHOAI'];

    List: BENHNHAN_THEATM[] | undefined;
    ListFilter: BENHNHAN_THEATM[] | undefined;
    FormData!: BENHNHAN_THEATM;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BENHNHAN_THEATM";
    }
}

