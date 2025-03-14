import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_NgoaiTru_XuatLaiXML } from './zzz_NgoaiTru_XuatLaiXML.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_NgoaiTru_XuatLaiXMLService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'SoTiepNhan'];

    List: zzz_NgoaiTru_XuatLaiXML[] | undefined;
    ListFilter: zzz_NgoaiTru_XuatLaiXML[] | undefined;
    FormData!: zzz_NgoaiTru_XuatLaiXML;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_NgoaiTru_XuatLaiXML";
    }
}

