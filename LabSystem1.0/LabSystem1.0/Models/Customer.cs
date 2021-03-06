﻿using LabSystem1._0.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabSystem1._0.Models
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Wprowadź imię")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Wprowadź nazwisko")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Wprowadzić adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Województow")]
        public string Voivodeship { get; set; }

        [Display(Name = "Gmina")]
        public string Commune { get; set; }

        [Display(Name = "Miasto/Wieś")]
        public string City { get; set; }

        [Display(Name = "Kod pocztowy")]
        [RegularExpression(@"([0-9]{2})\-?[-\s]?([0-9]{3})$",
            ErrorMessage = "Kod pocztowy zapisany w formacie 00-000")]
        public string PostalCode { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Display(Name = "Preferowany kontakt telefoniczy")]
        public bool PhonePreferred { get; set; }

        [Display(Name = "Numer telefonu:")]
        [RequiredIfTrue(BooleanPropertyName = "PhonePreferred", ErrorMessage = "Skoro preferujesz kontakt telefoniczny, musisz podać numer.")]
        [RegularExpression(@"([\+]){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})\-?[-\s]?([0-9]{3})[-\s]\-?([0-9]{3})$",
            ErrorMessage = "Numer musi być zapisany w formacie 123-123-123")]
        public string Phone { get; set; }

        [Display(Name = "Wprowadził klienta:")]
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}