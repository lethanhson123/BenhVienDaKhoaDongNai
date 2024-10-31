import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnQuyetDinhService extends BaseService{
    DisplayColumns001: string[] = ['STT', 'ID', 'NgayKy', 'NgayHieuLuc', 'SoHoSo', 'SoQuyetDinh', 'Name', 'BenDauTuName', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Save'];

    List: DuAnQuyetDinh[] | undefined;
    ListFilter: DuAnQuyetDinh[] | undefined;
    FormData!: DuAnQuyetDinh;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnQuyetDinh";
    }
}

