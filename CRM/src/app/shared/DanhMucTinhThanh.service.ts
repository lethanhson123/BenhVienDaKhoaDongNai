import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucTinhThanhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'KinhDo', 'ViDo'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'KinhDo', 'ViDo', 'Note', 'SortOrder', 'Active', 'Save'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucTinhThanh";
    }
}

