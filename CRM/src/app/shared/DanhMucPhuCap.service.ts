﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucPhuCap } from './DanhMucPhuCap.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucPhuCapService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Code', 'Name', 'HeSo', 'DanhMucUngDungID', 'SortOrder', 'Active', 'Save'];
    
    List: DanhMucPhuCap[] | undefined;
    ListFilter: DanhMucPhuCap[] | undefined;
    FormData!: DanhMucPhuCap;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucPhuCap";
    }
}

