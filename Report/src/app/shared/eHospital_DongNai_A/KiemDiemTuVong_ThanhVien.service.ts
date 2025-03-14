import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KiemDiemTuVong_ThanhVien } from './KiemDiemTuVong_ThanhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KiemDiemTuVong_ThanhVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KiemDiemTuVong_ThanhVien_Id', 'KiemDiemTuVong_Id', 'NhanVien_Id', 'VaiTro_Id'];

    List: KiemDiemTuVong_ThanhVien[] | undefined;
    ListFilter: KiemDiemTuVong_ThanhVien[] | undefined;
    FormData!: KiemDiemTuVong_ThanhVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KiemDiemTuVong_ThanhVien";
    }
}

