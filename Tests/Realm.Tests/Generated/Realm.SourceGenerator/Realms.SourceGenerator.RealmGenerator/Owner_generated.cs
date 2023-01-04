﻿// <auto-generated />
using MongoDB.Bson;
using Realms;
using Realms.Schema;
using Realms.Tests;
using Realms.Tests.Database;
using Realms.Tests.Generated;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TestAsymmetricObject = Realms.IAsymmetricObject;
using TestEmbeddedObject = Realms.IEmbeddedObject;
using TestRealmObject = Realms.IRealmObject;

namespace Realms.Tests
{
    [Generated]
    [Woven(typeof(OwnerObjectHelper))]
    public partial class Owner : IRealmObject, INotifyPropertyChanged, IReflectableType
    {
        public static Realms.Schema.ObjectSchema RealmSchema = new Realms.Schema.ObjectSchema.Builder("Owner", ObjectSchema.ObjectType.RealmObject)
        {
            Realms.Schema.Property.Primitive("Name", Realms.RealmValueType.String, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "Name"),
            Realms.Schema.Property.Object("TopDog", "Dog", managedName: "TopDog"),
            Realms.Schema.Property.ObjectList("ListOfDogs", "Dog", managedName: "ListOfDogs"),
            Realms.Schema.Property.ObjectSet("SetOfDogs", "Dog", managedName: "SetOfDogs"),
            Realms.Schema.Property.ObjectDictionary("DictOfDogs", "Dog", managedName: "DictOfDogs"),
        }.Build();

        #region IRealmObject implementation

        private IOwnerAccessor _accessor;

        Realms.IRealmAccessor Realms.IRealmObjectBase.Accessor => Accessor;

        internal IOwnerAccessor Accessor => _accessor ?? (_accessor = new OwnerUnmanagedAccessor(typeof(Owner)));

        [IgnoreDataMember, XmlIgnore]
        public bool IsManaged => Accessor.IsManaged;

        [IgnoreDataMember, XmlIgnore]
        public bool IsValid => Accessor.IsValid;

        [IgnoreDataMember, XmlIgnore]
        public bool IsFrozen => Accessor.IsFrozen;

        [IgnoreDataMember, XmlIgnore]
        public Realms.Realm Realm => Accessor.Realm;

        [IgnoreDataMember, XmlIgnore]
        public Realms.Schema.ObjectSchema ObjectSchema => Accessor.ObjectSchema;

        [IgnoreDataMember, XmlIgnore]
        public Realms.DynamicObjectApi DynamicApi => Accessor.DynamicApi;

        [IgnoreDataMember, XmlIgnore]
        public int BacklinksCount => Accessor.BacklinksCount;

        public void SetManagedAccessor(Realms.IRealmAccessor managedAccessor, Realms.Weaving.IRealmObjectHelper helper = null, bool update = false, bool skipDefaults = false)
        {
            var newAccessor = (IOwnerAccessor)managedAccessor;
            var oldAccessor = (IOwnerAccessor)_accessor;
            _accessor = newAccessor;

            if (helper != null)
            {
                if (!skipDefaults)
                {
                    newAccessor.ListOfDogs.Clear();
                    newAccessor.SetOfDogs.Clear();
                    newAccessor.DictOfDogs.Clear();
                }

                if(!skipDefaults || oldAccessor.Name != default(string))
                {
                    newAccessor.Name = oldAccessor.Name;
                }
                if(oldAccessor.TopDog != null)
                {
                    newAccessor.Realm.Add(oldAccessor.TopDog, update);
                }
                newAccessor.TopDog = oldAccessor.TopDog;
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.ListOfDogs, newAccessor.ListOfDogs, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.SetOfDogs, newAccessor.SetOfDogs, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.DictOfDogs, newAccessor.DictOfDogs, update, skipDefaults);
            }

            if (_propertyChanged != null)
            {
                SubscribeForNotifications();
            }

            OnManaged();
        }

        #endregion

