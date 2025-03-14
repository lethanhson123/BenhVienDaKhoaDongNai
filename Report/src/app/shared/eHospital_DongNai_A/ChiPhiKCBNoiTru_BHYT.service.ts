import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChiPhiKCBNoiTru_BHYT } from './ChiPhiKCBNoiTru_BHYT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChiPhiKCBNoiTru_BHYTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'KhamBenh_Id', 'BenhAn_Id', 'BenhNhan_Id', 'DoiTuong_Id', 'SoBHYT', 'NgayVaoVien', 'NgayRaVien', 'SoNgay', 'TienPhong', 'Thuoc', 'DichTruyen', 'XetNghiem', 'SieuAm', 'DienTim', 'DienNao', 'XQuang', 'CT', 'NoiSoi', 'ThuThuat', 'VTYT', 'DichVuYTe', 'Khac'];

    List: ChiPhiKCBNoiTru_BHYT[] | undefined;
    ListFilter: ChiPhiKCBNoiTru_BHYT[] | undefined;
    FormData!: ChiPhiKCBNoiTru_BHYT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChiPhiKCBNoiTru_BHYT";
    }
}

