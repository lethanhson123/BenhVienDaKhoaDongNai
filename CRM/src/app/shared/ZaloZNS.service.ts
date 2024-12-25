﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ZaloZNS } from 'src/app/shared/ZaloZNS.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ZaloZNSService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'ZaloZNSID', 'DanhMucNgonNguName', 'ZaloZNSName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'Code', 'TypeName', 'Note', 'SortOrder', 'Active', 'Save'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ZaloZNS";
    }
}

