using BLL.Interface;
using BLL;
using DAL.Helper.Interface;
using DAL.Helper;
using DAL.Interface;
using DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IDoNoiThatBusiness, DoNoiThatBusiness>();
builder.Services.AddTransient<IDoNoiThatDAL, DoNoiThatDAL>();
builder.Services.AddTransient<IDataHelper, DataBaseAccess>();

builder.Services.AddTransient<ILoaiDoNoiThatBusiness, LoaiDoNoiThatBusiness>();
builder.Services.AddTransient<ILoaiDoNoiThatDAL, LoaiDoNoiThatDAL>();

builder.Services.AddTransient<INhaCungCapBussiness, NhaCungCapBusiness>();
builder.Services.AddTransient<INhaCungCapDAL, NhaCungCapDAL>();

builder.Services.AddTransient<IHoaDonNhapBusiness, HoaDonNhapBusiness>();
builder.Services.AddTransient<IHoaDonNhapDAL, HoaDonNhapDAL>();

builder.Services.AddTransient<INhanVienBusiness, NhanVienBusiness>();
builder.Services.AddTransient<INhanVienDAL, NhanVienDAL>();

builder.Services.AddTransient<IKhachHangBusiness, KhachHangBusiness>();
builder.Services.AddTransient<IKhachHangDAL, KhachHangDAL>();

builder.Services.AddTransient<ITinTucBusiness, TinTucBusiness>();
builder.Services.AddTransient<ITinTucDAL, TinTucDAL>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseStaticFiles();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
