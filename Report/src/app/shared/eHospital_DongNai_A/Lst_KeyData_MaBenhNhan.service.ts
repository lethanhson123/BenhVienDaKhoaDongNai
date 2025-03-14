import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Lst_KeyData_MaBenhNhan } from './Lst_KeyData_MaBenhNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Lst_KeyData_MaBenhNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KeyType', 'KeyYear', 'KeyMonth', 'KeyDay', 'Segment_1', 'Segment_2', 'Segment_3', 'KeyValue'];

    List: Lst_KeyData_MaBenhNhan[] | undefined;
    ListFilter: Lst_KeyData_MaBenhNhan[] | undefined;
    FormData!: Lst_KeyData_MaBenhNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Lst_KeyData_MaBenhNhan";
    }
}

