using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string mounth = Console.ReadLine();
            int staying = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            //             Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за целия престой за студио и апартамент. Цените зависят от месеца на престоя:
            //Май и октомври	Юни и септември	Юли и август
            //Студио – 50 лв./нощувка	Студио – 75.20 лв./нощувка	Студио – 76 лв./нощувка
            //Апартамент – 65 лв./нощувка	Апартамент – 68.70 лв./нощувка	Апартамент – 77 лв./нощувка
            //Предлагат се и следните отстъпки:
            //•	За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление. 

            switch (mounth)
            {
                case "May":
                case "October":
                    studioPrice = 50 * staying;
                    apartmentPrice = 65 * staying;
                    if (staying > 7 && staying <= 14)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    else if (staying > 14)
                    {
                        studioPrice -= studioPrice * 0.3;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2 * staying;
                    apartmentPrice = 68.7 * staying;
                    if (staying > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76 * staying;
                    apartmentPrice = 77 * staying;
                    if (staying > 14)
                    {
                        apartmentPrice -= apartmentPrice * 0.1;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");


        }
    }
}
