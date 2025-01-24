import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NhanVien_KSK_NgoaiVien } from './NhanVien_KSK_NgoaiVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NhanVien_KSK_NgoaiVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhanVien_KSK_Id', 'MaNhanVien', 'MaDotKSK', 'KSK_NgoaiVien_Id'];

    List: NhanVien_KSK_NgoaiVien[] | undefined;
    ListFilter: NhanVien_KSK_NgoaiVien[] | undefined;
    FormData!: NhanVien_KSK_NgoaiVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NhanVien_KSK_NgoaiVien";
    }
}

