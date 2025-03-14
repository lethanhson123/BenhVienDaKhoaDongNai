import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThuPhanUngThuocCoHai_ThuocSuDungDongThoi } from './ThuPhanUngThuocCoHai_ThuocSuDungDongThoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThuocSuDungDongThoi_Id', 'PhanUngThuocCoHai_Id', 'Duoc_Id', 'DonViTinh_Id', 'SoNgay', 'NgayBatDau', 'NgayKetThuc', 'HamLuong'];

    List: ThuPhanUngThuocCoHai_ThuocSuDungDongThoi[] | undefined;
    ListFilter: ThuPhanUngThuocCoHai_ThuocSuDungDongThoi[] | undefined;
    FormData!: ThuPhanUngThuocCoHai_ThuocSuDungDongThoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThuPhanUngThuocCoHai_ThuocSuDungDongThoi";
    }
}

