import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnSanKhoa } from './BenhAnSanKhoa.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnSanKhoaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_Id', 'LoaiPhaThai', 'TaiBienDoPhaThai', 'TrietSanNgoaiThaiKy', 'NhiemTrungVetMo', 'NoiSoi', 'TuyenDuoiChuyen', 'Para1', 'Para2', 'Para3', 'Para4', 'PhuongPhapSinh', 'SoCon'];

    List: BenhAnSanKhoa[] | undefined;
    ListFilter: BenhAnSanKhoa[] | undefined;
    FormData!: BenhAnSanKhoa;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnSanKhoa";
    }
}