        /// <summary>
        /// Called when the object has been managed by a Realm.
        /// </summary>
        /// <remarks>
        /// This method will be called either when a managed object is materialized or when an unmanaged object has been
        /// added to the Realm. It can be useful for providing some initialization logic as when the constructor is invoked,
        /// it is not yet clear whether the object is managed or not.
        /// </remarks>
        partial void OnManaged();

        private event PropertyChangedEventHandler _propertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (_propertyChanged == null)
                {
                    SubscribeForNotifications();
                }

                _propertyChanged += value;
            }

            remove
            {
                _propertyChanged -= value;

                if (_propertyChanged == null)
                {
                    UnsubscribeFromNotifications();
                }
            }
        }

        /// <summary>
        /// Called when a property has changed on this class.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <remarks>
        /// For this method to be called, you need to have first subscribed to <see cref="PropertyChanged"/>.
        /// This can be used to react to changes to the current object, e.g. raising <see cref="PropertyChanged"/> for computed properties.
        /// </remarks>
        /// <example>
        /// <code>
        /// class MyClass : IRealmObject
        /// {
        ///     public int StatusCodeRaw { get; set; }
        ///     public StatusCodeEnum StatusCode => (StatusCodeEnum)StatusCodeRaw;
        ///     partial void OnPropertyChanged(string propertyName)
        ///     {
        ///         if (propertyName == nameof(StatusCodeRaw))
        ///         {
        ///             RaisePropertyChanged(nameof(StatusCode));
        ///         }
        ///     }
        /// }
        /// </code>
        /// Here, we have a computed property that depends on a persisted one. In order to notify any <see cref="PropertyChanged"/>
        /// subscribers that <c>StatusCode</c> has changed, we implement <see cref="OnPropertyChanged"/> and
        /// raise <see cref="PropertyChanged"/> manually by calling <see cref="RaisePropertyChanged"/>.
        /// </example>
        partial void OnPropertyChanged(string propertyName);

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void SubscribeForNotifications()
        {
            Accessor.SubscribeForNotifications(RaisePropertyChanged);
        }

        private void UnsubscribeFromNotifications()
        {
            Accessor.UnsubscribeFromNotifications();
        }

        public static explicit operator Owner(Realms.RealmValue val) => val.AsRealmObject<Owner>();

        public static implicit operator Realms.RealmValue(Owner val) => Realms.RealmValue.Object(val);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public TypeInfo GetTypeInfo() => Accessor.GetTypeInfo(this);

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is InvalidObject)
            {
                return !IsValid;
            }

            if (obj is not Realms.IRealmObjectBase iro)
            {
                return false;
            }

            return Accessor.Equals(iro.Accessor);
        }

        public override int GetHashCode() => IsManaged ? Accessor.GetHashCode() : base.GetHashCode();

        public override string ToString() => Accessor.ToString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        private class OwnerObjectHelper : Realms.Weaving.IRealmObjectHelper
        {
            public void CopyToRealm(Realms.IRealmObjectBase instance, bool update, bool skipDefaults)
            {
                throw new InvalidOperationException("This method should not be called for source generated classes.");
            }

            public Realms.ManagedAccessor CreateAccessor() => new OwnerManagedAccessor();

            public Realms.IRealmObjectBase CreateInstance() => new Owner();

            public bool TryGetPrimaryKeyValue(Realms.IRealmObjectBase instance, out object value)
            {
                value = null;
                return false;
            }
        }
    }
}

