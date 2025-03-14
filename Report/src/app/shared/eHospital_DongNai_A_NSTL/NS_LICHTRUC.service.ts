import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_LICHTRUC } from './NS_LICHTRUC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_LICHTRUCService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'NgayTruc', 'MaCaTruc', 'NoiDungTruc', 'MaPhongBan', 'MaTrachNhiem', 'LeChuNhat', 'ViTri', 'NhiemVu', 'DaTruc'];

    List: NS_LICHTRUC[] | undefined;
    ListFilter: NS_LICHTRUC[] | undefined;
    FormData!: NS_LICHTRUC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_LICHTRUC";
    }
}

