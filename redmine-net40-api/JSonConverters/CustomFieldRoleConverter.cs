using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Redmine.Net.Api.Types;

namespace Redmine.Net.Api.JSonConverters
{
    internal class CustomFieldRoleConverter : IdentifiableNameConverter
    {
        #region Overrides of JavaScriptConverter

        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            if (dictionary != null)
            {
                var entity = new CustomFieldRole();

                entity.Id = dictionary.GetValue<int>("id");
                entity.Name = dictionary.GetValue<string>("name");

                return entity;
            }

            return null;
        }

        public override IEnumerable<Type> SupportedTypes { get { return new List<Type>(new[] { typeof(CustomFieldRole) }); } }

        #endregion
    }
}