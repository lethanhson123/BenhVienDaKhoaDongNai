import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaMau } from './CLSKetQuaMau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaMauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KetQuaMau_Id', 'CLSKetQua_Id', 'NhomDVHuyetHoc_Id', 'SoLanCoThai', 'SoLanTruyenMau', 'NguoiGiaoMau_Id', 'NguoiNhanMau_Id', 'NgayNhan', 'GhiChu', 'KetLuan'];

    List: CLSKetQuaMau[] | undefined;
    ListFilter: CLSKetQuaMau[] | undefined;
    FormData!: CLSKetQuaMau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaMau";
    }
}

