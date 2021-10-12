using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Domain.Models;
using System;

namespace ShopsRUs.Domain.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@gmail.com",
                    PhoneNumber = "09045735473",
                    RoleId = 1,
                },
                new AppUser { 
                    Id = 2,
                    FirstName = "Barnes",
                    LastName = "Olson",
                    Email = "barnesolson@ronbert.com",
                    PhoneNumber = "080465374833",
                    RoleId = 2,
                    CreatedAt = Convert.ToDateTime("2020-02-04t13:24:59Z")
                },
                new AppUser
                {
                    Id = 3,
                    FirstName = "Chuka",
                    LastName = "Moses",
                    Email = "chuka@moses.com",
                    PhoneNumber = "07046537833",
                    RoleId = 3
                },
                new AppUser
                {
                    Id = 4,
                    FirstName = "Clement",
                    LastName = "Azabataram",
                    Email = "clement@gmail.com",
                    PhoneNumber = "08136374833",
                    RoleId = 3,
                    CreatedAt = Convert.ToDateTime("2018-07-04t13:24:59Z")
                },
                new AppUser
                {
                    Id = 5,
                    FirstName = "Tobi",
                    LastName = "Ola",
                    Email = "olatobi@gmail.com",
                    PhoneNumber = "09086574839",
                    RoleId = 2,
                    CreatedAt = Convert.ToDateTime("2019-10-02t13:24:59Z")
                },
                new AppUser
                {
                    Id = 6,
                    FirstName = "Julieth",
                    LastName = "Godwin",
                    Email = "godwinjulieth@gmail.com",
                    PhoneNumber = "0704674833",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 7,
                    FirstName = "Bernard",
                    LastName = "Gabriel",
                    Email = "gabriel@benard.com",
                    PhoneNumber = "080465374833",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 8,
                    FirstName = "Frank",
                    LastName = "Godson",
                    Email = "godson@frank.com",
                    PhoneNumber = "07035374833",
                    RoleId = 2
                },
                new AppUser { 
                    Id = 9,
                    FirstName = "Eunice",
                    LastName = "Beauty",
                    Email = "eunice@beauty.com",
                    PhoneNumber = "09054836483",
                    RoleId = 3
                },
                new AppUser
                {
                    Id = 10,
                    FirstName = "Emmanuel",
                    LastName = "Peter",
                    Email = "emmanuelpeter@gmail.com",
                    PhoneNumber = "09067374367",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 11,
                    FirstName = "Somtoochukwu",
                    LastName = "Onuh",
                    Email = "somtoochukwuonuh@gmail.com",
                    PhoneNumber = "08063737373",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 12,
                    FirstName = "Theresa",
                    LastName = "Samson",
                    Email = "theresa@gmail.com",
                    PhoneNumber = "07074838833",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 13,
                    FirstName = "Francis",
                    LastName = "Joshua",
                    Email = "francisjoshua@gmail.com",
                    PhoneNumber = "0813473747374",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 14,
                    FirstName = "Faith",
                    LastName = "Okafor",
                    Email = "okaforfaith@gmail.com",
                    PhoneNumber = "09037473736",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 15,
                    FirstName = "Godson",
                    LastName = "Emeka",
                    Email = "godsonemeka@gmail.com",
                    PhoneNumber = "0703748483",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 16,
                    FirstName = "Queen",
                    LastName = "Moses",
                    Email = "queen@gmail.com",
                    PhoneNumber = "09063637373",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 17,
                    FirstName = "Grace",
                    LastName = "Oby",
                    Email = "obygrace@gmail.com",
                    PhoneNumber = "07036737373",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 18,
                    FirstName = "Kingsley",
                    LastName = "Emenike",
                    Email = "kingsleyemenike@gmail.com",
                    PhoneNumber = "0813838383",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 19,
                    FirstName = "Joshua",
                    LastName = "Clement",
                    Email = "joshclem@gmail.com",
                    PhoneNumber = "090474838393",
                    RoleId = 2
                },
                new AppUser
                {
                    Id = 20,
                    FirstName = "Obinna",
                    LastName = "Chibueze",
                    Email = "obinnachibueze@gmail.com",
                    PhoneNumber = "09037473833",
                    RoleId = 2
                });
        }
    }
}