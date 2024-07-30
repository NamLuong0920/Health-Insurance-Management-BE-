﻿namespace API.DTOs
{
    public class GoiBaoHiemDTO
    {
        public int ID_GoiBaoHiem { get; set; }
        public string TenBaoHiem { get; set; }
        public string TenGoi { get; set; }
        public decimal GiaTien { get; set; }
        public int ThoiHan { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayPhatHanh { get; set; }
        public string TinhTrang { get; set; }
        public string HinhAnh { get; set; }
    }
}