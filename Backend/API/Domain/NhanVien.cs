﻿using System.ComponentModel.DataAnnotations;

namespace API.Domain
{
    public class NhanVien
    {
        [Key]
        public int ID_NhanVien { get; set; }

        public string HoTen { get; set; }

        public string GioiTinh { get; set; }

        public string QuocTich { get; set; }

        public DateTime NgaySinh { get; set; }

        public string CMND {  get; set; }

        public string SoNhaTenDuong { get; set; }

        public string PhuongXa { get; set; }

        public string QuanHuyen { get; set; }

        public string ThanhPho { get; set; }

        public string Email { get; set; }

        public string LoaiNhanVien { get; set; }

        public string SoTaiKhoan { get; set; }

        public string NganHang { get; set; }

        public string SoDienThoai { get; set; }

        public TaiKhoan TaiKhoan { get; set;}
        public int TaiKhoanID_TaiKhoan { get; set;}
    }
}
