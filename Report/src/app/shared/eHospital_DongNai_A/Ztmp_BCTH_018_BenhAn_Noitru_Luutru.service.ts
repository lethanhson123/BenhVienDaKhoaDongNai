import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Ztmp_BCTH_018_BenhAn_Noitru_Luutru } from './Ztmp_BCTH_018_BenhAn_Noitru_Luutru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Ztmp_BCTH_018_BenhAn_Noitru_LuutruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Luutru_Id', 'BenhAn_Id', 'PhongBan_Id', 'NgayVao', 'ThoiGianVao', 'NgayRa', 'ThoiGianRa', 'LyDoVao_Code', 'LyDoRa_Code'];

    List: Ztmp_BCTH_018_BenhAn_Noitru_Luutru[] | undefined;
    ListFilter: Ztmp_BCTH_018_BenhAn_Noitru_Luutru[] | undefined;
    FormData!: Ztmp_BCTH_018_BenhAn_Noitru_Luutru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Ztmp_BCTH_018_BenhAn_Noitru_Luutru";
    }
}

