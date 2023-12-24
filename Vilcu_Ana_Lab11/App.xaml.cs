using Vilcu_Ana_Lab11.Data;

namespace Vilcu_Ana_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase? Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());

            MainPage = new AppShell();
        }
    }
}
