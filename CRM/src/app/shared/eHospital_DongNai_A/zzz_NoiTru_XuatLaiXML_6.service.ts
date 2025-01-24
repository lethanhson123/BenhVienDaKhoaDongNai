import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_NoiTru_XuatLaiXML_6 } from './zzz_NoiTru_XuatLaiXML_6.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_NoiTru_XuatLaiXML_6Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'SoBenhAn'];

    List: zzz_NoiTru_XuatLaiXML_6[] | undefined;
    ListFilter: zzz_NoiTru_XuatLaiXML_6[] | undefined;
    FormData!: zzz_NoiTru_XuatLaiXML_6;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_NoiTru_XuatLaiXML_6";
    }
}

