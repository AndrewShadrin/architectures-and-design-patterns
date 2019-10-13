using System.Collections.Generic;

namespace Lesson_5_1
{
    public class FiguresFabric
    {
        static Dictionary<string, IDrawFigure> dic = new Dictionary<string, IDrawFigure>();

        public IDrawFigure GetFigure(string figureType)
        {
            if (!dic.ContainsKey(figureType))
            {
                dic[figureType] = GetNewDrawFigure(figureType);
            }
            return dic[figureType];
        }
        
        private static  IDrawFigure GetNewDrawFigure(string figureType)
        {
            switch (figureType)
            {
                case "Ellips":
                    return new Ellips();
                case "Rectangle":
                    return new Rectan();
                default:
                    return new UnknownFigure();
            }
        }
    }
}
