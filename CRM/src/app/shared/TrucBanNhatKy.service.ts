import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TrucBanNhatKy } from 'src/app/shared/TrucBanNhatKy.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TrucBanNhatKyService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'TrucBanNhatKyID', 'DanhMucNgonNguName', 'TrucBanNhatKyName'];

    DisplayColumns002: string[] = ['STT', 'ID', 'NgayGhiNhan', 'Display', 'Khu', 'Tang', 'Khoa', 'Phong', 'TaiKhoan', 'ThucTrang', 'XuLy', 'Active', 'Save'];

    List: TrucBanNhatKy[] | undefined;
    ListFilter: TrucBanNhatKy[] | undefined;
    FormData!: TrucBanNhatKy;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TrucBanNhatKy";
    }
}

