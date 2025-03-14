import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocGiaVon } from './DuocGiaVon.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocGiaVonService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocGiaVon_Id', 'DuocKyTonKho_Id', 'Duoc_Id', 'DonGiaVon', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocGiaVon[] | undefined;
    ListFilter: DuocGiaVon[] | undefined;
    FormData!: DuocGiaVon;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocGiaVon";
    }
}

