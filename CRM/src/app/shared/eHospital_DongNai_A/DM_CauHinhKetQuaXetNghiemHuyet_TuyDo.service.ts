import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_CauHinhKetQuaXetNghiemHuyet_TuyDo } from './DM_CauHinhKetQuaXetNghiemHuyet_TuyDo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CauHinhKetQua_Id', 'GiaTriChuan_Id', 'KetQuaCheckList_Id'];

    List: DM_CauHinhKetQuaXetNghiemHuyet_TuyDo[] | undefined;
    ListFilter: DM_CauHinhKetQuaXetNghiemHuyet_TuyDo[] | undefined;
    FormData!: DM_CauHinhKetQuaXetNghiemHuyet_TuyDo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_CauHinhKetQuaXetNghiemHuyet_TuyDo";
    }
}

