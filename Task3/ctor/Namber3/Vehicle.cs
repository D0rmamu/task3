using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.ctor.Namber3
{
    public class Vehicle
    {
        private int _koordinate;

		public int Koordinate
        {
			get { return _koordinate; }
			set { _koordinate = value; }
		}
        private string _koordinate2;

        public string Koordinate2
        {
            get { return _koordinate2; }
            set { _koordinate2 = value; }
        }

        private int _cena;

		public int Cena
        {
			get { return _cena; }
			set { _cena = value; }
		}

		private int _skorost;

		public int Skorost
		{
			get { return _skorost; }
			set { _skorost = value; }
		}

		private int _gVipusk;

		public int GVipusk
		{
			get { return _gVipusk; }
			set { _gVipusk = value; }
		}

		private int _pasagir;

        public int Pasagir
        {
			get { return _pasagir; }
			set { _pasagir = value; }
		}

	}
}
