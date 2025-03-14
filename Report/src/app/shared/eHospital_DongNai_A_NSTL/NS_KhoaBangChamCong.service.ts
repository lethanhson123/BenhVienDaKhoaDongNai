import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_KhoaBangChamCong } from './NS_KhoaBangChamCong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_KhoaBangChamCongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NS_KhoaBangChamCong_Id', 'MaPhongBan', 'NgayKhoa', 'Thang', 'Nam', 'Khoa', 'TuNgay', 'DenNgay', 'Khoa_LamThem'];

    List: NS_KhoaBangChamCong[] | undefined;
    ListFilter: NS_KhoaBangChamCong[] | undefined;
    FormData!: NS_KhoaBangChamCong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_KhoaBangChamCong";
    }
}

