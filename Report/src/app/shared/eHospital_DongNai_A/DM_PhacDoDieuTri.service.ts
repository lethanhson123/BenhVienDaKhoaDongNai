import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_PhacDoDieuTri } from './DM_PhacDoDieuTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_PhacDoDieuTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhacDoDieuTri_Id', 'MaPhacDo', 'TenPhacDo', 'ICD_Id', 'ChuyenKhoa_Id', 'TamNgung', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_PhacDoDieuTri[] | undefined;
    ListFilter: DM_PhacDoDieuTri[] | undefined;
    FormData!: DM_PhacDoDieuTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_PhacDoDieuTri";
    }
}

