using System;
using System.Linq;

namespace GeometryMindbox
{
    //Так как подразумевается, что нужно будет добавлять новые фигуры, то классическая иерархия наследования предпочтительна.
    //Если же необходимо расширять функциональность фигур, то можно использовать подход на основе паттерна "Посетитель"
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    
}

