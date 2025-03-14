import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBenhAnMienGiam } from './zzzzBenhAnMienGiam.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBenhAnMienGiamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_id', 'so_benh_an', 'duoc_id', 'LyDo', 'GhiChu', 'GiaTriMienGiam'];

    List: zzzzBenhAnMienGiam[] | undefined;
    ListFilter: zzzzBenhAnMienGiam[] | undefined;
    FormData!: zzzzBenhAnMienGiam;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBenhAnMienGiam";
    }
}

