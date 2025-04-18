﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSoThamSo } from 'src/app/shared/GoiSoThamSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoThamSoService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'GoiSoThamSoID', 'DanhMucNgonNguName', 'GoiSoThamSoName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'BuocNhay', 'KichThuocChu001', 'KichThuocChu002', 'SortOrder', 'Active', 'Save'];

    List: GoiSoThamSo[] | undefined;
    ListFilter: GoiSoThamSo[] | undefined;
    FormData!: GoiSoThamSo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoThamSo";
    }
}

