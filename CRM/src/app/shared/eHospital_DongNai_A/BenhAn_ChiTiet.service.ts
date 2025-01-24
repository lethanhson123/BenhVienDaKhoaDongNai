import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_ChiTiet } from './BenhAn_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_ChiTiet_Id', 'BenhAnNgoaiTru_Id', 'BoPhan_Id', 'Value_Id', 'ValueText'];

    List: BenhAn_ChiTiet[] | undefined;
    ListFilter: BenhAn_ChiTiet[] | undefined;
    FormData!: BenhAn_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_ChiTiet";
    }
}

