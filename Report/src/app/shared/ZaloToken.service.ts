import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ZaloToken } from 'src/app/shared/ZaloToken.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ZaloTokenService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'ZaloTokenID', 'DanhMucNgonNguName', 'ZaloTokenName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'NgayGhiNhan', 'AppID', 'SecretKey', 'URL', 'OARefreshToken', 'OAAccessToken', 'Note', 'Active', 'Save'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ZaloToken";
    }
}

