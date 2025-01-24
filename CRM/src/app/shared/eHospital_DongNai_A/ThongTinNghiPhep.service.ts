import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongTinNghiPhep } from './ThongTinNghiPhep.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongTinNghiPhepService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NghiPhep_Id', 'SoPhieu', 'LoaiPhieu_Id', 'SoSeri', 'SoKCB', 'BenhNhan_Id', 'TiepNhan_Id', 'KhamBenh_Id', 'BenhAnNoiTru_Id', 'BenhAnNgoaiTru_Id', 'BacSiYeuCau_Id', 'BacSiTruongKhoa_Id', 'BenhVien_Id', 'LyDoNghiPhep_Id', 'NghiTu', 'NghiDen', 'SoNgayNghi', 'SoBHXH', 'SoBHYT', 'HoTenCha', 'HoTenMe', 'MaTheTam', 'MaDonVi', 'TenDonVi', 'DiaChiDonVi', 'ChanDoanICD_Id', 'ChanDoanRaVien', 'PhuongPhapDieuTri', 'DinhChiThaiNghen', 'DinhChiThaiNghen_NguyenNhan', 'DinhChiThaiNghen_TuoiThai', 'GhiChu', 'ThuTruongDonVi_Id', 'NguoiDuyet_Id', 'NgayDuyet', 'NgayCapNhatDuyet', 'DaDuyet', 'NguoiHuy_Id', 'NgayHuy', 'DaHuy', 'NgayRaPhieu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'Attribute6', 'Attribute7', 'Attribute8', 'Attribute9', 'Attribute10', 'Attribute11', 'Attribute12'];

    List: ThongTinNghiPhep[] | undefined;
    ListFilter: ThongTinNghiPhep[] | undefined;
    FormData!: ThongTinNghiPhep;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongTinNghiPhep";
    }
}

