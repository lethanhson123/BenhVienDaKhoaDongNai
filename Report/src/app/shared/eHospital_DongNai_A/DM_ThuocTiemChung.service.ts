import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ThuocTiemChung } from './DM_ThuocTiemChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ThuocTiemChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThuocTiemChung_Id', 'Duoc_Id', 'NhomTiemChung_Id'];

    List: DM_ThuocTiemChung[] | undefined;
    ListFilter: DM_ThuocTiemChung[] | undefined;
    FormData!: DM_ThuocTiemChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ThuocTiemChung";
    }
}

