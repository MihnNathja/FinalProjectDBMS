using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }
        public void addService() 
        {
            #region Đồ ăn
            FoodDtg.Columns.Add("MaDV", "Mã dịch vụ");
            FoodDtg.Columns.Add("TenDV", "Tên dịch vụ");
            FoodDtg.Columns.Add("DonGia", "Đơn giá");
            FoodDtg.Columns.Add("SoLuong", "Só lượng");
            FoodDtg.Columns.Add("MoTa", "Mô tả");

            DataGridViewButtonColumn btnXoaDoAn = new DataGridViewButtonColumn();
            btnXoaDoAn.HeaderText = "Xóa dịch vụ";
            btnXoaDoAn.Name = "btnXoa";
            btnXoaDoAn.Text = "Xóa";
            btnXoaDoAn.UseColumnTextForButtonValue = true;
            FoodDtg.Columns.Add(btnXoaDoAn);

            DataGridViewButtonColumn btnChinhSuaDoAn = new DataGridViewButtonColumn();
            btnChinhSuaDoAn.HeaderText = "Chỉnh sửa dịch vụ";
            btnChinhSuaDoAn.Name = "btnChinhSua";
            btnChinhSuaDoAn.Text = "Chỉnh sửa";
            btnChinhSuaDoAn.UseColumnTextForButtonValue = true;
            FoodDtg.Columns.Add(btnChinhSuaDoAn);

            FoodDtg.Rows.Add("DV001", "Mì tôm", "4.400vnđ", "37", "Mì tôm rất ngon");
            FoodDtg.Rows.Add("DV002", "Bánh mì", "5.500vnđ", "25", "Bánh mì truyền thống");
            FoodDtg.Rows.Add("DV003", "Phở bò", "20.000vnđ", "15", "Phở bò thơm ngon");
            FoodDtg.Rows.Add("DV004", "Bún chả", "25.000vnđ", "10", "Bún chả đặc biệt");
            FoodDtg.Rows.Add("DV005", "Gỏi cuốn", "10.000vnđ", "50", "Gỏi cuốn tươi mát");
            FoodDtg.Rows.Add("DV006", "Cơm tấm", "30.000vnđ", "30", "Cơm tấm hảo hạng");
            FoodDtg.Rows.Add("DV007", "Xôi gà", "15.000vnđ", "12", "Xôi gà đậm vị");
            FoodDtg.Rows.Add("DV008", "Bánh xèo", "12.000vnđ", "18", "Bánh xèo giòn tan");
            FoodDtg.Rows.Add("DV009", "Hủ tiếu", "18.000vnđ", "20", "Hủ tiếu đặc biệt");
            FoodDtg.Rows.Add("DV010", "Bánh cuốn", "22.000vnđ", "25", "Bánh cuốn truyền thống");
            FoodDtg.Rows.Add("DV011", "Nem rán", "15.000vnđ", "17", "Nem rán giòn");
            FoodDtg.Rows.Add("DV012", "Cơm rang", "20.000vnđ", "22", "Cơm rang thơm lừng");
            FoodDtg.Rows.Add("DV013", "Cháo gà", "17.000vnđ", "35", "Cháo gà dinh dưỡng");
            FoodDtg.Rows.Add("DV014", "Bánh bèo", "10.000vnđ", "45", "Bánh bèo dân dã");
            FoodDtg.Rows.Add("DV015", "Bánh bao", "8.000vnđ", "40", "Bánh bao nóng");
            FoodDtg.Rows.Add("DV016", "Mì quảng", "25.000vnđ", "32", "Mì quảng đậm đà");
            #endregion          
            #region Thức uống
            DrinkingDtg.Columns.Add("MaDV", "Mã dịch vụ");
            DrinkingDtg.Columns.Add("TenDV", "Tên dịch vụ");
            DrinkingDtg.Columns.Add("DonGia", "Đơn giá");
            DrinkingDtg.Columns.Add("SoLuong", "Só lượng");
            DrinkingDtg.Columns.Add("MoTa", "Mô tả");

            DataGridViewButtonColumn btnXoaThucUong = new DataGridViewButtonColumn();
            btnXoaThucUong.HeaderText = "Xóa dịch vụ";
            btnXoaThucUong.Name = "btnXoa";
            btnXoaThucUong.Text = "Xóa";
            btnXoaThucUong.UseColumnTextForButtonValue = true;
            DrinkingDtg.Columns.Add(btnXoaThucUong);

            DataGridViewButtonColumn btnChinhSuaThucUong = new DataGridViewButtonColumn();
            btnChinhSuaThucUong.HeaderText = "Chỉnh sửa dịch vụ";
            btnChinhSuaThucUong.Name = "btnChinhSua";
            btnChinhSuaThucUong.Text = "Chỉnh sửa";
            btnChinhSuaThucUong.UseColumnTextForButtonValue = true;
            DrinkingDtg.Columns.Add(btnChinhSuaThucUong);

            DrinkingDtg.Rows.Add("DV001", "Coca-Cola", "10.000vnđ", "50", "Nước giải khát có ga");
            DrinkingDtg.Rows.Add("DV002", "Pepsi", "10.000vnđ", "45", "Nước giải khát có ga");
            DrinkingDtg.Rows.Add("DV003", "Sting", "12.000vnđ", "40", "Nước tăng lực");
            DrinkingDtg.Rows.Add("DV004", "7Up", "9.000vnđ", "60", "Nước giải khát không ga");
            DrinkingDtg.Rows.Add("DV005", "Nước cam ép", "15.000vnđ", "30", "Nước cam tươi nguyên chất");
            DrinkingDtg.Rows.Add("DV006", "Trà đào", "18.000vnđ", "35", "Trà đào thơm ngon");
            DrinkingDtg.Rows.Add("DV007", "Cà phê sữa", "20.000vnđ", "25", "Cà phê sữa đậm vị");
            DrinkingDtg.Rows.Add("DV008", "Cà phê đen", "15.000vnđ", "40", "Cà phê đen truyền thống");
            DrinkingDtg.Rows.Add("DV009", "Nước dừa", "12.000vnđ", "50", "Nước dừa tươi mát");
            DrinkingDtg.Rows.Add("DV010", "Sữa tươi", "10.000vnđ", "45", "Sữa tươi tiệt trùng");
            DrinkingDtg.Rows.Add("DV011", "Trà xanh", "8.000vnđ", "55", "Trà xanh giải nhiệt");
            DrinkingDtg.Rows.Add("DV012", "Nước chanh", "7.000vnđ", "60", "Nước chanh tươi mát");
            DrinkingDtg.Rows.Add("DV013", "Sinh tố bơ", "22.000vnđ", "20", "Sinh tố bơ bổ dưỡng");
            DrinkingDtg.Rows.Add("DV014", "Sinh tố xoài", "20.000vnđ", "25", "Sinh tố xoài ngọt ngào");
            DrinkingDtg.Rows.Add("DV015", "Sinh tố dâu", "18.000vnđ", "30", "Sinh tố dâu tươi mát");
            DrinkingDtg.Rows.Add("DV016", "Soda chanh", "16.000vnđ", "35", "Soda chanh sảng khoái");
            #endregion
            #region Thẻ cào
            CardDtg.Columns.Add("MaDV", "Mã dịch vụ");
            CardDtg.Columns.Add("TenDV", "Tên dịch vụ");
            CardDtg.Columns.Add("DonGia", "Đơn giá");
            CardDtg.Columns.Add("SoLuong", "Só lượng");
            CardDtg.Columns.Add("MoTa", "Mô tả");

            DataGridViewButtonColumn btnXoaTheCaog = new DataGridViewButtonColumn();
            btnXoaTheCaog.HeaderText = "Xóa dịch vụ";
            btnXoaTheCaog.Name = "btnXoa";
            btnXoaTheCaog.Text = "Xóa";
            btnXoaTheCaog.UseColumnTextForButtonValue = true;
            CardDtg.Columns.Add(btnXoaTheCaog);

            DataGridViewButtonColumn btnChinhSuaTheCao = new DataGridViewButtonColumn();
            btnChinhSuaTheCao.HeaderText = "Chỉnh sửa dịch vụ";
            btnChinhSuaTheCao.Name = "btnChinhSua";
            btnChinhSuaTheCao.Text = "Chỉnh sửa";
            btnChinhSuaTheCao.UseColumnTextForButtonValue = true;
            CardDtg.Columns.Add(btnChinhSuaTheCao);

            CardDtg.Rows.Add("CARD001", "Thẻ Viettel 50.000", "50.000vnđ", "100", "Thẻ nạp điện thoại Viettel");
            CardDtg.Rows.Add("CARD002", "Thẻ Viettel 100.000", "100.000vnđ", "80", "Thẻ nạp điện thoại Viettel");
            CardDtg.Rows.Add("CARD003", "Thẻ MobiFone 50.000", "50.000vnđ", "120", "Thẻ nạp điện thoại MobiFone");
            CardDtg.Rows.Add("CARD004", "Thẻ MobiFone 100.000", "100.000vnđ", "90", "Thẻ nạp điện thoại MobiFone");
            CardDtg.Rows.Add("CARD005", "Thẻ VinaPhone 50.000", "50.000vnđ", "110", "Thẻ nạp điện thoại VinaPhone");
            CardDtg.Rows.Add("CARD006", "Thẻ VinaPhone 100.000", "100.000vnđ", "85", "Thẻ nạp điện thoại VinaPhone");
            CardDtg.Rows.Add("CARD007", "Thẻ Viettel 200.000", "200.000vnđ", "60", "Thẻ nạp điện thoại Viettel");
            CardDtg.Rows.Add("CARD008", "Thẻ MobiFone 200.000", "200.000vnđ", "70", "Thẻ nạp điện thoại MobiFone");
            CardDtg.Rows.Add("CARD009", "Thẻ VinaPhone 200.000", "200.000vnđ", "65", "Thẻ nạp điện thoại VinaPhone");
            CardDtg.Rows.Add("CARD010", "Thẻ Zing 100.000", "100.000vnđ", "50", "Thẻ nạp Zing cho game");
            CardDtg.Rows.Add("CARD011", "Thẻ Garena 100.000", "100.000vnđ", "45", "Thẻ nạp Garena cho game");
            CardDtg.Rows.Add("CARD012", "Thẻ Viettel 500.000", "500.000vnđ", "40", "Thẻ nạp điện thoại Viettel");
            CardDtg.Rows.Add("CARD013", "Thẻ MobiFone 500.000", "500.000vnđ", "35", "Thẻ nạp điện thoại MobiFone");
            CardDtg.Rows.Add("CARD014", "Thẻ VinaPhone 500.000", "500.000vnđ", "38", "Thẻ nạp điện thoại VinaPhone");
            #endregion
        }
    }
}
