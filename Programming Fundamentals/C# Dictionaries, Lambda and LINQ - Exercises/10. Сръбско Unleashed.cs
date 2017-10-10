using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {

            var _VenueSignerTotalMoney = new Dictionary<string, Dictionary<string, ulong>>();
            while (true)
            {
                here:
                var input = Console.ReadLine();
                if (input.Length == 1 || input == "End")
                {
                    break;
                }



                try
                {
                    var arrayWithTwoElements = input.Split('@').ToArray();//toq array se kazva taka shot taka !!! 
                    var singer = arrayWithTwoElements[0];

                    var VenueAndMoneyArray = arrayWithTwoElements[1].Split();
                    var splittedSinger = singer.Split().ToArray();
                    if (splittedSinger.Length < 5 && splittedSinger.Length > 1 && VenueAndMoneyArray.Length > 2 && VenueAndMoneyArray.Length < 6 && splittedSinger[splittedSinger.Length-1]=="")
                    {





                        var ticketCount = ulong.Parse(VenueAndMoneyArray[VenueAndMoneyArray.Length - 1]);
                        var ticketPrice = ulong.Parse(VenueAndMoneyArray[VenueAndMoneyArray.Length - 2]);
                        var venueList = new List<string>();
                        var venue = "";
                        var space = " ";
                        for (int i = 0; i < VenueAndMoneyArray.Length - 2; i++)
                        {
                            venueList.Add(VenueAndMoneyArray[i]);



                        }

                        for (int y = 0; y < venueList.Count; y++)
                        {
                            venue += venueList[y] + space;
                        }

                        if (!_VenueSignerTotalMoney.ContainsKey(venue))
                        {
                            _VenueSignerTotalMoney[venue] = new Dictionary<string, ulong>();
                        }

                        if (!_VenueSignerTotalMoney[venue].ContainsKey(singer))
                        {
                            _VenueSignerTotalMoney[venue][singer] = 0;
                        }
                        _VenueSignerTotalMoney[venue][singer] += ticketCount * ticketPrice;

                        _VenueSignerTotalMoney[venue] = _VenueSignerTotalMoney[venue].OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);
                    }
                }
                catch (Exception)
                {
                    goto here;
                }

                
            }


            foreach (var pkv in _VenueSignerTotalMoney)
            {
                var venue = pkv.Key;
                var singerMoney = pkv.Value;
                var singer = singerMoney.Keys.ToArray();
                var mrusniteSrubskiPariMRAZQSRUBSKOWE = singerMoney.Values.ToArray();

                Console.WriteLine(venue);
                for(int i  = 0;i<_VenueSignerTotalMoney[venue].Count;i++)
                {
                    Console.WriteLine($"#  {singer[i]}-> {mrusniteSrubskiPariMRAZQSRUBSKOWE[i]}");
                }
            }
        }
    }
}