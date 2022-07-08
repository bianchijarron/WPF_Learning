using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WPF_Learning.ViewModel
{
    public class MRTStationVM: ObservableObject
    {
        Model.MRTStation _station;
        ObservableCollection<MRTLevelVM> _levels;
        public MRTStationVM()
        {
            _station = new Model.MRTStation();
            _levels = new ObservableCollection<MRTLevelVM>();

            for (int i = 0; i < Model.BasicStationInfo.level_names.Length; i++)
            {
                _levels.Add(new MRTLevelVM(Model.BasicStationInfo.level_names[i], i));
            }
        }

        public ObservableCollection<MRTLevelVM> Levels//跟step1的Levels綁在一起
        {
            get => _levels;
        }

        public double lenth 
        {
            get=> _station.lenth;
            set=> SetProperty(_station.lenth, value, _station, (u, n) => u.lenth = n); 
        }
        public double width
        {
            get => _station.width;
            set => SetProperty(_station.width, value, _station, (u, n) => u.width = n);
        }
        public double left
        {
            get => _station.left;
            set => SetProperty(_station.left, value, _station, (u, n) => u.left = n);
        }
        public double right
        {
            get => _station.right;
            set => SetProperty(_station.right, value, _station, (u, n) => u.right = n);
        }
        public double top
        {
            get => _station.top;
            set => SetProperty(_station.top, value, _station, (u, n) => u.top = n);
        }
        public double bottom
        {
            get => _station.bottom;
            set => SetProperty(_station.bottom, value, _station, (u, n) => u.bottom = n);
        }
    }
}
