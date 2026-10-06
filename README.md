# Windows Programming with C# - LAB 03 (OOP)

Kho lưu trữ bài tập thực hành môn **Lập trình trên môi trường Windows với C# (Windows Programming with C#)** - **LAB 03: Lập trình Hướng đối tượng (OOP)**:
- Kế thừa (Inheritance) & Đa hình (Polymorphism).
- Nạp chồng toán tử (Operator Overloading) & Bộ chỉ mục (Indexer).
- Quản lý danh sách đối tượng và Đọc/Ghi File.
- Tương tác đối tượng hình học trong không gian tọa độ 2D (Point & Circle).

---

## Danh mục các bài tập trong Solution (`cslab03.sln`)

### 📁 1. `Part1_Bai1_QuanLyHinhHoc`
- **Mô tả**: Quản lý các hình học thông qua quan hệ kế thừa và đa hình.
- **Cấu trúc lớp**:
  - `HinhHoc` (Abstract Base Class): Định nghĩa `DienTich`, `ChuVi`, phương thức trừu tượng `TinhDienTichChuVi()` và `ToString()`.
  - `HinhChuNhat` kế thừa `HinhHoc`: Thuộc tính `ChieuDai`, `ChieuRong`, ghi đè tính chu vi và diện tích.
  - `HinhTron` kế thừa `HinhHoc`: Thuộc tính `BanKinh`, ghi đè tính chu vi ($2\pi r$) và diện tích ($\pi r^2$).
- **Mở rộng Đọc/Ghi File**:
  - Đọc danh sách các hình học từ `input.txt`.
  - Tính tổng diện tích, tổng chu vi, tìm HCN có diện tích lớn nhất và hình tròn có chu vi nhỏ nhất.
  - Xuất báo cáo kết quả ra `output.txt`.

### 📁 2. `Part1_Bai2_QuanLyNhanSu`
- **Mô tả**: Quản lý hệ thống nhân sự phân cấp.
- **Cấu trúc lớp**:
  - `Nguoi`: `HoTen`, `NgaySinh`, `DiaChi`, property tính tuổi `LayTuoi`, phương thức `XemThongTin()`.
  - `SinhVien` kế thừa `Nguoi`: Bổ sung `MaSV`, `MaLop`, `Email`, `DienThoai`.
  - `NhanVien` kế thừa `Nguoi`: Bổ sung `MaNhanVien`, `Email`, `DienThoai`, `NgayLamViec`, `MaCongTy`.

### 📁 3. `Part1_Bai3_LopDaThuc`
- **Mô tả**: Xây dựng lớp biểu diễn đa thức bậc $n$: $P(x) = \sum_{k=0}^n a_k x^k$.
- **Tính năng nổi bật**:
  - Constructor khởi tạo đa thức bậc $n$ hoặc từ mảng hệ số.
  - Property `Bac` trả về bậc cao nhất của đa thức.
  - **Indexer** `this[int k]`: Truy xuất và gán trực tiếp hệ số của số hạng bậc $k$.
  - **Nạp chồng toán tử**: `+` (cộng 2 đa thức), `-` (trừ 2 đa thức).
  - Phương thức `TinhGiaTri(double b)`: Tính giá trị đa thức tại $x = b$.
  - Định dạng hiển thị đẹp mắt theo chuẩn toán học qua `ToString()`.

### 📁 4. `Part2_DuongTronVaDiem`
- **Mô tả**: Biểu diễn đối tượng Điểm (`Diem`) và Đường tròn (`DuongTron`) trong mặt phẳng Oxy.
- **Tính năng**:
  - Lớp `Diem`: Tọa độ $(x, y)$, khoảng cách Euclid giữa 2 điểm.
  - Lớp `DuongTron`: Tâm `Tam` (đối tượng `Diem`), bán kính `BanKinh`, chu vi, diện tích.
  - Xét vị trí tương đối giữa hai đường tròn: Trùng nhau, đồng tâm, ở ngoài nhau, tiếp xúc ngoài, tiếp xúc trong, cắt nhau, chứa nhau.
  - Xét vị trí tương đối giữa một điểm và đường tròn: Nằm trong, nằm trên, nằm ngoài đường tròn.

### 🚀 5. `Lab03_Launcher`
- Menu Console tương tác hỗ trợ chọn và khởi chạy nhanh từng bài tập.

---

## Hướng dẫn thực thi

### Bằng .NET CLI
```bash
# Khởi chạy menu tổng hợp
dotnet run --project Lab03_Launcher/Lab03_Launcher.csproj

# Hoặc chạy trực tiếp từng bài
dotnet run --project Part1_Bai1_QuanLyHinhHoc/Part1_Bai1_QuanLyHinhHoc.csproj
dotnet run --project Part1_Bai2_QuanLyNhanSu/Part1_Bai2_QuanLyNhanSu.csproj
dotnet run --project Part1_Bai3_LopDaThuc/Part1_Bai3_LopDaThuc.csproj
dotnet run --project Part2_DuongTronVaDiem/Part2_DuongTronVaDiem.csproj
```
