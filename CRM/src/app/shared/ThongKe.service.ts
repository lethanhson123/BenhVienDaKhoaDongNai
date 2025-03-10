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
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'Code', 'BatDau', 'KetThuc', 'Active'];
    
    List: ThongKe[] | undefined;
    ListFilter: ThongKe[] | undefined;
    FormData!: ThongKe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongKe";
    }
}

