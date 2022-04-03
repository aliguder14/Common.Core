using SecurityDriven.Inferno;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
	public class GenerationIslemleri
	{

		private static CryptoRandom _rnd = new();
		private static IReadOnlyList<OfficialHoliday> _officialHolidays = new List<OfficialHoliday>()
		{
			new OfficialHoliday()
			{
				Date = new DateTime(2005,1,1),
				Name = "Yılbaşı",
				IsReligional = false
			},
		   #region Milli Bayramlar
		 new OfficialHoliday()
			{
				Date = new DateTime(2005,4,23),
				Name = "23 Nisan",
				IsReligional = false
			},
			new OfficialHoliday()
			{
				Date = new DateTime(2005,5,19),
				Name = "19 Mayıs",
				IsReligional = false,
			},
			 new OfficialHoliday()
			{
				Date = new DateTime(2005,8,30),
				Name = "Zafer Bayramı",
				IsReligional = false
			},

			new OfficialHoliday()
			{
				Date = new DateTime(2005,10,29),
				Name = "Cumhuriyet Bayramı",
				IsReligional = false
			}, 
	#endregion


			 #region Ramazan Bayramı Günleri
		new OfficialHoliday()
			{
				Date = new DateTime(2005,11,3),
				IsReligional = true,
				Name = "Ramazan Bayramı 1. Gün",

			},
			  new OfficialHoliday()
			{
				Date = new DateTime(2005,11,4),
				IsReligional = true,
				Name = "Ramazan Bayramı 2. Gün",


			},
			   new OfficialHoliday()
			{
				Date = new DateTime(2005,11,5),
				IsReligional = true,
				Name = "Ramazan Bayramı 3. Gün",

			}, 
	#endregion

				#region Kurban Bayramı Günleri
		new OfficialHoliday()
			{
				Date = new DateTime(2005,11,3),
				IsReligional = true
			},
			  new OfficialHoliday()
			{
				Date = new DateTime(2005,11,4),
				IsReligional = true
			},
			   new OfficialHoliday()
			{
				Date = new DateTime(2005,11,5),
				IsReligional = true
			}, 
	#endregion


		};


		public static long GenerateTCKN()
		{
			long minimumTCKN = 10000000078L;
			long maksimumTCKN = 99999999990L;

			long generatedTCKN = _rnd.NextLong(minimumTCKN, maksimumTCKN + 1);

			if (!ValidationIslemleri.ValidTCKN(generatedTCKN))
			{
				return GenerateTCKN();
			}

		   
			return generatedTCKN;
		}

		public static long GetMinimumValidTCKN()
		{

			long tckn = 10_000_000_000L;
			while (!ValidationIslemleri.ValidTCKN(tckn))
			{
				tckn++;
			}
			
			 return tckn;
		}

		public static long GetMaximumValidTCKN()
		{

			long tckn = 99_999_999_999L;
			while (!ValidationIslemleri.ValidTCKN(tckn))
			{
				tckn--;
			}

			return tckn;
		}


	}
}
