import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong_GoiDichVu } from './KSK_HopDong_GoiDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDong_GoiDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_HopDong_GoiDichVu_Id', 'HopDong_Id', 'GoiDichVu_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'Attribute6'];

    List: KSK_HopDong_GoiDichVu[] | undefined;
    ListFilter: KSK_HopDong_GoiDichVu[] | undefined;
    FormData!: KSK_HopDong_GoiDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong_GoiDichVu";
    }
}

