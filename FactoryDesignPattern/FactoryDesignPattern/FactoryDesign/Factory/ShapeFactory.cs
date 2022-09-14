namespace FactoryDesignPattern.FactoryDesign.Factory
{
    internal class ShapeFactory
    {
        IShape shape = null;
        public IShape GetShape(string shapeName)
        {
            shapeName = shapeName.ToLower();
            switch (shapeName)
            {
                case "circle":
                    shape =  new Circle();
                    break;
                case "square":
                    shape =  new Square();
                    break;
                case "rectangle":
                    shape =  new Rectangle();
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
