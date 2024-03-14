CREATE TABLE NguoiDung (
    ID NVARCHAR(10) primary key,
    Ten NVARCHAR(MAX),
    GioiTinh NVARCHAR(MAX),
    SDT NVARCHAR(MAX),
    DiaChi NVARCHAR(MAX),
    CCCD NVARCHAR(MAX),
    NgaySinh NVARCHAR(MAX),
    Email NVARCHAR(MAX),
    STK NVARCHAR(MAX),
    SoDU NVARCHAR(MAX),
    ID_nguoi_thue NVARCHAR(MAX),
    TenNguoiThue NVARCHAR(MAX),
    DanhGia NVARCHAR(MAX),
    BinhLuan NVARCHAR(MAX),
    TenNguoiDung NVARCHAR(MAX),
    MatKhau NVARCHAR(MAX),
    VaiTro NVARCHAR(MAX),
);

INSERT INTO NguoiDung (ID, Ten, GioiTinh, SDT, DiaChi, CCCD, NgaySinh, Email, STK, SoDU, ID_nguoi_thue, TenNguoiThue, DanhGia, BinhLuan, TenNguoiDung, MatKhau,VaiTro)
VALUES
    ('1', N'Nguyễn Văn A', N'Nam', '0123456789', N'Hà Nội', '123456789', '1990-01-01', 'nguyenvana@example.com', '1234567890', '5000000', '1', N'Trần Thị X', N'5 sao', N'Rất tốt', N'Adsad', N'@123',N'Người Dùng'),
    ('2', N'Nguyễn Thị B', N'Nữ', '0987654321', N'Hồ Chí Minh', '987654321', '1995-05-05', 'nguyenthib@example.com', '0987654321', '3000000', '2', N'Lê Văn Y', N'4 sao', N'Đạt yêu cầu', N'Bddsad', N'@123',N'Người Dùng'),
    ('3', N'Phạm Văn C', N'Nam', '0123456789', N'Hải Phòng', '123456789', '1985-03-15', 'phamvanc@example.com', '1234567890', '4000000', '3', N'Trần Thị Z', N'3 sao', N'Cần cải thiện', N'Cdsad', N'@123',N'Người Dùng')
select * from NguoiDung