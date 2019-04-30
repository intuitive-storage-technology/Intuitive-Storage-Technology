using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuitive_Storage_Technology.Model
{
    class Ordre
    {
        #region Properties

        public int OrdreID { get; set; }
        public int OrganisationID { get; set; }
        public ObservableCollection<Vare> VareOC { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
        public string Udleverer { get; set; }


        #endregion

        public Ordre(int ordreId, int organisationId, ObservableCollection<Vare> vareOc, DateTime dateTime, string note, string udleverer)
        {
            OrdreID = ordreId;
            OrganisationID = organisationId;
            VareOC = vareOc;
            DateTime = dateTime;
            Note = note;
            Udleverer = udleverer;
        }


    }
}
