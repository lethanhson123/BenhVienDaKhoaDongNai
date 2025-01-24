import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DangKyHoaDonVAT } from './DangKyHoaDonVAT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DangKyHoaDonVATService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DangKyHoaDon_Id', 'MachineName', 'LoaiHoaDon', 'NgayPhatHanh', 'SoSeries', 'Max_No', 'No_', 'HieuLuc', 'NguoiTao_Id', 'NgayTao'];

    List: DangKyHoaDonVAT[] | undefined;
    ListFilter: DangKyHoaDonVAT[] | undefined;
    FormData!: DangKyHoaDonVAT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DangKyHoaDonVAT";
    }
}

