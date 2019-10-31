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

            service.GetArticles_Completed += (sender, e) =>
            {
                Articles = new ObservableCollection<Article>(e.Results);
                IsBusy = false;
            };
            IsBusy = true;
            service.GetArticles();
        }

        private bool _IsBusy;

        public bool IsBusy
        {
            get => _IsBusy;
            set => Set(ref _IsBusy, value);
        }

        private ObservableCollection<Article> _Articles;

        public ObservableCollection<Article> Articles
        {
            get => _Articles;
            set => Set(ref _Articles, value);
        }

        private ActionCommand<string> _RefreshArticlesCommand;

        public ActionCommand<string> RefreshArticlesCommand
        {
            get
            {
                if (_RefreshArticlesCommand == null)
                {
                    _RefreshArticlesCommand = new ActionCommand<string>((param) =>
                      {
                          IsBusy = true;
                          service.GetArticles();
                      });
                }
                return _RefreshArticlesCommand;
            }
            set => Set(ref _RefreshArticlesCommand, value);
        }

    }
}