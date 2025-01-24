import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanXaTriTrong } from './HoiChanXaTriTrong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanXaTriTrongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanXaTriTrong_Id', 'SoPhieu', 'BacSiChuNhiem_Id', 'BacSi_Id', 'KiThuatVienGMHS_Id', 'BenhAn_Id', 'KPS', 'CanNang', 'HuyetAp', 'Mach', 'NhietDo', 'XQuangPhoi', 'XQuangKhac', 'SieuAm', 'CTMRI', 'NoiSoi', 'DienTamDo', 'NhomMau', 'DungTichHongCau', 'BachCau', 'HuyetSacTo', 'HongCau', 'TieuCau', 'UreHuyet', 'Creatinin', 'ProteinToanPhan', 'DuongHuyet', 'HBsAg', 'HIV', 'VDRLBW', 'HuyetHoc', 'SinhHoa', 'ChucNangGan', 'NuocTieu', 'XetNghiemKhac', 'DauHieuSinhHocBuou', 'GPBL', 'ChanDoan', 'LieuPhapXaTriTrong', 'LieuLuong', 'ThoiGian', 'BacSiThucHien_Id', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NgayTao'];

    List: HoiChanXaTriTrong[] | undefined;
    ListFilter: HoiChanXaTriTrong[] | undefined;
    FormData!: HoiChanXaTriTrong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanXaTriTrong";
    }
}

