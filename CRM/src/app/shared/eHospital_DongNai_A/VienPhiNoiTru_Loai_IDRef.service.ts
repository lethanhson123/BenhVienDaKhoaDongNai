import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { VienPhiNoiTru_Loai_IDRef } from './VienPhiNoiTru_Loai_IDRef.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class VienPhiNoiTru_Loai_IDRefService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Loai_IDRef', 'Loai_IDRef_Name', 'TableName', 'PhanNhom', 'TenPhanNhom'];

    List: VienPhiNoiTru_Loai_IDRef[] | undefined;
    ListFilter: VienPhiNoiTru_Loai_IDRef[] | undefined;
    FormData!: VienPhiNoiTru_Loai_IDRef;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "VienPhiNoiTru_Loai_IDRef";
    }
}