namespace Realms.Tests.Generated
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal interface IOwnerAccessor : Realms.IRealmAccessor
    {
        string Name { get; set; }

        Realms.Tests.Dog TopDog { get; set; }

        System.Collections.Generic.IList<Realms.Tests.Dog> ListOfDogs { get; }

        System.Collections.Generic.ISet<Realms.Tests.Dog> SetOfDogs { get; }

        System.Collections.Generic.IDictionary<string, Realms.Tests.Dog> DictOfDogs { get; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class OwnerManagedAccessor : Realms.ManagedAccessor, IOwnerAccessor
    {
        public string Name
        {
            get => (string)GetValue("Name");
            set => SetValue("Name", value);
        }

        public Realms.Tests.Dog TopDog
        {
            get => (Realms.Tests.Dog)GetValue("TopDog");
            set => SetValue("TopDog", value);
        }

        private System.Collections.Generic.IList<Realms.Tests.Dog> _listOfDogs;
        public System.Collections.Generic.IList<Realms.Tests.Dog> ListOfDogs
        {
            get
            {
                if (_listOfDogs == null)
                {
                    _listOfDogs = GetListValue<Realms.Tests.Dog>("ListOfDogs");
                }

                return _listOfDogs;
            }
        }

        private System.Collections.Generic.ISet<Realms.Tests.Dog> _setOfDogs;
        public System.Collections.Generic.ISet<Realms.Tests.Dog> SetOfDogs
        {
            get
            {
                if (_setOfDogs == null)
                {
                    _setOfDogs = GetSetValue<Realms.Tests.Dog>("SetOfDogs");
                }

                return _setOfDogs;
            }
        }

        private System.Collections.Generic.IDictionary<string, Realms.Tests.Dog> _dictOfDogs;
        public System.Collections.Generic.IDictionary<string, Realms.Tests.Dog> DictOfDogs
        {
            get
            {
                if (_dictOfDogs == null)
                {
                    _dictOfDogs = GetDictionaryValue<Realms.Tests.Dog>("DictOfDogs");
                }

                return _dictOfDogs;
            }
        }
    }

    internal class OwnerUnmanagedAccessor : Realms.UnmanagedAccessor, IOwnerAccessor
    {
        public override ObjectSchema ObjectSchema => Owner.RealmSchema;

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private Realms.Tests.Dog _topDog;
        public Realms.Tests.Dog TopDog
        {
            get => _topDog;
            set
            {
                _topDog = value;
                RaisePropertyChanged("TopDog");
            }
        }

        public System.Collections.Generic.IList<Realms.Tests.Dog> ListOfDogs { get; } = new List<Realms.Tests.Dog>();

        public System.Collections.Generic.ISet<Realms.Tests.Dog> SetOfDogs { get; } = new HashSet<Realms.Tests.Dog>(RealmSet<Realms.Tests.Dog>.Comparer);

        public System.Collections.Generic.IDictionary<string, Realms.Tests.Dog> DictOfDogs { get; } = new Dictionary<string, Realms.Tests.Dog>();

        public OwnerUnmanagedAccessor(Type objectType) : base(objectType)
        {
        }

        public override Realms.RealmValue GetValue(string propertyName)
        {
            return propertyName switch
            {
                "Name" => _name,
                "TopDog" => _topDog,
                _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
            };
        }

        public override void SetValue(string propertyName, Realms.RealmValue val)
        {
            switch (propertyName)
            {
                case "Name":
                    Name = (string)val;
                    return;
                case "TopDog":
                    TopDog = (Realms.Tests.Dog)val;
                    return;
                default:
                    throw new MissingMemberException($"The object does not have a settable Realm property with name {propertyName}");
            }
        }

        public override void SetValueUnique(string propertyName, Realms.RealmValue val)
        {
            throw new InvalidOperationException("Cannot set the value of an non primary key property with SetValueUnique");
        }

        public override IList<T> GetListValue<T>(string propertyName)
        {
            return propertyName switch
                        {
            "ListOfDogs" => (IList<T>)ListOfDogs,

                            _ => throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}"),
                        };
        }

        public override ISet<T> GetSetValue<T>(string propertyName)
        {
            return propertyName switch
                        {
            "SetOfDogs" => (ISet<T>)SetOfDogs,

                            _ => throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}"),
                        };
        }

        public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
        {
            return propertyName switch
            {
                "DictOfDogs" => (IDictionary<string, TValue>)DictOfDogs,
                _ => throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}"),
            };
        }
    }
}