﻿using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching.Operations
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [System.Serializable]
    public class IsBetween : SearchOperation
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <remarks>We usse this for operations that require navigation the search operation tree, but which
        /// are too sensitive to be exposed to the User Interface layer - most notably generation of SQL.</remarks>
        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override bool SupportsParameterization
        {
            get
            {
                return true;
            }
        }

        public override int NumberOfParameters
        {
            get
            {
                return 2;
            }
        }
    }
}