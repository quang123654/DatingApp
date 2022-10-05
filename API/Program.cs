using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build -  tạo các dịch vụ đã đăng ký trả về WebHost
            // Run - chạy ứng dụng web
            CreateHostBuilder(args).Build().Run();
        }


    // Phương thức CreateHostBuilder trả về đối tượng triển khai từ lớp IHostBuilder là HostBuilderđể thiết lập các tính năng, cấu hình chính chính của WebHost.
    // Phương thức Build trả về giao diện IWebHost, bạn có thể sử dụng Interface này để truy cập các dependency được inject bằng cách truy cập thuộc tính Services, các đặc tính của server với thuộc tính ServerFeatures, gọi Run để bắt đầu lắng nghe trên cổng thiết lập.
    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // webBuilder đối tượng lớp WebHostBuilder để cấu hình, đăng ký các dịch vụ ứng dụng Web
                    // UseStartup chỉ ra lớp khởi chạy ứng dụng (đăng ký dịch vụ)
                    webBuilder.UseStartup<Startup>();
                });
    }
}
