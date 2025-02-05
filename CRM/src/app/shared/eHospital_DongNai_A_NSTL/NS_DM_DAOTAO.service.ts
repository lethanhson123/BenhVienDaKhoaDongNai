import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_DAOTAO } from './NS_DM_DAOTAO.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_DAOTAOService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Masodaotao', 'Noidungdaotao', 'Tungay', 'Denngay', 'Giohoc', 'Chiphicongty', 'Chiphicanhan', 'Noidaotao', 'Donvidaotao', 'Hinhthucdaotao', 'Bangcap', 'PhanTramDong'];

    List: NS_DM_DAOTAO[] | undefined;
    ListFilter: NS_DM_DAOTAO[] | undefined;
    FormData!: NS_DM_DAOTAO;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_DAOTAO";
    }
}

