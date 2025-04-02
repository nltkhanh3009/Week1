# Tuần 1
## Tìm hiểu:
#### 1. Markdown: là ngôn ngữ đánh dáu văn bản, giúp đọc dễ dàng mà không cần làm việc với HTML
link tham khảo: [Markdown](https://www.markdownguide.org/basic-syntax/)

#### 2. asp.net framework 			<>	asp.net core:
- đều là công cụ hỗ trợ phát triển website
+ chạy thuần trên window 		|	chạy được trên win, mac, linux
+ cần quy mô lớn, tải cao 		|	tối ưu hơn (đặc biệt là web app và microservice)
+ close source				|	open source
+ web truyền thống (WF,MVC),API		|	web hiện đại (MVC, Razor Pages), hỗ trợ middleware & RESTful API và GraphQL
+ hỗ trợ container			|	tối ưu hóa container và microservices, dễ triển khai trên Docker
+ Dễ dàng tích hợp với.NET Framework cũ.|	hỗ trợ việc chuyển đổi từ .NET Framework lên .NET Core
+ có nhiều công và thư viện (lỗi thời)	|	có nhiều thư viện mới, tối ưu hóa cho môi trường hiện đại

#### 3. Mô hình MVC, MVVM: giúp tách biệt các phần của ứng dụng để dễ dàng duy trì và phát triển.
- MVC (Model View Controller):
  + Người dùng tương tác với View -gửi yêu cầu-> Controller -xử lí yêu cầu,tương tác-> Model 
  + Model -xử lí dữ liệu, trả kết quả-> Controller -cập nhật-> View.

- MVVM (Model- View - ViewModel):
  + Người dùng tương tác với View -kết nối qua data binding-> ViewModel -tương tác, xử lí logic-> Model
  + Model -xử lí dữ liệu, trả kết quả-> ViewModel -cập nhật-> View.

link tham khảo: [MVC-MVVM](https://svnhostingcomparison.com/mvc-mvp-va-mvvm-la-gi/)

#### 4. OOP (Object Oriented Programming): 
Tập trung vào các đối tượng thao tác hơn là logic để thao tác chúng, dễ quản lý code, tái sử dụng được và dễ bảo trì.Gồm:
- 4 đặc tính: Trừu tượng, Đóng gói, Đa hình, Kế thừa
	+ Tính trừu tượng: giúp loại bỏ những thứ phức tạp, không cần thiết của đối tượng và chỉ tập trung vào những gì cốt lõi, quan trọng.
	+ Tính đóng gói: cho phép che giấu thông tin và những tính chất xử lý bên trong của đối tượng.
	+ Tính đa hình: cho phép các đối tượng khác nhau thực thi chức năng giống nhau theo những cách khác nhau.
	+ Tính kế thừa: cho phép xây dựng một lớp Con, kế thừa và tái sử dụng các thuộc tính, phương thức dựa trên lớp Cha đã có trước đó.

- 3 khái niệm: abstract class, interface và static
  + Abstract Class (Lớp trừu tượng) là một lớp không thể được khởi tạo đối tượng trực tiếp. Mục đích của lớp trừu tượng là để cung cấp một lớp cơ sở cho các lớp con kế thừa và triển khai các phương thức của nó. Các lớp kế thừa từ lớp trừu tượng phải cài đặt (implement) các phương thức abstract nếu không sẽ trở thành lớp trừu tượng. Giúp định nghĩa các hành vi chung mà các lớp con phải thực thi.
  + Interface (Giao diện) là một tập hợp các phương thức mà lớp phải cài đặt. Tuy nhiên, interface không có thân hàm cho các phương thức, chỉ khai báo các phương thức. Các lớp implement interface sẽ cung cấp thân hàm cho các phương thức này. Interface thường được sử dụng để định nghĩa một hành vi mà không cần quan tâm đến cách thức thực hiện.
  + Static (Tĩnh) được sử dụng để khai báo các thành phần (biến, phương thức, lớp con) mà có thể được truy cập mà không cần phải tạo một đối tượng của lớp chứa nó.

link tham khảo: [OOP](https://itviec.com/blog/oop-la-gi/)

#### 5. Depedency Injection 
- Là một mẫu thiết kế (design pattern), thay vì một lớp phải tự tạo các đối tượng mà nó phụ thuộc vào, DI sẽ cung cấp các đối tượng này từ bên ngoài giúp
  + Giảm sự phụ thuộc chặt chẽ: Các lớp và thành phần không còn phải tự quản lý các đối tượng mà chúng phụ thuộc vào, dễ dàng thay đổi hoặc thay thế một phần mà không ảnh hưởng đến phần còn lại
  + Dễ kiểm thử
  + Quản lý sự phụ thuộc tập trung: DI cho phép quản lý tất cả các phụ thuộc tại một nơi (thường là một container DI), giúp kiểm soát và cấu hình dễ dàng hơn
- Các vòng đời lifetime: 
	+ Singleton: là một lifetime trong đó một đối tượng chỉ được tạo một lần duy nhất trong suốt vòng đời của ứng dụng và được tái sử dụng ở tất cả các điểm yêu cầu trong ứng dụng.
	+ Transient: là một lifetime trong đó một đối tượng sẽ được tạo mới mỗi khi có yêu cầu từ DI container .
	+ Scope: là một lifetime trong đó đối tượng được tạo mới mỗi khi có một yêu cầu mới và sẽ được sử dụng lại trong suốt quá trình xử lý của yêu cầu đó.

link tham khảo: [Dependency Injection](https://tedu.com.vn/lap-trinh-aspnet-core/vong-doi-cua-dependency-injection-transient-singleton-va-scoped-257.html)

#### 6. Access Modifiers (Mức độ truy cập) 
- Là các từ khóa được sử dụng để xác định phạm vi truy cập của các thành phần trong lớp (class), chẳng hạn như các trường (fields), thuộc tính (properties), phương thức (methods) hoặc lớp con (nested classes). Mức độ truy cập giúp kiểm soát việc ai có thể truy cập và sửa đổi các thành phần này.
- Phạm vi truy cập của các Access Modifiers:
	+ Public: Truy cập ở mọi nơi.
	+ Private: Chỉ trong lớp hiện tại.
	+ Protected: Lớp hiện tại và lớp kế thừa.
	+ Internal: Trong cùng một tập lệnh assembly.

#### 7. Type System (kiểu dữ liệu):
* Kiểu dữ liệu giá trị (Value Types):
- Số nguyên
	+ short: 16bit (vd: short c=5).
	+ ushort: 16bit ko giấu (vd: ushort c=5).
	+ int: 32bit (vd: int a =100).
	+ uint: 32bit ko giấu (vd: uint a =654).
	+ long: 64bit (long b=10B).
	+ ulong: 64bit ko giấu (ulong b=163UL).
	+ byte: 8bit ko giấu (byte d=126).
	+ sbyte: 8bit co giấu (byte d=-126).
- Số thực:
	+ float: số thực 32bit (vd float x=3,14).
	+ double:số thực 64bit (vd double y= 3,141596452).
	+ decimal: số thực 128bit với độ chính xác cao.
- Ký tự: char: chứa 1 kí tự (vd: char name='K').
- Kiểu Boolean(bool): chỉ giá trị true or false .
- Kiểu cấu trúc(struct): chứa nhiều giá trị (vd: struct Point{int X;int Y;}).

* Kiểu dữ liệu tham chiếu (Reference Types):
- Chuỗi (String).
- Mảng (Array).
- Lớp (Class).
- Đối tượng (Object):là kiểu cơ sở cho tất cả các kiểu dữ liệu trong C#.
- delegate: là một kiểu dữ liệu tham chiếu đại diện cho các phương thức có thể được gọi (loại ủy quyền).
(vd: delegate void MyDelegate(string message);)
- Interface.
- dynamic là kiểu dữ liệu đặc biệt trong C# cho phép xác định đối tượng tại thời gian chạy thay vì biên dịch.
(vd: dynamic obj = "Hello, World!";)

* Kiểu Dữ Liệu Nullables (Nullable Types):C# hỗ trợ các kiểu dữ liệu có thể nhận giá trị null thông qua việc sử dụng dấu chấm hỏi ? sau kiểu dữ liệu. Điều này thường dùng với các kiểu giá trị như int?, double?...
(vd: int? age = null; double? price = null;)

* Kiểu enum là kiểu đặc biệt giúp định nghĩa một tập hợp các giá trị có tên.
(vd: 	enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
	Days today = Days.Monday;)

#### 8. Tìm hiểu record, sealed
- record là một kiểu đặc biệt của lớp (class), được thiết kế chủ yếu để lưu trữ dữ liệu.
	+ Bất biến (Immutable): Các thuộc tính của record mặc định là chỉ đọc (read-only), không thể thay đổi giá trị của các thuộc tính sau khi đối tượng đã được khởi tạo.
	+ So sánh dựa trên giá trị.
	+ Biểu thức -with-: Cung cấp khả năng tạo một bản sao mới của đối tượng với một số thuộc tính thay đổi.

- sealed được sử dụng để ngăn không cho một lớp bị kế thừa.
	+ Một lớp được đánh dấu là sealed không thể bị kế thừa.
	+ Có thể áp dụng sealed cho các phương thức trong lớp cơ sở để ngừng việc ghi đè phương thức đó trong lớp con.
