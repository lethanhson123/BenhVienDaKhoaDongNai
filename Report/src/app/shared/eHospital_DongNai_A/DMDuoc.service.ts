import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DMDuoc } from './DMDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DMDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'loaivattu', 'ma', 'tenduoc', 'ĐVT', 'hamluong', 'loaiduoc', 'phannhomduoc', 'hangsanxuat', 'nuocsanxuat', 'Hoatchat', 'BHYT', 'duongdung', 'giaban', 'quocgia_id', 'duongdung_id'];

    List: DMDuoc[] | undefined;
    ListFilter: DMDuoc[] | undefined;
    FormData!: DMDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DMDuoc";
    }
}

