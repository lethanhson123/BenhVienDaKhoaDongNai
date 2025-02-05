import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NGOAINGU } from './NS_NGOAINGU.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NGOAINGUService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'MaTDNgoaiNgu', 'Trinhdo', 'Nghe', 'Noi', 'Doc', 'Viet', 'TrinhDoChiTiet_Id', 'NgayCap'];

    List: NS_NGOAINGU[] | undefined;
    ListFilter: NS_NGOAINGU[] | undefined;
    FormData!: NS_NGOAINGU;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NGOAINGU";
    }
}

