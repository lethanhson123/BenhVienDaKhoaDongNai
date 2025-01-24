import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_NgayNghiLe } from './DM_NgayNghiLe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_NgayNghiLeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NgayLe_Id', 'Nam', 'NgayNghi', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_NgayNghiLe[] | undefined;
    ListFilter: DM_NgayNghiLe[] | undefined;
    FormData!: DM_NgayNghiLe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_NgayNghiLe";
    }
}

