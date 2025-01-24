import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Chandoan } from './Chandoan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChandoanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Mã bệnh nhân', 'Tên', 'Chẩn đoán', 'F4'];

    List: Chandoan[] | undefined;
    ListFilter: Chandoan[] | undefined;
    FormData!: Chandoan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Chandoan";
    }
}

