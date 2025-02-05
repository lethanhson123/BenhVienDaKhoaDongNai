import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_RP_DSField } from './NS_RP_DSField.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_RP_DSFieldService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'Ten', 'Viet', 'Loai', 'BangQH', 'TenTable', 'SapXep'];

    List: NS_RP_DSField[] | undefined;
    ListFilter: NS_RP_DSField[] | undefined;
    FormData!: NS_RP_DSField;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_RP_DSField";
    }
}

