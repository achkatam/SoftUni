//Engine might not work with the console!
//There might be differet Apps - Web, Console, Android and etc..
namespace Telephony.Core
{
    using System;

    using Telephony.Core.Contracts;
    using Telephony.Exceptions;
    using Telephony.IO.Contracts;
    using Telephony.Models;
    using Telephony.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartphone smartphone;

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {

            //Limits us to use it just for webApp
            string[] phoneNumbersInput = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] urlInput = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNum in phoneNumbersInput)
            {
                try
                {
                    if (phoneNum.Length == 10)
                        this.writer.Writeline(this.smartphone.Call(phoneNum));
                    else if (phoneNum.Length == 7)
                        this.writer.Writeline(this.stationaryPhone.Call(phoneNum));
                    else
                        throw new InvalidPhoneNumberException();

                }
                catch (InvalidPhoneNumberException ipne)
                {
                    this.writer.Writeline(ipne.Message);
                }
                catch (Exception)
                {
                    //unpredicted error occured
                    throw;
                }
            }

            foreach (var url in urlInput)
            {
                try
                {
                    this.writer.Writeline(this.smartphone.BrowseURL(url));

                }
                catch (InvalidURLException iue)
                {
                    this.writer.Writeline(iue.Message);
                }
                catch (Exception)
                {
                    //unpredicted error occured
                    throw;
                }
            }
        }
    }
}
