import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_Sai_YL } from './BenhAn_Sai_YL.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_Sai_YLService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoBenhAn', 'HoTen'];

    List: BenhAn_Sai_YL[] | undefined;
    ListFilter: BenhAn_Sai_YL[] | undefined;
    FormData!: BenhAn_Sai_YL;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_Sai_YL";
    }
}

