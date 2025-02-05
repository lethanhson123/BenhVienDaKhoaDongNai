import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_KhoaBangLuong } from './NS_KhoaBangLuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_KhoaBangLuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NS_KhoaBangLuong_Id', 'MaPhongBan', 'Thang', 'Nam', 'Khoa'];

    List: NS_KhoaBangLuong[] | undefined;
    ListFilter: NS_KhoaBangLuong[] | undefined;
    FormData!: NS_KhoaBangLuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_KhoaBangLuong";
    }
}

