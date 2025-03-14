import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NhanVien_TTDT_1 } from './NhanVien_TTDT_1.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NhanVien_TTDT_1Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhanVien_Id'];

    List: NhanVien_TTDT_1[] | undefined;
    ListFilter: NhanVien_TTDT_1[] | undefined;
    FormData!: NhanVien_TTDT_1;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NhanVien_TTDT_1";
    }
}

