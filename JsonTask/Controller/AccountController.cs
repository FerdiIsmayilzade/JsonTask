using JsonTask.Services;

namespace JsonTask.Controller
{
    internal class AccountController
    {
        private AccountServices _service;

        public AccountController()
        {
            _service = new AccountServices();
        }

        public void Search()
        {
            bool isContinue=true;

           B: Console.WriteLine("Add username:");
            string username=Console.ReadLine();
            Console.WriteLine("Add password:");
            string password=Console.ReadLine();
            if(_service.Login(username, password))
            {
                do
                {
                    ProductController productController = new ProductController();
                    Console.WriteLine("1-Product siyahisini goster.");
                    Console.WriteLine("2-Texte gore productu goster.");
                    Console.WriteLine("3-Console temizle");
                    int number=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    switch (number)
                    {
                        case 1:
                            
                            productController.GetProducts();
                            break;
                        case 2:
                            Console.WriteLine("Add text:");
                            string text=Console.ReadLine();
                            productController.SearchText(text);
                            break;
                        case 3:
                            Console.Clear();
                            goto B;
                            break;
                    }

                } while(isContinue);
            }
            else
            {
                Console.WriteLine("Account is not exist");
            }
        }
    }
}
