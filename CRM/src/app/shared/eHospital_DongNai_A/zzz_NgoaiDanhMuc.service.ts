import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_NgoaiDanhMuc } from './zzz_NgoaiDanhMuc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_NgoaiDanhMucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoVaoVien', 'NgayVao', 'NgayRa'];

    List: zzz_NgoaiDanhMuc[] | undefined;
    ListFilter: zzz_NgoaiDanhMuc[] | undefined;
    FormData!: zzz_NgoaiDanhMuc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_NgoaiDanhMuc";
    }
}

