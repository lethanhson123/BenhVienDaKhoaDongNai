import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_CONGTAC } from './NS_CONGTAC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_CONGTACService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'Congty', 'Tungay', 'DenNgay', 'Phongban', 'ToNhom', 'Chucvu', 'Congviec'];

    List: NS_CONGTAC[] | undefined;
    ListFilter: NS_CONGTAC[] | undefined;
    FormData!: NS_CONGTAC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_CONGTAC";
    }
}

