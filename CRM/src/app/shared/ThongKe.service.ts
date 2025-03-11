import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongKe } from './ThongKe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongKeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'BatDau', 'KetThuc'];
    DisplayColumns002: string[] = ['STT', 'ID', 'ParentName', 'Name', 'BatDau', 'KetThuc', 'Active', 'Save'];
    
    List: ThongKe[] | undefined;
    ListFilter: ThongKe[] | undefined;
    FormData!: ThongKe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongKe";
    }
    GetByParentID_Year_Month_DayAsync() {
        if (this.BaseParameter.BatDau == null) {
            this.BaseParameter.BatDau = new Date();
        }
        this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
        this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
        this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
        let url = this.APIURL + this.Controller + '/GetByParentID_Year_Month_DayAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

