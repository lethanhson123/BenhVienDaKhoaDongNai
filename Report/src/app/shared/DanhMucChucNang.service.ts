﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucChucNang } from 'src/app/shared/DanhMucChucNang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucChucNangService extends BaseService{
    
    DisplayColumns001: string[] = ['ID', 'ParentID', 'Name', 'Code', 'Display', 'SortOrder', 'Active', 'Save'];

    ListChild: DanhMucChucNang[] | undefined;
    ListParent: DanhMucChucNang[] | undefined;
    List: DanhMucChucNang[] | undefined;
    ListFilter: DanhMucChucNang[] | undefined;
    ListFilter001: DanhMucChucNang[] | undefined;
    FormData!: DanhMucChucNang;

    
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucChucNang";
    }

    GetSQLByThanhVienID_ActiveToListAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetSQLByThanhVienID_ActiveToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByThanhVienID_ActiveToListAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/GetByThanhVienID_ActiveToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

