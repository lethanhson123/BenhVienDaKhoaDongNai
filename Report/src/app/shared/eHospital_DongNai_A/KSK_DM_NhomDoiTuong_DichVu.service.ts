import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_DM_NhomDoiTuong_DichVu } from './KSK_DM_NhomDoiTuong_DichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_DM_NhomDoiTuong_DichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDoiTuong_DichVu_Id', 'NhomDoiTuong_Id', 'DichVu_Id'];

    List: KSK_DM_NhomDoiTuong_DichVu[] | undefined;
    ListFilter: KSK_DM_NhomDoiTuong_DichVu[] | undefined;
    FormData!: KSK_DM_NhomDoiTuong_DichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_DM_NhomDoiTuong_DichVu";
    }
}

