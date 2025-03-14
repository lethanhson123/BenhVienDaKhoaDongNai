import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Z_DuTruDuoc } from './Z_DuTruDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Z_DuTruDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_id', 'TenNhaCungCap', 'DonGiaVon', 'ChungTuChiTiet_id'];

    List: Z_DuTruDuoc[] | undefined;
    ListFilter: Z_DuTruDuoc[] | undefined;
    FormData!: Z_DuTruDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Z_DuTruDuoc";
    }
}

