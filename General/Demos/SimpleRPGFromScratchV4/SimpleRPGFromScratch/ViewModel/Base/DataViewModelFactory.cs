﻿using SimpleRPGFromScratch.Data.Base;

namespace SimpleRPGFromScratch.ViewModel.Base
{
    public class DataViewModelFactory<T, TDataViewModel> : IDataViewModelFactory<T, TDataViewModel>
        where TDataViewModel : IDataViewModel<T>, new()
        where T : IDomainClass
    {
        public TDataViewModel CreateDataViewModel(T obj)
        {
            TDataViewModel dvmObj = new TDataViewModel();
            dvmObj.SetDataObject(obj);
            // dvmObj.SetPageViewModel(pvm);
            return dvmObj;
        }
    }
}