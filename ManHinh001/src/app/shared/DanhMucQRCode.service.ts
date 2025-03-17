import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucQRCode } from 'src/app/shared/DanhMucQRCode.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucQRCodeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];
    DisplayColumns02: string[] = ['STT', 'ID', 'Name', 'Code', 'Display', 'Note', 'SortOrder', 'Active', 'Save'];


    List: DanhMucQRCode[] | undefined;
    ListFilter: DanhMucQRCode[] | undefined;
    FormData!: DanhMucQRCode;

    List001: DanhMucQRCode[] | undefined;
    List002: DanhMucQRCode[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucQRCode";
    }

    GetByNumberToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNumberToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }      
}

