﻿namespace ExplicitInterfaces.Models.Contracts
{

    public interface IResident
    {
        string Name { get; }

        string Country { get; }

        void GetName();
    }
}
