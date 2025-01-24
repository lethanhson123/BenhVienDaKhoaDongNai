import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhacDoDieuTri_BN } from './PhacDoDieuTri_BN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhacDoDieuTri_BNService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PDDT_BN_ID', 'MaPhacDo', 'SoBenhAn', 'Khoa_Id', 'NgayDieuTri', 'GhiChu', 'ChuKy_Id', 'TrangThai'];

    List: PhacDoDieuTri_BN[] | undefined;
    ListFilter: PhacDoDieuTri_BN[] | undefined;
    FormData!: PhacDoDieuTri_BN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhacDoDieuTri_BN";
    }
}

