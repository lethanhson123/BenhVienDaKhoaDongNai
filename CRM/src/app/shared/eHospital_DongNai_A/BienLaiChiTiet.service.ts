import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BienLaiChiTiet } from './BienLaiChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BienLaiChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BienLaiChiTiet_Id', 'BienLai_Id', 'NguoiSuDung_Id', 'MachineName', 'Start_Number', 'Current_Number', 'NgaySuDung', 'ThoiGianSuDung', 'HieuLuc'];

    List: BienLaiChiTiet[] | undefined;
    ListFilter: BienLaiChiTiet[] | undefined;
    FormData!: BienLaiChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BienLaiChiTiet";
    }
}

