namespace AbstractFactoryPattern.FactoryDesign.Factory
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shapeName)
        {
            shapeName = shapeName.ToLower();
            switch (shapeName)
            {
                case "circle":
                    return new Circle();
                    break;
                case "square":
                    return new Square();
                    break;
                case "rectangle":
                    return new Rectangle();
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
