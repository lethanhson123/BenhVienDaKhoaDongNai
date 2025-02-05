import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DIEUCHUYEN } from './NS_DIEUCHUYEN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DIEUCHUYENService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'NgayDieuChuyen', 'Ngayhieuluc', 'MaPhongBanCu', 'MaChucVuCu', 'MaPhongBanMoi', 'MaChucVuMoi'];

    List: NS_DIEUCHUYEN[] | undefined;
    ListFilter: NS_DIEUCHUYEN[] | undefined;
    FormData!: NS_DIEUCHUYEN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DIEUCHUYEN";
    }
}

