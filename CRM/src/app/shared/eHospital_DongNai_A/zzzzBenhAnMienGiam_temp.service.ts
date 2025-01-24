import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBenhAnMienGiam_temp } from './zzzzBenhAnMienGiam_temp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBenhAnMienGiam_tempService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_id', 'so_benh_an', 'duoc_id', 'LyDo', 'GhiChu', 'GiaTriMienGiam'];

    List: zzzzBenhAnMienGiam_temp[] | undefined;
    ListFilter: zzzzBenhAnMienGiam_temp[] | undefined;
    FormData!: zzzzBenhAnMienGiam_temp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBenhAnMienGiam_temp";
    }
}

