# Phần mềm trình chiếu Kinh Thánh và Nhạc Thánh cho hội thánh

## Giới thiệu
QIX.BiblePTT là một dự án tập trung vào chức năng Push-To-Talk (PTT) của Kinh Thánh. Đây là một công cụ hoặc ứng dụng cho phép người dùng tương tác với Kinh Thánh theo cách PTT, có thể dành cho các cuộc thảo luận trực tiếp hoặc các buổi học nhóm.

## Bắt đầu
Để bắt đầu với dự án này, bạn cần thực hiện các bước sau:

### Yêu cầu hệ thống
- .NET 6.0 SDK
- Windows Forms

### Cài đặt
1. Clone repository:
    ```sh
    git clone https://github.com/pyhteam/QIX.BiblePTT.git
    cd QIX.BiblePTT
    ```

2. Cài đặt các phụ thuộc:
    ```sh
    dotnet restore
    ```

3. Chạy ứng dụng:
    ```sh
    dotnet run
    ```

## Cấu trúc dự án
Dự án được tổ chức như sau:

- **QIX.BiblePTT.sln**: Tệp giải pháp chính.
- **README.md**: Tệp hướng dẫn này.
- **QIX.BiblePTT**: Thư mục chính chứa mã nguồn của dự án.
  - **Program.cs**: Điểm vào chính của ứng dụng.
  - **QIX.BiblePTT.csproj**: Tệp dự án định nghĩa các phụ thuộc và cài đặt.
  - **Common**: Chứa các lớp và hàm tiện ích dùng chung.
  - **ControlViews**: Chứa các lớp cho các điều khiển hoặc view tùy chỉnh.
  - **Models**: Chứa các lớp đại diện cho các mô hình dữ liệu.
  - **Properties**: Chứa các tài nguyên và hồ sơ liên quan đến ứng dụng.
  - **Resources**: Chứa hình ảnh và các tài nguyên khác.
  - **Services**: Chứa các lớp dịch vụ để tương tác với dữ liệu của ứng dụng.

## Dự án phụ thuộc
- [Lấy dữ liệu kinh thánh từ www.bible.com](https://github.com/pyhteam/Bible-Craw)
- [Tool xuất ra pptx và convert text Hymn to Json](https://github.com/pyhteam/PythonPPTX)     

## Đóng góp
Chúng tôi hoan nghênh các đóng góp từ cộng đồng. Để đóng góp, vui lòng làm theo các bước sau:

1. Fork repository.
2. Tạo một nhánh mới:
    ```sh
    git checkout -b feature/ten-tinh-nang
    ```
3. Commit các thay đổi của bạn:
    ```sh
    git commit -m 'Thêm tính năng ABC'
    ```
4. Push lên nhánh của bạn:
    ```sh
    git push origin feature/ten-tinh-nang
    ```
5. Tạo một Pull Request.

## Giấy phép
Dự án này là mã nguồn mở và được cấp phép theo giấy phép MIT. Xem tệp [LICENSE](LICENSE) để biết thêm chi tiết.

## Liên hệ
Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua [senms9x@gmail.com](mailto:senms9x@gmail.com).
- [Facebook] (https://www.facebook.com/senms9x/)
- [Zalo] 0369962642


## Tài nguyên
- [Trang chủ dự án](https://github.com/pyhteam/QIX.BiblePTT)
- [Tài liệu .NET](https://docs.microsoft.com/en-us/dotnet/)