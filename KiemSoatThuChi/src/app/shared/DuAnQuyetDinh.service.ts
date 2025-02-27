﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnQuyetDinhService extends BaseService{
    DisplayColumns001: string[] = ['STT', 'ID', 'NgayKy', 'NgayHieuLuc', 'SoHoSo', 'SoQuyetDinh', 'Name', 'BenDauTuName', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Save'];
    DisplayColumns002: string[] = ['STT', 'NgayKy', 'SoQuyetDinh', 'Name', 'GhiCo', 'GhiNo', 'ConLai'];
    DisplayColumns003: string[] = ['STT', 'ID', 'NgayKy', 'NgayHieuLuc', 'SoHoSo', 'SoQuyetDinh', 'Name', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Save'];
    DisplayColumns004: string[] = ['STT', 'ID', 'NgayKy', 'NgayHieuLuc', 'SoHoSo', 'SoQuyetDinh', 'Name', 'MucDauTu', 'GhiCo', 'GhiNo', 'ConLai', 'Active', 'Save'];
    DisplayColumns005: string[] = ['STT', 'ID', 'NgayKy', 'NgayHieuLuc', 'SoHoSo', 'SoQuyetDinh', 'Name', 'MucDauTu', 'MucDauTuConLai', 'TamUngGhiCo', 'TamUngConLai', 'GhiCo', 'GhiNo', 'ConLai', 'Active', 'Save'];

    List: DuAnQuyetDinh[] | undefined;
    ListFilter: DuAnQuyetDinh[] | undefined;
    FormData!: DuAnQuyetDinh;

    FormDataActive!: DuAnQuyetDinh;
    ListActive: DuAnQuyetDinh[] | undefined;
    ListActive001: DuAnQuyetDinh[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnQuyetDinh";
        this.FormDataActive = {
        };
        this.ListActive = [];
        this.ListActive001 = [];
    }

    GetSQLByThanhVienIDToListAsync() {
        if (this.BaseParameter.ThanhVienID == null) {
            var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
            if (ThanhVienID) {
                this.BaseParameter.ThanhVienID = Number(ThanhVienID);
            }
        }
        let url = this.APIURL + this.Controller + '/GetSQLByThanhVienIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

