import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucChucDanh } from './DanhMucChucDanh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucChucDanhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Code', 'Name', 'DanhMucUngDungID', 'SortOrder', 'Active', 'Save'];
    DisplayColumns003: string[] = ['STT', 'ID', 'Code', 'Name', 'DanhMucUngDungID', 'GroupOrder', 'SortOrder', 'Active', 'Save'];

    
    List: DanhMucChucDanh[] | undefined;
    ListFilter: DanhMucChucDanh[] | undefined;
    FormData!: DanhMucChucDanh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucChucDanh";
    }
}

