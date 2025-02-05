import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_CONGTAC_UV } from './NS_CONGTAC_UV.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_CONGTAC_UVService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'MaUngVien', 'Congty', 'Tungay', 'Denngay', 'Phongban', 'ToNhom', 'Chucvu', 'Congviec'];

    List: NS_CONGTAC_UV[] | undefined;
    ListFilter: NS_CONGTAC_UV[] | undefined;
    FormData!: NS_CONGTAC_UV;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_CONGTAC_UV";
    }
}

