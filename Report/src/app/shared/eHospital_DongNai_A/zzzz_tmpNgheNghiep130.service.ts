import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzz_tmpNgheNghiep130 } from './zzzz_tmpNgheNghiep130.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzz_tmpNgheNghiep130Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Dictionary_Code', 'Dictionary_Name'];

    List: zzzz_tmpNgheNghiep130[] | undefined;
    ListFilter: zzzz_tmpNgheNghiep130[] | undefined;
    FormData!: zzzz_tmpNgheNghiep130;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzz_tmpNgheNghiep130";
    }
}

