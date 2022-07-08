using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace WPF_Learning.ViewModel
{
    public class MRTLevelVM: ObservableObject
    {
        Model.MRTLevel _level;
        public MRTLevelVM(string _name, int _index)
        {
            _level = new Model.MRTLevel(_name, _index);
        }

        public MRTLevelVM(Model.MRTLevel level)
        {
            _level = level;
        }
        public string name
        {
            get => _level.name;
            set => SetProperty(_level.name, value, _level, (u, n) => u.name = n);
        }

        public double height
        {
            get => _level.height;
            set => SetProperty(_level.height, value, _level, (u, n) => u.height = n);
        }

        public int index
        {
            get => _level.index;
            set => SetProperty(_level.index, value, _level, (u, n) => u.index = n);
        }

        public override string ToString()
        {
            return _level.name;
        }
    }
}
