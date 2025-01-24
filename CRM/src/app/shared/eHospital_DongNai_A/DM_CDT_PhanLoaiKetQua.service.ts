import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_CDT_PhanLoaiKetQua } from './DM_CDT_PhanLoaiKetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_CDT_PhanLoaiKetQuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_PhanLoaiKetQua_Id', 'MaPhanLoaiKetQua', 'TenPhanLoaiKetQua', 'Description', 'TamNgung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_CDT_PhanLoaiKetQua[] | undefined;
    ListFilter: DM_CDT_PhanLoaiKetQua[] | undefined;
    FormData!: DM_CDT_PhanLoaiKetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_CDT_PhanLoaiKetQua";
    }
}

