//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MVC3ObjectContext_StructureMap.Data
{
    public partial class Address
    {
        #region Primitive Properties
    
        public virtual int AddressId
        {
            get;
            set;
        }
    
        public virtual string Street
        {
            get;
            set;
        }
    
        public virtual string City
        {
            get;
            set;
        }
    
        public virtual string State
        {
            get;
            set;
        }
    
        public virtual string Zip
        {
            get;
            set;
        }
    
        public virtual int PersonId
        {
            get { return _personId; }
            set
            {
                if (_personId != value)
                {
                    if (Person != null && Person.PersonId != value)
                    {
                        Person = null;
                    }
                    _personId = value;
                }
            }
        }
        private int _personId;

        #endregion
        #region Navigation Properties
    
        public virtual Person Person
        {
            get { return _person; }
            set
            {
                if (!ReferenceEquals(_person, value))
                {
                    var previousValue = _person;
                    _person = value;
                    FixupPerson(previousValue);
                }
            }
        }
        private Person _person;

        #endregion
        #region Association Fixup
    
        private void FixupPerson(Person previousValue)
        {
            if (previousValue != null && previousValue.Addresses.Contains(this))
            {
                previousValue.Addresses.Remove(this);
            }
    
            if (Person != null)
            {
                if (!Person.Addresses.Contains(this))
                {
                    Person.Addresses.Add(this);
                }
                if (PersonId != Person.PersonId)
                {
                    PersonId = Person.PersonId;
                }
            }
        }

        #endregion
    }
}
