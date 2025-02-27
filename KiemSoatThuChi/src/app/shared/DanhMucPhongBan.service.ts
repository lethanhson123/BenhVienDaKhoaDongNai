﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucPhongBanService extends BaseService{

    DisplayColumns: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Note', 'SortOrder', 'Active', 'Save'];

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucPhongBan";
    }
}

