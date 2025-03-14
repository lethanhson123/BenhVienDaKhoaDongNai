import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhanCapCuuChiTiet } from './TiepNhanCapCuuChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhanCapCuuChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhanCapCuuChiTiet_ID', 'TiepNhanCapCuu_ID', 'Loai_ID', 'KetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: TiepNhanCapCuuChiTiet[] | undefined;
    ListFilter: TiepNhanCapCuuChiTiet[] | undefined;
    FormData!: TiepNhanCapCuuChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhanCapCuuChiTiet";
    }
}

