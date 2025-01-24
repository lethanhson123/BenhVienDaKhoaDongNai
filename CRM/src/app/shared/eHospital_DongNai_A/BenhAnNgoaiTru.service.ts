import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnNgoaiTru } from './BenhAnNgoaiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnNgoaiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnNgoaiTru_Id', 'SoBenhAn', 'SoLuuTru', 'LoaiBenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'KhoaDieuTri_Id', 'BacSiDieuTri_Id', 'DieuTriTuNgay', 'DieuTriDenNgay', 'QuaTrinhBenhLy', 'TienSuBanThan', 'TienSuGiaDinh', 'KhamToanThan', 'KhamCacBoPhan', 'DaXuLy', 'Mach', 'HuyetApCao', 'HuyetApThap', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'TangNguoi', 'ICD_NoiGioiThieu', 'ChanDoanNoiGioiThieu', 'ICD_KhamBenh', 'ChanDoanKhamBenh', 'ICD_BenhChinh', 'ICD_BenhPhu', 'ChanDoanRaVien', 'NgayLapBenhAn', 'NgayNhapVien', 'ThoiGianNhapVien', 'NgayRaVien', 'ThoiGianRaVien', 'LyDoNhapVien_Id', 'LyDoRaVien_Id', 'KetQuaDieuTri_Id', 'TinhTrangRaVien', 'PhuongPhapDieuTri', 'KeHoachDieuTri', 'TrangThai', 'KhoaBenhAn', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KeHoachDieuTri_Id', 'PhuongPhapDieuTri_Id', 'TangTruong', 'MucTieuDieuTri', 'MucTieuDieuTri_Id', 'HuongDieuTriRaVien', 'XetNghiem', 'ChuyenDenBenhVien_Id', 'ChuyenVien_Id'];

    List: BenhAnNgoaiTru[] | undefined;
    ListFilter: BenhAnNgoaiTru[] | undefined;
    FormData!: BenhAnNgoaiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnNgoaiTru";
    }
}

