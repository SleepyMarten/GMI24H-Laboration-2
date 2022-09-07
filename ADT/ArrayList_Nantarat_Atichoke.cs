using System;
using LaborationInterfaces;

//Namnge namespace med ditt namn. Till exempel: Duck_Donald
namespace Nantarat_Atichoke

{
    public class Laboration_2_ArrayList<TypeName> : ILaboration_2_ListInt<TypeName>
    {
        public TypeName this[uint i] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private TypeName[] _array = new TypeName[4];
        int count = 0;
        public void AddFirst(TypeName data)
        {
            if (this.count == _array.Length)
            {
                ExpandArray();
            }
        }

        public void AddLast(TypeName data)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(TypeName target)
        {
            throw new NotImplementedException();
        }

        public void Insert(uint index, TypeName data)
        {
            throw new NotImplementedException();
        }

        public void Iterate(Action<TypeName> action)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(uint index)
        {
            throw new NotImplementedException();
        }
    }
}
