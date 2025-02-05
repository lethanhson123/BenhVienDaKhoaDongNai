import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DAOTAO } from './NS_DAOTAO.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DAOTAOService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Masodaotao', 'Manhanvien', 'Chiphicongtytra', 'Chiphicanhantra', 'Danhgia', 'Dutru1', 'Dutru2', 'Dutru3', 'Dutru4', 'Dutru5', 'KetQua', 'SoBuoiDiHoc', 'LoaiDiHoc_Id'];

    List: NS_DAOTAO[] | undefined;
    ListFilter: NS_DAOTAO[] | undefined;
    FormData!: NS_DAOTAO;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DAOTAO";
    }
}

