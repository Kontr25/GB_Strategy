using System.Collections.Generic;

namespace _Scripts.Abstraction
{
    public interface IHighlightable
    {
        List<Outline> Outlines { get; }
        void Highlight();
    }
}