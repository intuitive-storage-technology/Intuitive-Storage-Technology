using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intuitive_Storage_Technology.Model
{
    class Organisation
    {
        #region Properties
        public int OrganisationID { get; set; }
        public int OrganisationNavn { get; set; }
        public ObservableCollection<Vare> UdleveretVareOC { get; set; }
        public ObservableCollection<Kvittering> OrganisationKvitterings { get; set; }
        #endregion

        public Organisation(int organisationId, int organisationNavn)
        {
            OrganisationID = organisationId;
            OrganisationNavn = organisationNavn;
        }
    }
}
