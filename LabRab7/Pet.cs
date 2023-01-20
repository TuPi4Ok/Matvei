using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab7
{
    [Serializable]
    internal class Pet
    {
        private String name; //name; //numTS;
        private String poroda; //adres; //engineType;
        private String klichka; //numTel; //numberPassengerSeats;
        private int bornYear; //kontakt; //driverName;
        private String ownerLastName;
        private DateTime lastDate;
        private String diagnoz;

        public Pet()
        {
        }

        public Pet(string name, string poroda, string klichka, int bornYear, string ownerLastName, DateTime lastDate, string diagnoz)
        {
            this.name = name;
            this.poroda = poroda;
            this.klichka = klichka;
            this.bornYear = bornYear;
            this.ownerLastName = ownerLastName;
            this.lastDate = lastDate;
            this.diagnoz = diagnoz;
        }

        public string Name { get => name; set => name = value; }
        public string Poroda { get => poroda; set => poroda = value; }
        public string Klichka { get => klichka; set => klichka = value; }
        public int BornYear { get => bornYear; set => bornYear = value; }
        public string OwnerLastName { get => ownerLastName; set => ownerLastName = value; }
        public DateTime LastDate { get => lastDate; set => lastDate = value; }
        public string Diagnoz { get => diagnoz; set => diagnoz = value; }
    }
}
