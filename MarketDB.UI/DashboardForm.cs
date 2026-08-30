using MarketDB.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
namespace MarketDB.UI
{

    public partial class DashboardForm : Form
    {
        //private readonly MarketDbContext _dbContext;
        //public DashboardForm(MarketDbContext dbContext)
        //{
        //    InitializeComponent();
        //    _dbContext = dbContext;
        //}

        private readonly IDbContextFactory<MarketDbContext> _contextFactory;
        public DashboardForm(IDbContextFactory<MarketDbContext> contextFactory)
        {

            InitializeComponent();
            _contextFactory = contextFactory;
        }

        private void btnUrunleriListele_Click(object sender, EventArgs e)
        {

            try
            {
                using var context = _contextFactory.CreateDbContext();
                var urunler = context.Products.ToList();
                dgvUrunler.DataSource = urunler;
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Database hatası: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik hata: " + ex.Message);
            }
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            var frm = new frmUrunIslemleriForm(_contextFactory);
            frm.Show();
        }

        private void btnMarketIslemleri_Click(object sender, EventArgs e)
        {
            var frmMarket = new frmMarketIslemleriForm(_contextFactory);
            frmMarket.Show();
        }
    }
}
