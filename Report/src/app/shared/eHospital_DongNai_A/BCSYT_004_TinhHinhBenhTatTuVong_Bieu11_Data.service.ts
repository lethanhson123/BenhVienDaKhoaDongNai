import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data } from './BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Chuong', 'Ten', 'ICD10', 'GroupTong', 'Thang', 'Nam', 'C01', 'C02', 'C03', 'C04', 'C05', 'C06', 'C07', 'C08', 'C09', 'C10', 'C11', 'C12', 'C13', 'C14', 'C15', 'C16', 'C17', 'C18', 'STT'];

    List: BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data[] | undefined;
    ListFilter: BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data[] | undefined;
    FormData!: BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data";
    }
}

