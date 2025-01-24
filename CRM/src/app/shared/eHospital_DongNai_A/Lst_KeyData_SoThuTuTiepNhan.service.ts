import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Lst_KeyData_SoThuTuTiepNhan } from './Lst_KeyData_SoThuTuTiepNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Lst_KeyData_SoThuTuTiepNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KeyType', 'KeyYear', 'KeyMonth', 'KeyDay', 'Segment_1', 'Segment_2', 'Segment_3', 'KeyValue'];

    List: Lst_KeyData_SoThuTuTiepNhan[] | undefined;
    ListFilter: Lst_KeyData_SoThuTuTiepNhan[] | undefined;
    FormData!: Lst_KeyData_SoThuTuTiepNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Lst_KeyData_SoThuTuTiepNhan";
    }
}

