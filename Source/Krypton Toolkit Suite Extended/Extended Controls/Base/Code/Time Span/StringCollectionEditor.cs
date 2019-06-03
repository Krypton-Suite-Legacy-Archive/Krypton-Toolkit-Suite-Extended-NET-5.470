using System;
using System.ComponentModel.Design;

namespace ExtendedControls.Base.Code.TimeSpan
{
    public class StringCollectionEditor : CollectionEditor
    {
        protected virtual string InstructionText => null;

        protected virtual string FormTitle => null;

        public StringCollectionEditor(Type type) : base(type)
        {
        }
    }
}