import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_PhamVi } from './DM_PhamVi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_PhamViService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhamVi_Id', 'MaPhamVi', 'TenPhamVi', 'TenPhamVi_En', 'TenPhamVi_Ru', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute_1', 'Attribute_2', 'Attribute_3', 'Attribute_4', 'Attribute_5', 'Attribute_6', 'Attribute_7', 'Attribute_8', 'Attribute_9', 'Attribute_10', 'Attribute_11', 'Attribute_12', 'Attribute_13', 'Attribute_14'];

    List: DM_PhamVi[] | undefined;
    ListFilter: DM_PhamVi[] | undefined;
    FormData!: DM_PhamVi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_PhamVi";
    }
}

