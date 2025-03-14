import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DongNai_A } from './DongNai_A.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DongNai_AService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaBenhAn'];

    List: DongNai_A[] | undefined;
    ListFilter: DongNai_A[] | undefined;
    FormData!: DongNai_A;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DongNai_A";
    }
}

