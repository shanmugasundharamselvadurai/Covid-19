using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Base
{
    public abstract class BasePageModel : FreshBasePageModel
    {
        bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; RaisePropertyChanged(); }
        }

        protected async Task PushModalAsync<T>(bool animate = true) where T : FreshBasePageModel
        {
            await PushModalAsync<T>(null, animate);
        }

        protected async Task PushModalAsync<T>(object data, bool animate = true) where T : FreshBasePageModel
        {
            await CoreMethods.PushPageModel<T>(data, true, animate);
        }

        protected async Task PushAsync<T>() where T : FreshBasePageModel
        {
            await CoreMethods.PushPageModel<T>(true);
        }

        protected async Task PushAsync<T>(object data) where T : FreshBasePageModel
        {
            await CoreMethods.PushPageModel<T>(data, false, true);
        }

        protected async Task PopToRootAsync()
        {
            await CoreMethods.PopToRoot(true);
        }

        protected async Task PopAsync()
        {
            await CoreMethods.PopPageModel(true);
        }

        protected async Task PopAsync(object data)
        {
            await CoreMethods.PopPageModel(data, false, true);
        }

        protected async Task PopModalAsync()
        {
            await CoreMethods.PopPageModel(true, true);
        }

        protected async Task PopModalAsync(object data)
        {
            await CoreMethods.PopPageModel(data, true, true);
        }
    }
}