using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnKTHP
{
    class Program
    {
        static DoubleLinkedList Library()
        {
            DoubleLinkedList dlist = new DoubleLinkedList();

            dlist.InsertAfter(new Book("B01", "Con chim xanh biếc bay về", "Nguyễn Nhật Ánh", 5.21f, "NHÀ XUẤT BẢN TRẺ", 2020f), "Header");

            dlist.InsertAfter(new Book("B02", "Trên Đường Băng", "Tony Buổi Sáng", 2.78f, "NHÀ XUẤT BẢN TRẺ", 2015f), "B01");

            dlist.InsertAfter(new Book("B03", "Cà phê cùng Tony", "Tony Buổi Sáng", 3.91f, "NHÀ XUẤT BẢN TRẺ", 2014f), "B02");

            dlist.InsertAfter(new Book("B04", "Ngọn đèn không tắt", "Nguyễn Ngọc Tư", 2.46f, "NHÀ XUẤT BẢN TRẺ", 2000f), "B03");

            dlist.InsertAfter(new Book("B05", "Tuổi 20 Tôi Đã Sống Như Một Bông Hoa Dại", "Trang XTD", 2.85f, "NHÀ XUẤT BẢN TRẺ", 2017f), "B04");
            

            return dlist;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Clear();
            Console.WriteLine("\t \t \t ĐỒ ÁN: CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT");
            Console.WriteLine("\t \t \t \t    DANH SÁCH NHÓM:");
            Console.WriteLine("\t \t \t \t 1. MAI TRẦN MỸ UYÊN");
            Console.WriteLine("\t \t \t \t 2. NGÔ THỊ HUYỀN");
            Console.WriteLine("\t \t \t \t 3. HUỲNH TRẦN ANH THY");
            Console.WriteLine("\t \t \t \t 4. ĐẶNG THỊ CẨM TÚ");
            Console.WriteLine("\t \t \t \t 5. HỒ VIỄN TRIẾT");
            Console.WriteLine("\t \t \t \t    ***********");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            DoubleLinkedList list= Library();
            list.DisplayList();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Chọn phương thức mà bạn muốn sử dụng:\n 1. In toàn bộ các thông tin ra" +
                    "\n 2. Xoá bất kì ID nào\n 3. Chèn ở vị trí bất kì\n 4. Xoá thông tin sách đầu tiên sử dụng DeleteFirstNode" +
                    "\n 5. Xoá thông tin sách cuối cùng sử dụng DeleteLastNode\n 6. Chèn thông tin dùng InsertFirst để chèn vào vị trí đầu tiên" +
                    "\n 7. Chèn thông tin dùng InsertLast để chèn vào vị trí cuối cùng \n 8.Chèn thông tin dùng InsertBefore: \n 9. Đảo ngược thứ tự"
                    +"\n 10. Đếm số sách\n 11. Xoá toàn bộ ");

                int yeucau = int.Parse(Console.ReadLine());
                switch (yeucau)
                {
                    case 1:
                        Console.WriteLine("> In toàn bộ thông tin của các quyển sách: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        list.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;   
                        Console.WriteLine("=================================================================");
                        break;
                    case 2:
                        Console.WriteLine("Xóa thông tin của một quyển sách bất kì.");
                        Console.WriteLine();
                        Console.Write("> Thông tin id bạn muốn xoá: ");
                        string did = Console.ReadLine();
                        Console.WriteLine("> Danh sách sau khi đã xóa ID {0}:", did);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist2 = Library();
                        dlist2.Remove(did);
                        dlist2.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 3:
                        Console.WriteLine("Chèn thêm một quyển sách vào sau một vị trí bất kì trong danh sách liên kết.");
                        Console.WriteLine();
                        Console.Write("> Chọn vị trí ID bạn muốn chèn vào (Ex: B01 - nếu muốn chèn sau ID B01): ");
                        string loc = Console.ReadLine();
                        Console.WriteLine("> Danh sách sau khi đã chèn vào sau ID {0}:", loc);
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist3 = Library();
                        dlist3.InsertAfter(new Book("B0X", "Muôn Kiếp Nhân Sinh", "Nguyên Phong", 5f, "First New", 2017f), loc);
                        dlist3.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 4:
                        Console.WriteLine("Xoá thông tin quyển sách đầu tiên.");
                        Console.WriteLine("> Danh sách sau khi xóa quyển sách đầu tiên: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist4 = Library();
                        dlist4.DeleteFirstNode();
                        dlist4.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 5:
                        Console.WriteLine("Xoá thông tin quyển sách cuối cùng.");
                        Console.WriteLine();
                        Console.WriteLine("> Danh sách sau khi xóa quyển sách cuối cùng: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist5 = Library();
                        dlist5.DeleteLastNode();
                        dlist5.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 6:
                        Console.WriteLine("Chèn thêm một quyển sách vào đầu của danh sách liên kết.");
                        Console.WriteLine();
                        Console.WriteLine("> Danh sách sau khi chèn vào đầu danh sách: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist6 = Library();
                        dlist6.InsertFirst(new Book("B0F", "Bad Blood", "Cao Minh", 4.45f, "First New", 2017f));
                        dlist6.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 7:
                        Console.WriteLine("Chèn thêm một quyển sách vào vị trí cuối của danh sách liên kết. ");
                        Console.WriteLine();
                        Console.WriteLine("> Danh sách sau khi chèn vào cuối danh sách: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist7 = Library();
                        dlist7.InsertLast(new Book("B0L", "Black Pear", "Jack Sparrow", 6.44f, "First New", 2005f));
                        dlist7.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 8:
                        Console.WriteLine("Chèn thêm một quyển sách vào trước một ở vị trí bất kì trong danh sách liên kết. ");
                        Console.Write("Chọn vị trí ID muốn chèn vào (ex:B01-nếu muốn chèn trước ID B01): ");
                        loc = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("> Danh sách sau khi đã chèn vào trước ID {0}:", loc);
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist8 = Library();
                        dlist8.InsertBefore(new Book("B0B", "Storytelling With Data", "Wiley", 5f, "Knafic", 2015f), loc);
                        dlist8.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;

                    case 9:
                        Console.WriteLine(" Đảo ngược thứ tự trong danh sách liên kết.");
                        Console.WriteLine(">Danh sách trước khi đảo");
                        Console.ForegroundColor = ConsoleColor.Green;
                        list.Print();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("> Danh sách sau khi đảo ngược: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        list.Reverse();
                        list.Print();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 10:
                        Console.WriteLine("Đếm số quyển sách trong danh sách liên kết.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        DoubleLinkedList dlist10 = Library();
                        dlist10.Count();
                        Console.WriteLine("> Tổng số quyển sách ban đầu là: {0}", dlist10.Count());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    case 11:
                        Console.WriteLine("Xoá toàn bộ thông tin các quyển sách.");
                        Console.WriteLine("> Danh sách ban đầu: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        DoubleLinkedList dlist11 = Library();
                        dlist11.DisplayList();
                        Console.WriteLine("> Danh sách sau khi xóa tất cả sách: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        dlist11.DeleteAll();
                        dlist11.DisplayList();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=================================================================");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Nhập sai! vui lòng nhập 1 số duy nhất hoặc nhập 'exit' để thoát.");
                        break;
                }
            }
            Console.ReadLine();


        }
    }
}
