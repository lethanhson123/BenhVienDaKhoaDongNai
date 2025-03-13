import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];
    DisplayColumns02: string[] = ['STT', 'ID', 'Name', 'Code', 'Display', 'Note', 'SortOrder', 'Active', 'Save'];


    List: DanhMucDichVu[] | undefined;
    ListFilter: DanhMucDichVu[] | undefined;
    FormData!: DanhMucDichVu;

    List001: DanhMucDichVu[] | undefined;
    List002: DanhMucDichVu[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucDichVu";
    }

    GetAllToListAsync() {
        let url = this.APIURL + this.Controller + '/GetAllToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }   
    GetByIsBHYTToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByIsBHYTToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByGroupOrderToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByGroupOrderToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

