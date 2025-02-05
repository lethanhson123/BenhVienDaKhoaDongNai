import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DSField } from './NS_DSField.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DSFieldService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'Ten', 'Viet', 'Loai', 'BangQH', 'TenTable'];

    List: NS_DSField[] | undefined;
    ListFilter: NS_DSField[] | undefined;
    FormData!: NS_DSField;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DSField";
    }
}

