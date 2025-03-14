import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_ICD } from './KhamBenh_ICD.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_ICDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_ICD_Id', 'KhamBenh_Id', 'ICD_Id', 'idx'];

    List: KhamBenh_ICD[] | undefined;
    ListFilter: KhamBenh_ICD[] | undefined;
    FormData!: KhamBenh_ICD;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_ICD";
    }
}

