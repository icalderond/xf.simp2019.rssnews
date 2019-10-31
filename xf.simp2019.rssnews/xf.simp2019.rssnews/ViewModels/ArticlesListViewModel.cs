using System.Collections.ObjectModel;
using xf.simp2019.rssnews.Models;

namespace xf.simp2019.rssnews.ViewModels
{
    public class ArticlesListViewModel : NotificationEnabledObject
    {
        Services.NCFService service;
        public ArticlesListViewModel()
        {
            service = new Services.NCFService();

            service.GetArticles_Completed += (sender, e) => Articles =
            new ObservableCollection<Article>(e.Results);
            service.GetArticles();
        }

        private ObservableCollection<Article> _Articles;

        public ObservableCollection<Article> Articles
        {
            get { return _Articles; }
            set { Set(ref _Articles, value); }
        }
    }
}
