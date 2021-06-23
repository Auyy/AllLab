using System;
namespace Lab05
{
    public abstract class Operation
    {
        public abstract Double Execute();

        public virtual string Show()
        {
            return "My astract class is Operation";
        }
    }
}

