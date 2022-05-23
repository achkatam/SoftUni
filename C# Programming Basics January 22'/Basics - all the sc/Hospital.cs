using System;

namespace Hospital_vol._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //За даден период от време, всеки ден в болницата пристигат пациенти за преглед. Тя разполага първоначално със 7 лекари.Всеки лекар може да преглежда само по един пациент на ден, но понякога има недостиг на лекари, затова останалите пациенти се изпращат в други болници.Всеки трети ден, болницата прави изчисления и ако броят на непрегледаните пациенти е по - голям от броя на прегледаните, се назначава още един лекар. Като назначаването става преди да започне приемът на пациенти за деня.
            //Напишете програма, която изчислява за дадения период броя на прегледаните и непрегледаните пациенти.
            //Вход
            //Входът се чете от конзолата и съдържа:
            //•	На първия ред – периода, за който трябва да направите изчисления. Цяло число в интервала[1... 1000]
            //•	На следващите редове(равни на броят на дните) – броя пациенти, които пристигат за преглед за текущия ден. Цяло число в интервала[0…10 000]

            int period = int.Parse(Console.ReadLine());


            int treatedPatient = 0;
                int untreatedPatient = 0;
            int patientForTheDay;
            int doctors = 7;

            for (int days = 1; days <= period; days++)
            {
                patientForTheDay = int.Parse(Console.ReadLine());
                if ( days % 3 ==0 && treatedPatient < untreatedPatient)
                {
                    doctors++;
                }

                if (patientForTheDay <= doctors)
                {
                    treatedPatient += patientForTheDay;
                    untreatedPatient += 0;
                }
                else
                {
                    treatedPatient += doctors;
                    untreatedPatient += patientForTheDay - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatient}.");
            Console.WriteLine($"Untreated patients: {untreatedPatient}.");
        }
    }
}
