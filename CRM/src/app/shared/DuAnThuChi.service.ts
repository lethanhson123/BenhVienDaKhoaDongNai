﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnThuChiService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'ID', 'NgayGhiNhan', 'SoChungTu', 'SoButToan', 'Name', 'DuAnQuyetDinhSoQuyetDinh', 'GhiCo', 'GhiNo', 'ConLai', 'DanhMucBieuMauName', 'DanhMucHinhThucThanhToanName', 'Active', 'Save'];
    List: DuAnThuChi[] | undefined;
    ListFilter: DuAnThuChi[] | undefined;
    FormData!: DuAnThuChi;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnThuChi";
    }

    GetSQLByCodeToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/GetSQLByCodeToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetBySoQuyetDinhToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/GetBySoQuyetDinhToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

