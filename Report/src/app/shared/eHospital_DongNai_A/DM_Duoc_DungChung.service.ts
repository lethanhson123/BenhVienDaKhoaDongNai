import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_Duoc_DungChung } from './DM_Duoc_DungChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_Duoc_DungChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_ID', 'SoDangKy', 'DongGoi', 'DonGia', 'SoLuong', 'MaCSKCB', 'NhaThau', 'QuyetDinh', 'CongBo', 'LoaiThuoc', 'LoaiThau', 'NhomThau', 'MaHieu', 'QuyCach', 'DinhMuc', 'Att_1', 'Att_2', 'Att_3', 'Att_4', 'Att_5', 'Att_6', 'Att_7', 'Att_8', 'Att_9', 'Att_10', 'Att_11', 'Att_12', 'Atribute_13', 'Atribute_14', 'Atribute_15', 'Atribute_16', 'Atribute_17', 'Atribute_18', 'Atribute_19', 'Atribute_20', 'Atribute_21', 'Atribute_22', 'Atribute_23', 'Atribute_24', 'Atribute_25', 'Atribute_26', 'NhomVTYT_TT04_ID'];

    List: DM_Duoc_DungChung[] | undefined;
    ListFilter: DM_Duoc_DungChung[] | undefined;
    FormData!: DM_Duoc_DungChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_Duoc_DungChung";
    }
}

