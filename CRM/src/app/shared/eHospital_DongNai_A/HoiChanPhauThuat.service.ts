import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanPhauThuat } from './HoiChanPhauThuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanPhauThuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanPhauThuat_Id', 'SoPhieuHoiChanPhauThuat', 'BacSiChuNhiem_Id', 'BacSiGMHS_Id', 'BenhAn_Id', 'KPS', 'CanNang', 'HuyetAp', 'Mach', 'NhietDo', 'XQuangPhoi', 'XQuangKhac', 'SieuAm', 'CTMRI', 'NoiSoi', 'DienTamDo', 'NhomMau', 'DungTichHongCau', 'BachCau', 'HongCau', 'HuyetSacTo', 'TieuCau', 'MauChay', 'MauLang', 'MauDong', 'UreHuyet', 'Creatinin', 'DuongHuyet', 'ProteinToanPhan', 'Glucoza', 'Protein', 'CanLang', 'TiTrong', 'TQ', 'TCK', 'HBsAg', 'HIV', 'AntiHCV', 'SGPT', 'SGOT', 'TiSoAg', 'Prothrombin', 'BilirubinTT', 'BilirubinGT', 'BilirubinTP', 'DauHieuSinhHocBuou', 'GPBLtruocMo', 'ChanDoan', 'TestPNC', 'SM', 'MauDuTru', 'PhuongPhapVoCam', 'PhuongPhapMo', 'KipMo', 'DungCuDacBiet', 'NgayMo', 'KhoaNgoai_Id', 'PhongMo_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: HoiChanPhauThuat[] | undefined;
    ListFilter: HoiChanPhauThuat[] | undefined;
    FormData!: HoiChanPhauThuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanPhauThuat";
    }
}

