﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzzBenhAnMienGiam_Temp_All } from './zzzzBenhAnMienGiam_Temp_All.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzzBenhAnMienGiam_Temp_AllService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_id', 'so_benh_an', 'LyDo', 'GhiChu', 'GiaTriMienGiam', 'T_THUOC', 'T_VTYT', 'T_XN', 'T_CDHA', 'T_MAU', 'T_PTTT', 'T_KHAM', 'T_GIUONG', 'T_VCHUYEN', 'CacLoaiTienKhac', 'Duoc_id', 'DichVu_id', 'Loai_IDRef'];

    List: zzzzBenhAnMienGiam_Temp_All[] | undefined;
    ListFilter: zzzzBenhAnMienGiam_Temp_All[] | undefined;
    FormData!: zzzzBenhAnMienGiam_Temp_All;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzzBenhAnMienGiam_Temp_All";
    }
}

