import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_MauBenh_Column } from './DM_MauBenh_Column.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_MauBenh_ColumnService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MauBenh_Column_Id', 'MauBenh_Id', 'TenColumn', 'TenCot_KetQuaMauBenh', 'KieuDuLieu', 'TamNgung', 'Ma_MauBenh_Column', 'WidthColumn', 'Pos'];

    List: DM_MauBenh_Column[] | undefined;
    ListFilter: DM_MauBenh_Column[] | undefined;
    FormData!: DM_MauBenh_Column;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_MauBenh_Column";
    }
}

