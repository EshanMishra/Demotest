﻿using Aspjquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspjquery.PartialModels
{
    public class PartialPerson
    {
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}