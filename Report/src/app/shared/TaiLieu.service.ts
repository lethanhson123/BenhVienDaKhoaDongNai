import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TaiLieu } from 'src/app/shared/TaiLieu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TaiLieuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'TaiLieuID', 'DanhMucNgonNguName', 'TaiLieuName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'SortOrder', 'FileName', 'Active', 'Save'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TaiLieu";
    }
}

