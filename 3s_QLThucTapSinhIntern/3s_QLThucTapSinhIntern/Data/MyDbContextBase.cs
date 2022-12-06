namespace _3s_QLThucTapSinhIntern.Data
{
    public class MyDbContextBase
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPCN-I-TUANVV\\SQLEXPRESS;Initial Catalog=3s_QLthuctapsinhIntern;Integrated Security=True");
        }
    }
}