import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuSoKetDieuTri } from './PhieuSoKetDieuTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuSoKetDieuTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6', 'Field_7'];

    List: PhieuSoKetDieuTri[] | undefined;
    ListFilter: PhieuSoKetDieuTri[] | undefined;
    FormData!: PhieuSoKetDieuTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuSoKetDieuTri";
    }
}

