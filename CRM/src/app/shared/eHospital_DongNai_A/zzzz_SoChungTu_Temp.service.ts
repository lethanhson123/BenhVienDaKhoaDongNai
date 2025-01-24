import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzz_SoChungTu_Temp } from './zzzz_SoChungTu_Temp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzz_SoChungTu_TempService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoChungTu', 'SoChungTu_new'];

    List: zzzz_SoChungTu_Temp[] | undefined;
    ListFilter: zzzz_SoChungTu_Temp[] | undefined;
    FormData!: zzzz_SoChungTu_Temp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzz_SoChungTu_Temp";
    }
}

