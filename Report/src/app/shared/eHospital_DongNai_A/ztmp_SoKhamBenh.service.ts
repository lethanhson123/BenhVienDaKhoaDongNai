import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_SoKhamBenh } from './ztmp_SoKhamBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_SoKhamBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TuNgay', 'DenNgay', 'MaYTe', 'TenBenhNhan', 'NamSinh', 'Tuoi', 'str1', 'SoBHYT', 'str2', 'str3', 'KhoaPhong1', 'Date1', 'str4', 'str5'];

    List: ztmp_SoKhamBenh[] | undefined;
    ListFilter: ztmp_SoKhamBenh[] | undefined;
    FormData!: ztmp_SoKhamBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_SoKhamBenh";
    }
}

