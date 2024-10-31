import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnThuChiService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'ID', 'NgayBatDau', 'SoChungTu', 'GhiCo', 'GhiNo', 'ConLai', 'DanhMucBieuMauName', 'DanhMucHinhThucThanhToanName', 'Name', 'NguoiThucHienName', 'Save'];
    List: DuAnThuChi[] | undefined;
    ListFilter: DuAnThuChi[] | undefined;
    FormData!: DuAnThuChi;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnThuChi";
    }
}

