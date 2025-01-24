import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_MauDienCo } from './DM_MauDienCo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_MauDienCoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MauDienCo_Id', 'MaMauDienCo', 'TenMauDienCo', 'TamNgung', 'TemplateFileName', 'MaNhomDichVu', 'Hinh_Width', 'Hinh_Height'];

    List: DM_MauDienCo[] | undefined;
    ListFilter: DM_MauDienCo[] | undefined;
    FormData!: DM_MauDienCo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_MauDienCo";
    }
}

