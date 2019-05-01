using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Intuitive_Storage_Technology.Annotations;
using Intuitive_Storage_Technology.Model;

namespace Intuitive_Storage_Technology.ViewModel
{
    class LagerstatusVM : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Prop

        public LagerstatusSingleton LagerstatusSingleton { get; set; }
        #endregion

        #region LagerstatusConstruktor

        public LagerstatusVM()
        {
            LagerstatusSingleton = LagerstatusSingleton.Instance;
            LagerstatusSingleton.VareOC.Add(new Vare("navn", 1, "sd", 2, "lort"));
        }

        
        #endregion

        public void Test()
        {
            LagerstatusSingleton.test();
        }

        public void Test2()
        {
            LagerstatusSingleton.test();
        }

    }
}
