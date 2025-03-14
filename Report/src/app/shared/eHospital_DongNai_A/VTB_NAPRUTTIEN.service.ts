import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { VTB_NAPRUTTIEN } from './VTB_NAPRUTTIEN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class VTB_NAPRUTTIENService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NAPRUTTIEN_ID', 'MAGIAODICH', 'BENHNHAN_ID', 'MAYTE', 'CMND', 'SOTHEATM', 'NGAYPHATHANHTHE', 'TENCHUTHE', 'LOAITHE_ID', 'LOAIGIAODICH', 'SOTIEN', 'THOIGIANGIAODICH', 'TRANGTHAIGIAODICH', 'NGUOITAO_ID', 'NGAYTAO', 'NGUOICAPNHAT_ID', 'NGAYCAPNHAT'];

    List: VTB_NAPRUTTIEN[] | undefined;
    ListFilter: VTB_NAPRUTTIEN[] | undefined;
    FormData!: VTB_NAPRUTTIEN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "VTB_NAPRUTTIEN";
    }
}

