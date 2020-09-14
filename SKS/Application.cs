using ISKS;

namespace SKS
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic;
        }

        public void Run()
        {
            businessLogic.MyFunction();
        }
    }
}
