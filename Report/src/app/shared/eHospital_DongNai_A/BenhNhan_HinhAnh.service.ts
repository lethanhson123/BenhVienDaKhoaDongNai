import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhNhan_HinhAnh } from './BenhNhan_HinhAnh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhNhan_HinhAnhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_HinhAnh_Id', 'BenhNhan_Id', 'HinhAnh', 'ChuKy'];

    List: BenhNhan_HinhAnh[] | undefined;
    ListFilter: BenhNhan_HinhAnh[] | undefined;
    FormData!: BenhNhan_HinhAnh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhNhan_HinhAnh";
    }
}

