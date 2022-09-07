using System;
using System.Text;
using LaborationInterfaces;

//Namnge namespace med ditt namn. Till exempel: Duck_Donald
namespace Lastname_Firstname
{
    public class Laboration_2_LinkedList<TypeName> : ILaboration_2_ListInt<TypeName>
    {
        /// <summary>
        /// Describes how a node in the list is constructed.
        /// A node contains:
        /// * Data (of any type) to be stored and handled in the list type
        /// * A reference to the next node in the list.
        /// </summary>
        internal class Node
        {
            internal TypeName Data { get; set; }
            internal Node Next { get; set; }
        }

        private readonly Node first;

        public TypeName this[uint i] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// The constructor creates a dummy node, that acts as sentinel
        /// for the following nodes in the list.
        /// </summary>
        public Laboration_2_LinkedList()
        {
            // Här saknas kod
        }

        public void AddFirst(TypeName data)
        {
            throw new NotImplementedException();
        }

        public void Iterate(Action<TypeName> action)
        {
            throw new NotImplementedException();
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

        public void RemoveAt(uint index)
        {
            throw new NotImplementedException();
        }

        // Här måste du fylla på med kod.
    }
}
