using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuitive_Storage_Technology.Model
{
    class Kvittering
    {

        #region KvitteringProp
        public int Kvittering { get; set; }
        public int OrganisationID { get; set; }
        public ObservableCollection<Vare> Varelist;
        public bool Tilstand { get; set; }

        #endregion

        #region MyRegion
        public Kvittering(int kvittering, int organisationId, bool tilstand)
        {
            Kvittering = kvittering;
            OrganisationID = organisationId;
            Tilstand = tilstand;
        }
        #endregion
    }
}
