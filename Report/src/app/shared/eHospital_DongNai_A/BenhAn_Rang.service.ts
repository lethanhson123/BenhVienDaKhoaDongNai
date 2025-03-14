import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_Rang } from './BenhAn_Rang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_RangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_Rang_Id', 'BenhAnNgoaiTru_Id', 'Rang_Code', 'Value_Id'];

    List: BenhAn_Rang[] | undefined;
    ListFilter: BenhAn_Rang[] | undefined;
    FormData!: BenhAn_Rang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_Rang";
    }
}

