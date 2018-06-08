using designPatterns.SimpleFactory.Operations;

namespace designPatterns.SimpleFactory
{
    public class OperationFactory
    {
        public IOperation CreateOperate(OperationObject operate)
        {
            switch (operate)
            {
                case OperationObject.add:
                    {
                        return new OperationAdd();
                    }
                case OperationObject.Sub:
                    {
                        return new OperationSub();
                    }
                case OperationObject.Mul:
                    {
                        return new OperationMul();
                    }
                case OperationObject.Div:
                    {
                        return new OperationDiv();
                    }
            }

            return null; 
        }
    }
}
