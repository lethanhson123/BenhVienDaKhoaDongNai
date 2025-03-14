import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DeNghiKhenThuong } from './NS_DeNghiKhenThuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DeNghiKhenThuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Thang', 'Nam', 'MaNhanVien', 'GhiChu'];

    List: NS_DeNghiKhenThuong[] | undefined;
    ListFilter: NS_DeNghiKhenThuong[] | undefined;
    FormData!: NS_DeNghiKhenThuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DeNghiKhenThuong";
    }
}

