using System;
using System.Collections.Generic;
using System.Text;
using SimMakers_TEST.ViewModels.Base;

namespace SimMakers_TEST.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок
        private string _title = "Тестовое задание SimMakers";
        /// <summary>Заголовок</summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion
    }
}
