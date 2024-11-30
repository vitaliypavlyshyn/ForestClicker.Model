using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using ForestClicker.Model.Mapping;
using ForestClicker.Model.Models;
using ForestClicker.Model.ViewModels;

namespace ForestClicker.Model
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        private Mapper _mapper;

        public App()
        {
            _mapper = new MappingHelper().RegisterMap();

            _model = DataModel.Load();
            _viewModel = _mapper.Map<DataViewModel>(_model);

            var window = new MainWindow()
            {
                DataContext = _viewModel
            };

            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = _mapper.Map<DataModel>(_viewModel);
                _model.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                base.OnExit(e);
                throw;
            }
        }

    }
}
