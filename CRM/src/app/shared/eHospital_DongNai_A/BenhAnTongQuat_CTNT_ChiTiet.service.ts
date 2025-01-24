import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_CTNT_ChiTiet } from './BenhAnTongQuat_CTNT_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_CTNT_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Gio', 'Mach', 'HuyenApCao', 'HuyenApThap', 'VTMau', 'ALTM', 'UFThuc', 'XuTri', 'TenDD'];

    List: BenhAnTongQuat_CTNT_ChiTiet[] | undefined;
    ListFilter: BenhAnTongQuat_CTNT_ChiTiet[] | undefined;
    FormData!: BenhAnTongQuat_CTNT_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_CTNT_ChiTiet";
    }
}

