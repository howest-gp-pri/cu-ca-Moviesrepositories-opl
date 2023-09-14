using Core_MovieShop_opl_Afst_Web.ViewModels;

namespace Core_MovieShop_opl_Afst_Web.ViewModels
{
    public class MoviesInfoViewModel : BaseViewModel
    {
        public BaseViewModel Company { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string PageTitle { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
