import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CapNhat_ICD } from './CapNhat_ICD.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CapNhat_ICDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Mã bệnh nhân', 'Tên', 'Chẩn đoán', 'F4'];

    List: CapNhat_ICD[] | undefined;
    ListFilter: CapNhat_ICD[] | undefined;
    FormData!: CapNhat_ICD;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CapNhat_ICD";
    }
}

