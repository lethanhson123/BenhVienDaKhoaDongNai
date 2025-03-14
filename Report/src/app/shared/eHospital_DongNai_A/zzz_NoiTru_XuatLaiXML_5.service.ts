import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_NoiTru_XuatLaiXML_5 } from './zzz_NoiTru_XuatLaiXML_5.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_NoiTru_XuatLaiXML_5Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'SoBenhAn'];

    List: zzz_NoiTru_XuatLaiXML_5[] | undefined;
    ListFilter: zzz_NoiTru_XuatLaiXML_5[] | undefined;
    FormData!: zzz_NoiTru_XuatLaiXML_5;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_NoiTru_XuatLaiXML_5";
    }
}

