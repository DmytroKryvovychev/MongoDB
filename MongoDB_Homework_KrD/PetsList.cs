using System;
using System.Collections.Generic;

namespace MongoDB_Homework_KrD
{
    public static class PetsList
    {
        public static readonly List<Pet> Pets = new List<Pet>
        {
            new Pet
            {
                Nickname = "Tom",
                Species = Species.Cat,
                RegistrationDate = new DateTime(2020, 11, 12),
                Owner = new Owner
                {
                    Name = "Evil Mouse",
                    Phone = "+380666666666"
                }
            },
            new Pet
            {
                Nickname = "Fill",
                Species = Species.Cat,
                RegistrationDate = new DateTime(2020, 10, 12),
                Owner = new Owner
                {
                    Name = "John Smith",
                    Phone = "+380666666665"
                }
            },
            new Pet
            {
                Nickname = "Billy",
                Species = Species.Dog,
                RegistrationDate = new DateTime(2020, 9, 12),
                Owner = new Owner
                {
                    Name = "Fill Smith",
                    Phone = "+380666666664"
                }
            },
            new Pet
            {
                Nickname = "Kylle",
                Species = Species.Dog,
                RegistrationDate = new DateTime(2020, 8, 12),
                Owner = new Owner
                {
                    Name = "Fill Heath",
                    Phone = "+380666666663"
                }
            },
            new Pet
            {
                Nickname = "Longy",
                Species = Species.Snake,
                RegistrationDate = new DateTime(2020, 7, 12),
                Owner = new Owner
                {
                    Name = "Emma Smith",
                    Phone = "+380666666662"
                }
            },
            new Pet
            {
                Nickname = "Cutie",
                Species = Species.Snake,
                RegistrationDate = new DateTime(2020, 6, 12),
                Owner = new Owner
                {
                    Name = "Annie Taylor",
                    Phone = "+380666666661"
                }
            },
            new Pet
            {
                Nickname = "Lord",
                Species = Species.Snake,
                RegistrationDate = new DateTime(2020, 5, 12),
                Owner = new Owner
                {
                    Name = "Tom Rigle",
                    Phone = "+380666666660"
                }
            },
            new Pet
            {
                Nickname = "Captain",
                Species = Species.Bird,
                RegistrationDate = new DateTime(2020, 4, 12),
                Owner = new Owner
                {
                    Name = "Johnny Jelly",
                    Phone = "+380666666659"
                }
            },
            new Pet
            {
                Nickname = "Sparrow",
                Species = Species.Bird,
                RegistrationDate = new DateTime(2020, 3, 12),
                Owner = new Owner
                {
                    Name = "Johnny Leitel",
                    Phone = "+380666666658"
                }
            },
            new Pet
            {
                Nickname = "Jack",
                Species = Species.Bird,
                RegistrationDate = new DateTime(2020, 2, 12),
                Owner = new Owner
                {
                    Name = "Johnny Weisner",
                    Phone = "+380666666657"
                }
            },
            new Pet
            {
                Nickname = "Arthur",
                Species = Species.Cat,
                RegistrationDate = new DateTime(2020, 1, 12),
                Owner = new Owner
                {
                    Name = "Arthur Weisner",
                    Phone = "+380666666656"
                }
            },
        };
    }
}
