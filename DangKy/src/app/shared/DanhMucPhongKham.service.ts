import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucPhongKham } from 'src/app/shared/DanhMucPhongKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucPhongKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];

    DisplayColumns02: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Note', 'SortOrder', 'Active', 'Save'];

    DisplayColumns03: string[] = ['STT', 'ID', 'ParentID', 'DanhMucKhoaChuyenMonID', 'Name', 'Code', 'Note', 'SortOrder', 'Active', 'Save'];

    DisplayColumns04: string[] = ['STT', 'ParentName', 'DanhMucKhoaChuyenMonName', 'Name', 'SortOrder', 'Active'];

    List: DanhMucPhongKham[] | undefined;
    ListFilter: DanhMucPhongKham[] | undefined;
    FormData!: DanhMucPhongKham;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucPhongKham";
    }
    GetSQLByParentIDToListAsync() {
        let url = this.APIURL + this.Controller + '/GetSQLByParentIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetSQLBySearchStringViaIDToListAsync() {
        let url = this.APIURL + this.Controller + '/GetSQLBySearchStringViaIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetSQLBySearchStringViaNameToListAsync() {
        let url = this.APIURL + this.Controller + '/GetSQLBySearchStringViaNameToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

