using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Services
{
    public class PropertyMapping<TSource, TDestination>: IPropertyMapping
    {
        public Dictionary<string, PropertyMappingValue> _mappingDirectory { get; private set; }

        public PropertyMapping(Dictionary<string, PropertyMappingValue> mappingDirectory)
        {
            _mappingDirectory = mappingDirectory ?? throw new ArgumentNullException(nameof(mappingDirectory));
        }

        
        

    }
}
