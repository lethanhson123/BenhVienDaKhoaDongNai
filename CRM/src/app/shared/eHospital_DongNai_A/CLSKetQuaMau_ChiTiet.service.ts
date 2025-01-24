import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaMau_ChiTiet } from './CLSKetQuaMau_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaMau_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KetQuaMau_ChiTiet_Id', 'CLSKetQua_Id', 'PTMau_ChiTiet_Id', 'KetQua1', 'KetQua2', 'KetQua3', 'KetQua4', 'KetQua5', 'KetQua6', 'DichVu_Id'];

    List: CLSKetQuaMau_ChiTiet[] | undefined;
    ListFilter: CLSKetQuaMau_ChiTiet[] | undefined;
    FormData!: CLSKetQuaMau_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaMau_ChiTiet";
    }
}

