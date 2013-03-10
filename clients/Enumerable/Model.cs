using System;
using System.Linq;
using System.Collections;

namespace mvc4.Models.EntitiesEditCreate
{
	public class Model : IEnumerable
    {
        public string value { get; private set; }

        public Model(string value)
        {
            this.value = value;
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}