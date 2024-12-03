import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ManHinhTapTinDinhKem } from 'src/app/shared/ManHinhTapTinDinhKem.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ManHinhTapTinDinhKemService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'TongSoGiay'];

    List: ManHinhTapTinDinhKem[] | undefined;
    ListFilter: ManHinhTapTinDinhKem[] | undefined;
    FormData!: ManHinhTapTinDinhKem;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ManHinhTapTinDinhKem";
    }
}

