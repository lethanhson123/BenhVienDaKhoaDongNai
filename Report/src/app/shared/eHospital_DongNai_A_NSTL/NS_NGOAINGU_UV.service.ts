import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NGOAINGU_UV } from './NS_NGOAINGU_UV.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NGOAINGU_UVService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'MaUngVien', 'MaTDNgoaiNgu', 'Trinhdo', 'Nghe', 'Noi', 'Doc', 'Viet'];

    List: NS_NGOAINGU_UV[] | undefined;
    ListFilter: NS_NGOAINGU_UV[] | undefined;
    FormData!: NS_NGOAINGU_UV;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NGOAINGU_UV";
    }
}

