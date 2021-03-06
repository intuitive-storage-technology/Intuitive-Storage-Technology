﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation;
using Intuitive_Storage_Technology.Annotations;

namespace Intuitive_Storage_Technology.Model
{
    class LagerstatusSingleton : INotifyPropertyChanged
    {

        #region PropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Instance Field
        private static LagerstatusSingleton _instance = null;
        
        #endregion

        
        #region Constructor

        private LagerstatusSingleton()
        {
            VareOC = new ObservableCollection<Vare>();
        }
        #endregion




        #region Property

        public ObservableCollection<Vare> VareOC { get; set; }

        public static LagerstatusSingleton Instance
        {
            get
            {
                if (_instance == null) _instance = new LagerstatusSingleton();
                return _instance;
            }
        }
        #endregion



        public void test()
        {
            Vare vare1 = new Vare("navnTest1", 1, "Type1", 5, "vareTilstand");
            Vare vare2 = new Vare("navnTest1", 1, "Type1", 5, "vareTilstand");
            Vare vare3 = new Vare("navnTest1", 1, "Type1", 5, "vareTilstand");
            Vare vare4 = new Vare("navnTest1", 1, "Type1", 5, "vareTilstand");
            Vare vare5 = new Vare("navnTest1", 1, "Type1", 5, "vareTilstand");
            VareOC.Add(vare1);
            VareOC.Add(vare2);
            VareOC.Add(vare3);
            VareOC.Add(vare4);
            VareOC.Add(vare5);

        }


    }
}
