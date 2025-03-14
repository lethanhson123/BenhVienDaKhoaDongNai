import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_NoiTru_XuatLaiXML } from './zzz_NoiTru_XuatLaiXML.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_NoiTru_XuatLaiXMLService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'SoBenhAn'];

    List: zzz_NoiTru_XuatLaiXML[] | undefined;
    ListFilter: zzz_NoiTru_XuatLaiXML[] | undefined;
    FormData!: zzz_NoiTru_XuatLaiXML;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_NoiTru_XuatLaiXML";
    }
}

