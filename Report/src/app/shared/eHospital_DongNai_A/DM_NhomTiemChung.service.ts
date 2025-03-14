import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_NhomTiemChung } from './DM_NhomTiemChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_NhomTiemChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomTiemChung_Id', 'MaNhomTiepChung', 'TenNhomTiemChung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_NhomTiemChung[] | undefined;
    ListFilter: DM_NhomTiemChung[] | undefined;
    FormData!: DM_NhomTiemChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_NhomTiemChung";
    }
}

