import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DinhNghiaTuDienVietAnh } from './DinhNghiaTuDienVietAnh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DinhNghiaTuDienVietAnhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DinhNghia_ID', 'MaDinhNghia', 'Language_Id', 'FormName', 'NoiDung', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5'];

    List: DinhNghiaTuDienVietAnh[] | undefined;
    ListFilter: DinhNghiaTuDienVietAnh[] | undefined;
    FormData!: DinhNghiaTuDienVietAnh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DinhNghiaTuDienVietAnh";
    }
}

