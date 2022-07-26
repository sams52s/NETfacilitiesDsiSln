using System.Threading.Tasks;
using Xamarin.Forms;

namespace NETfacilitiesDsi.ViewModel.Base
{
    public abstract class ViewModelBase<INavigationService> :BindableObject
    {
        #region properties

        protected INavigationService NavigationService { get; set; }

        #endregion

        #region methods
        public virtual Task InitializeViewModelAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
        #endregion

    }


}
